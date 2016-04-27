Public Class NameForm
    Public Property PlayerName As String


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtName.Clear()
        txtName.Focus()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtName.Text <> "" Then
            PlayerName = txtName.Text
            Me.Close()
        Else
            MessageBox.Show("You must enter a name", _
                            "NAME IS EMPTY", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Exclamation, _
                            MessageBoxDefaultButton.Button1)
            txtName.Focus()
            txtName.SelectAll()
        End If
    End Sub

    Private Sub NameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Activated
        txtName.Focus()
    End Sub
End Class