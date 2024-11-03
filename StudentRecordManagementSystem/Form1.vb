Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = "INSERT INTO Users (Nama, Email, Password) VALUES (?, ?, ?)"
        Dim cmd As New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("@p1", Name.Text)
        cmd.Parameters.AddWithValue("@p2", Email.Text)
        cmd.Parameters.AddWithValue("@p3", Password.Text)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Pendaftaran berjaya!")
            ' Bawa pengguna ke login form
            Me.Hide()
            LoginForm.Show()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class