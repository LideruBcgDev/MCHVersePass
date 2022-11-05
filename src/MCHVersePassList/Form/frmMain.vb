Imports Newtonsoft.Json
Imports Nethereum.Web3
Imports Nethereum.ENS

Public Class frmMain

    Private mAppPath As String
    Private mRpcData As New RpcData
    Private mBindData As New VerseData

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mAppPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
        LoadRpc()
        SettingDataGridView()
        LoadData()
        RebindDataGridView()

        If mRpcData.Mainnet = "" Then
            Me.btnEns.Enabled = False
        End If
        If mRpcData.Polygon = "" Then
            Me.btnHolder.Enabled = False
        End If
    End Sub

    Private Sub LoadRpc()
        Dim filePath As String = IO.Path.Combine(mAppPath, "Data", "rpc.json")

        Try
            Using sr As New IO.StreamReader(filePath, System.Text.Encoding.UTF8)
                Dim json = sr.ReadToEnd()
                mRpcData = JsonConvert.DeserializeObject(Of RpcData)(json)
            End Using
        Catch ex As Exception
            mBindData = New VerseData
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SettingDataGridView()
        Dim addColumn = Sub(dgv As DataGridView, physNm As String, dispNm As String)
                            Dim col As New DataGridViewTextBoxColumn
                            col.Name = physNm
                            col.HeaderText = dispNm
                            col.DataPropertyName = physNm
                            dgv.Columns.Add(col)
                        End Sub

        Me.dgvHolder.AutoGenerateColumns = False
        Me.dgvHolder.Columns.Clear()
        addColumn.invoke(Me.dgvHolder, "tokneId", "ID")
        addColumn.invoke(Me.dgvHolder, "disp_name", "Name")
        addColumn.invoke(Me.dgvHolder, "land_name", "Land")
        addColumn.invoke(Me.dgvHolder, "address", "address")
        addColumn.invoke(Me.dgvHolder, "ens", "ens")
        addColumn.invoke(Me.dgvHolder, "memo", "memo")
        Me.dgvHolder.ReadOnly = True

        Me.dgvLand.AutoGenerateColumns = False
        Me.dgvLand.Columns.Clear()
        addColumn.invoke(Me.dgvLand, "land_name", "Land")
        addColumn.invoke(Me.dgvLand, "count", "count")
        Me.dgvLand.ReadOnly = True
    End Sub

    Private Sub RebindDataGridView()
        Me.dgvHolder.DataSource = Nothing
        Me.dgvHolder.DataSource = mBindData.HolderList
        Me.dgvLand.DataSource = Nothing
        Me.dgvLand.DataSource = mBindData.LandList
    End Sub

    Private Sub LoadData(Optional ByVal filePath As String = "")
        If filePath = "" Then filePath = IO.Path.Combine(mAppPath, "Data", "VerseData.json")

        Try
            Using sr As New System.IO.StreamReader(filePath, System.Text.Encoding.UTF8)
                Dim json = sr.ReadToEnd()
                mBindData = JsonConvert.DeserializeObject(Of VerseData)(json)
            End Using
        Catch ex As Exception
            mBindData = New VerseData
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SaveData()
        Dim json As String = JsonConvert.SerializeObject(mBindData)
        Using sw As New System.IO.StreamWriter(IO.Path.Combine(mAppPath, "Data", "VerseData.json"), False, System.Text.Encoding.UTF8)
            sw.Write(json)
        End Using

        Using sw As New System.IO.StreamWriter(IO.Path.Combine(mAppPath, "Data", $"history_{Now.ToString("yyyyMMdd")}_{Now.ToString("HHmmss")}.json"), False, System.Text.Encoding.UTF8)
            sw.Write(json)
        End Using
    End Sub

    Private Async Sub RefreshHolder(ByVal afterFunc As Action)
        ' MCHVersePass
        Dim ContractAddress As String = "0x33fa42e4b3746000613c53670f1c70ab3344c7e6"

        Dim web3 = New Web3(mRpcData.Polygon)
        Dim handler = web3.Eth.GetContractHandler(ContractAddress)

        'Dim totalSupply = Await handler.QueryAsync(Of IERC721.TotalSupplyOfFunction, Integer)()
        Dim totalSupply = 102
        If mBindData.HolderList.Count >= totalSupply Then Return

        Dim startCount = mBindData.HolderList.Count + 1
        For tokenId As Integer = startCount To totalSupply
            Dim ownerMessages = New IERC721.OwnerOfFunction() With {.tokenId = tokenId}
            Dim owner = Await handler.QueryAsync(Of IERC721.OwnerOfFunction, String)(ownerMessages)

            mBindData.HolderList.Add(New HolderData With {.tokneId = tokenId, .address = owner})
        Next

        afterFunc.Invoke()
    End Sub

    Private Async Sub RefreshEns(ByVal afterFunc As Action)

        For i As Integer = 0 To mBindData.HolderList.Count - 1
            Dim d As HolderData = mBindData.HolderList(i)

            If Not d.ens = String.Empty Then Continue For

            Dim web3 = New Web3(mRpcData.Mainnet)
            Dim handler As New ENSService(web3)

            d.ens = Await handler.ReverseResolveAsync(d.address)
        Next

        afterFunc.Invoke()
    End Sub

    Private Async Sub RefreshLand(ByVal afterFunc As Action)

        For i As Integer = 0 To mBindData.HolderList.Count - 1
            Dim d As HolderData = mBindData.HolderList(i)

            Dim url As String = $"https://www.mycryptoheroes.net/api/proxy/mch/users/{d.address}"

            Using client As New System.Net.Http.HttpClient()
                ' ユーザーエージェント文字列をセット（オプション）
                client.DefaultRequestHeaders.Add(
                    "User-Agent",
                    "Mozilla/5.0 (Windows NT 6.3; Trident/7.0; rv:11.0) like Gecko")
                client.DefaultRequestHeaders.Add("Accept-Language", "ja-JP")
                client.Timeout = TimeSpan.FromSeconds(60.0)

                Try
                    Using response As System.Net.Http.HttpResponseMessage = Await client.GetAsync(url)
                        Dim responseBody As String = response.Content.ReadAsStringAsync().Result
                        Dim oResponse As Newtonsoft.Json.Linq.JObject = CType(Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody), Newtonsoft.Json.Linq.JObject)

                        'レスポンスに含まれる各値を取得
                        If oResponse("user_data") IsNot Nothing Then
                            d.uid = oResponse("user_data")("uid")
                            d.name = oResponse("user_data")("name")
                            If oResponse("user_data")("land_type") IsNot Nothing Then
                                d.land_type = oResponse("user_data")("land_type")
                            Else
                                d.land_type = "0"
                            End If
                        Else
                            d.uid = String.Empty
                            d.name = String.Empty
                            d.land_type = "-"
                        End If
                    End Using

                Catch e As Exception
                    d.uid = String.Empty
                    d.name = String.Empty
                    d.land_type = "-"
                    d.memo = e.Message
                End Try
            End Using
        Next

        afterFunc.Invoke()
    End Sub

    Private Sub SumLandCount()
        Dim dic As New Dictionary(Of String, Integer) From {{"0", 0}, {"1", 0}, {"2", 0}, {"3", 0}, {"4", 0}, {"5", 0}, {"6", 0}, {"7", 0}, {"8", 0}, {"9", 0}, {"-", 0}}

        For i As Integer = 0 To mBindData.HolderList.Count - 1
            Dim d As HolderData = mBindData.HolderList(i)
            dic(d.land_type) += 1
        Next

        mBindData.LandList.Clear()
        For Each key As String In dic.Keys
            mBindData.LandList.Add(New LandData With {.land_type = key, .count = dic(key)})
        Next
    End Sub

    ''' <summary>
    ''' ホルダー更新
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnHolder_Click(sender As Object, e As EventArgs) Handles btnHolder.Click
        'If mRpcData.Polygon = "" Then
        '    MessageBox.Show("RPC未設定")
        '    Return
        'End If

        RefreshHolder(Sub()
                          RebindDataGridView()
                          MessageBox.Show("ホルダー更新完了")
                      End Sub)
    End Sub

    ''' <summary>
    ''' ENS取得
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEns_Click(sender As Object, e As EventArgs) Handles btnEns.Click
        'If mRpcData.Mainnet = "" Then
        '    MessageBox.Show("RPC未設定")
        '    Return
        'End If

        RefreshEns(Sub()
                       RebindDataGridView()
                       MessageBox.Show("ENS取得完了")
                   End Sub)
    End Sub

    ''' <summary>
    ''' ランド更新
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnLand_Click(sender As Object, e As EventArgs) Handles btnLand.Click
        RefreshLand(Sub()
                        SumLandCount()
                        RebindDataGridView()
                        MessageBox.Show("ランド更新完了")
                    End Sub)
    End Sub

    ''' <summary>
    ''' 保存
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveData()
        MessageBox.Show("保存完了")
    End Sub

    ''' <summary>
    ''' 履歴読込
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub bbtnLoadHistory_Click(sender As Object, e As EventArgs) Handles btnLoadHistory.Click
        Using ofd As New OpenFileDialog()
            ofd.FileName = "history*.json"
            ofd.InitialDirectory = IO.Path.Combine(mAppPath, "Data")
            ofd.Filter = "Jsonファイル(*.json)|*.json"

            If Not ofd.ShowDialog() = DialogResult.OK Then Return
            LoadData(ofd.FileName)
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim holderData = New HolderData

        Using frm As New frmVerseHolderData
            frm.HolderData = holderData
            If frm.ShowDialog = DialogResult.Cancel Then Return

            mBindData.HolderList.Add(holderData)
        End Using

        RebindDataGridView()
        Me.dgvHolder.FirstDisplayedScrollingRowIndex = Me.dgvHolder.RowCount - 1
    End Sub

    Private Sub btnUpd_Click(sender As Object, e As EventArgs) Handles btnUpd.Click
        If Me.dgvHolder.SelectedCells.Count = 0 Then Return
        Dim holderData = mBindData.HolderList(Me.dgvHolder.SelectedCells(0).RowIndex)

        Using frm As New frmVerseHolderData
            frm.HolderData = holderData
            If frm.ShowDialog = DialogResult.Cancel Then Return
        End Using
    End Sub

End Class
