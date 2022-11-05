<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerseHolderData
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerseHolderData))
        Me.lblTokenId = New System.Windows.Forms.Label()
        Me.txtTokenId = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtEns = New System.Windows.Forms.TextBox()
        Me.lblEns = New System.Windows.Forms.Label()
        Me.txtUid = New System.Windows.Forms.TextBox()
        Me.lblUid = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtLandType = New System.Windows.Forms.TextBox()
        Me.lblLandType = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtMemo = New System.Windows.Forms.TextBox()
        Me.lblMemo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTokenId
        '
        Me.lblTokenId.AutoSize = True
        Me.lblTokenId.Location = New System.Drawing.Point(36, 20)
        Me.lblTokenId.Name = "lblTokenId"
        Me.lblTokenId.Size = New System.Drawing.Size(42, 12)
        Me.lblTokenId.TabIndex = 0
        Me.lblTokenId.Text = "tokenId"
        '
        'txtTokenId
        '
        Me.txtTokenId.Location = New System.Drawing.Point(111, 17)
        Me.txtTokenId.Name = "txtTokenId"
        Me.txtTokenId.Size = New System.Drawing.Size(217, 19)
        Me.txtTokenId.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtMemo)
        Me.Panel1.Controls.Add(Me.lblMemo)
        Me.Panel1.Controls.Add(Me.txtLandType)
        Me.Panel1.Controls.Add(Me.lblLandType)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.txtUid)
        Me.Panel1.Controls.Add(Me.lblUid)
        Me.Panel1.Controls.Add(Me.txtEns)
        Me.Panel1.Controls.Add(Me.lblEns)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.lblAddress)
        Me.Panel1.Controls.Add(Me.txtTokenId)
        Me.Panel1.Controls.Add(Me.lblTokenId)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 206)
        Me.Panel1.TabIndex = 2
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(111, 42)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(217, 19)
        Me.txtAddress.TabIndex = 3
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(36, 45)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 12)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "address"
        '
        'txtEns
        '
        Me.txtEns.Location = New System.Drawing.Point(111, 67)
        Me.txtEns.Name = "txtEns"
        Me.txtEns.Size = New System.Drawing.Size(217, 19)
        Me.txtEns.TabIndex = 5
        '
        'lblEns
        '
        Me.lblEns.AutoSize = True
        Me.lblEns.Location = New System.Drawing.Point(36, 70)
        Me.lblEns.Name = "lblEns"
        Me.lblEns.Size = New System.Drawing.Size(23, 12)
        Me.lblEns.TabIndex = 4
        Me.lblEns.Text = "ens"
        '
        'txtUid
        '
        Me.txtUid.Location = New System.Drawing.Point(111, 92)
        Me.txtUid.Name = "txtUid"
        Me.txtUid.Size = New System.Drawing.Size(217, 19)
        Me.txtUid.TabIndex = 7
        '
        'lblUid
        '
        Me.lblUid.AutoSize = True
        Me.lblUid.Location = New System.Drawing.Point(36, 95)
        Me.lblUid.Name = "lblUid"
        Me.lblUid.Size = New System.Drawing.Size(20, 12)
        Me.lblUid.TabIndex = 6
        Me.lblUid.Text = "uid"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(111, 117)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(217, 19)
        Me.txtName.TabIndex = 9
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(36, 120)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(32, 12)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "name"
        '
        'txtLandType
        '
        Me.txtLandType.Location = New System.Drawing.Point(111, 142)
        Me.txtLandType.Name = "txtLandType"
        Me.txtLandType.Size = New System.Drawing.Size(217, 19)
        Me.txtLandType.TabIndex = 11
        '
        'lblLandType
        '
        Me.lblLandType.AutoSize = True
        Me.lblLandType.Location = New System.Drawing.Point(36, 145)
        Me.lblLandType.Name = "lblLandType"
        Me.lblLandType.Size = New System.Drawing.Size(51, 12)
        Me.lblLandType.TabIndex = 10
        Me.lblLandType.Text = "landType"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(23, 224)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(110, 36)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(242, 224)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 36)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtMemo
        '
        Me.txtMemo.Location = New System.Drawing.Point(111, 167)
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(217, 19)
        Me.txtMemo.TabIndex = 13
        '
        'lblMemo
        '
        Me.lblMemo.AutoSize = True
        Me.lblMemo.Location = New System.Drawing.Point(36, 170)
        Me.lblMemo.Name = "lblMemo"
        Me.lblMemo.Size = New System.Drawing.Size(35, 12)
        Me.lblMemo.TabIndex = 12
        Me.lblMemo.Text = "memo"
        '
        'frmVerseHolderData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 277)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVerseHolderData"
        Me.Text = "frmVerseHolderData"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTokenId As Label
    Friend WithEvents txtTokenId As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtUid As TextBox
    Friend WithEvents lblUid As Label
    Friend WithEvents txtEns As TextBox
    Friend WithEvents lblEns As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtLandType As TextBox
    Friend WithEvents lblLandType As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtMemo As TextBox
    Friend WithEvents lblMemo As Label
End Class
