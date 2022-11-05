Public Class frmVerseHolderData

    Public Property HolderData As HolderData = Nothing

    Private Sub frmVerseHolderData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If HolderData Is Nothing Then
            HolderData = New HolderData
        Else
            Me.txtTokenId.Text = HolderData.tokneId
            Me.txtAddress.Text = HolderData.address
            Me.txtEns.Text = HolderData.ens
            Me.txtUid.Text = HolderData.uid
            Me.txtName.Text = HolderData.name
            Me.txtLandType.Text = HolderData.land_type
            Me.txtMemo.Text = HolderData.memo
        End If

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        HolderData.tokneId = Me.txtTokenId.Text
        HolderData.address = Me.txtAddress.Text
        HolderData.ens = Me.txtEns.Text
        HolderData.uid = Me.txtUid.Text
        HolderData.name = Me.txtName.Text
        HolderData.land_type = Me.txtLandType.Text
        HolderData.memo = Me.txtMemo.Text

        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub


End Class