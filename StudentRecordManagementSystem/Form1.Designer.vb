<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Name = New TextBox()
        Email = New TextBox()
        Password = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(88, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 37)
        Label1.TabIndex = 0
        Label1.Text = "Register "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(88, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(88, 193)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(88, 267)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 20)
        Label4.TabIndex = 3
        Label4.Text = "Password"
        ' 
        ' Name
        ' 
        Name.Location = New Point(191, 123)
        Name.Name = "Name"
        Name.Size = New Size(125, 27)
        Name.TabIndex = 4
        ' 
        ' Email
        ' 
        Email.Location = New Point(191, 190)
        Email.Name = "Email"
        Email.Size = New Size(125, 27)
        Email.TabIndex = 5
        ' 
        ' Password
        ' 
        Password.Location = New Point(191, 260)
        Password.Name = "Password"
        Password.Size = New Size(125, 27)
        Password.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(402, 322)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 7
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(Password)
        Controls.Add(Email)
        Controls.Add(Name)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Name As TextBox
    Friend WithEvents Email As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents Button1 As Button
End Class
