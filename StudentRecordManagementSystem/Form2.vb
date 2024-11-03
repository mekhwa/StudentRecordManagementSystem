Public Class LoginForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE Email = ? AND Password = ?"
        Dim cmd As New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("@p1", Email.Text)
        cmd.Parameters.AddWithValue("@p2", Password.Text)

        Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        If result > 0 Then
            MessageBox.Show("Login Success!")
            Me.Hide()
            DashboardForm.Show()
        Else
            MessageBox.Show("Login Fail,Try Again.")
        End If
    End Sub

End Class