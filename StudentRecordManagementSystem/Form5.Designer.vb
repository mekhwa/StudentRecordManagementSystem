<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentProfileForm
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
        Button1 = New Button()
        DOB = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Address = New TextBox()
        PhoneNumber = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(304, 344)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 0
        Button1.Text = "SAVE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DOB
        ' 
        DOB.Location = New Point(223, 272)
        DOB.Name = "DOB"
        DOB.Size = New Size(250, 27)
        DOB.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(170, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 2
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(42, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 20)
        Label2.TabIndex = 3
        Label2.Text = "Phone Number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 20)
        Label3.TabIndex = 4
        Label3.Text = "Address"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(42, 279)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 20)
        Label4.TabIndex = 5
        Label4.Text = "Date of Birth"
        ' 
        ' Address
        ' 
        Address.Location = New Point(223, 179)
        Address.Name = "Address"
        Address.Size = New Size(125, 27)
        Address.TabIndex = 6
        ' 
        ' PhoneNumber
        ' 
        PhoneNumber.Location = New Point(223, 90)
        PhoneNumber.Name = "PhoneNumber"
        PhoneNumber.Size = New Size(125, 27)
        PhoneNumber.TabIndex = 7
        ' 
        ' StudentProfileForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PhoneNumber)
        Controls.Add(Address)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DOB)
        Controls.Add(Button1)
        Name = "StudentProfileForm"
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DOB As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Address As TextBox
    Friend WithEvents PhoneNumber As TextBox
End Class
