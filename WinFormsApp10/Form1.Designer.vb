<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(487, 363)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 32)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(487, 420)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 32)
        Label2.TabIndex = 1
        Label2.Text = "Password:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(635, 351)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(225, 44)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.White
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(635, 420)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(225, 44)
        TextBox2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(579, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(270, 50)
        Label3.TabIndex = 5
        Label3.Text = "Pet Grooming"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(395, 66)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(426, 320)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 15)
        Label6.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(647, 508)
        Button1.Name = "Button1"
        Button1.Size = New Size(190, 49)
        Button1.TabIndex = 9
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1402, 819)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Name = "Form1"
        Text = " "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button

End Class
