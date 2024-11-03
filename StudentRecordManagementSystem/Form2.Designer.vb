<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Email = New TextBox()
        Password = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(179, 307)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 0
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(117, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 20)
        Label1.TabIndex = 1
        Label1.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(117, 251)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' Email
        ' 
        Email.Location = New Point(262, 139)
        Email.Name = "Email"
        Email.Size = New Size(125, 27)
        Email.TabIndex = 3
        ' 
        ' Password
        ' 
        Password.Location = New Point(262, 244)
        Password.Name = "Password"
        Password.Size = New Size(125, 27)
        Password.TabIndex = 4
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Password)
        Controls.Add(Email)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "LoginForm"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Email As TextBox
    Friend WithEvents Password As TextBox

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
            MessageBox.Show("Login FAIL, try again...")
        End If
    End Sub
End Class
