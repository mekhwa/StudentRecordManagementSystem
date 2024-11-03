Public Class StudentProfileForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim queryCheck As String = "SELECT COUNT(*) FROM StudentProfile WHERE UserID = ?"
        Dim cmdCheck As New OleDbCommand(queryCheck, conn)
        cmdCheck.Parameters.AddWithValue("@p1", UserID)

        Dim profileExists As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

        If profileExists > 0 Then
            Dim queryUpdate As String = "UPDATE StudentProfile SET PhoneNumber = ?, Address = ?, DOB = ? WHERE UserID = ?"
            Dim cmdUpdate As New OleDbCommand(queryUpdate, conn)
            cmdUpdate.Parameters.AddWithValue("@p1", PhoneNumber.Text)
            cmdUpdate.Parameters.AddWithValue("@p2", Address.Text)
            cmdUpdate.Parameters.AddWithValue("@p3", DOB.Value)
            cmdUpdate.Parameters.AddWithValue("@p4", UserID)
            cmdUpdate.ExecuteNonQuery()
            MessageBox.Show("Done update profile!")
        Else
            Dim queryInsert As String = "INSERT INTO StudentProfile (UserID, PhoneNumber, Address, DOB) VALUES (?, ?, ?, ?)"
            Dim cmdInsert As New OleDbCommand(queryInsert, conn)
            cmdInsert.Parameters.AddWithValue("@p1", CurrentUserID)
            cmdInsert.Parameters.AddWithValue("@p2", PhoneNumber.Text)
            cmdInsert.Parameters.AddWithValue("@p3", Address.Text)
            cmdInsert.Parameters.AddWithValue("@p4", DOB.Value)
            cmdInsert.ExecuteNonQuery()
            MessageBox.Show("Profil has been save!")
        End If
    End Sub
End Class