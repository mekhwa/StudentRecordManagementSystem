Public Class SubjectRegistrationForm
    Private Sub SubjectRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT SubjectID, SubjectName FROM Subjects"
        Dim cmd As New OleDbCommand(query, conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            ComboBox1.Items.Add(New With {.ID = reader("SubjectID"), .Name = reader("SubjectName")})
        End While
        reader.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedSubject As Object = ComboBox1.SelectedItem
        If selectedSubject IsNot Nothing Then
            Dim query As String = "INSERT INTO StudentSubjects (UserID, SubjectID, EnrollmentDate) VALUES (?, ?, ?)"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@p1", CurrentUserID) ' CurrentUserID ialah ID pengguna yang login
            cmd.Parameters.AddWithValue("@p2", selectedSubject.ID)
            cmd.Parameters.AddWithValue("@p3", DateTime.Now)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Subjek berjaya didaftarkan!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub
End Class