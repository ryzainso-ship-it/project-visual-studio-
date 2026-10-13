<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(307, 125)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 15)
        Label1.TabIndex = 2
        Label1.Text = "Full Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(295, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 3
        Label2.Text = "Contact Number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(319, 189)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 15)
        Label3.TabIndex = 4
        Label3.Text = "Address"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(319, 224)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 5
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(295, 324)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 6
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1558, 753)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
