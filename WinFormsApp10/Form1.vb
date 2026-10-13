Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "admin" And TextBox2.Text = "1234" Then

            MessageBox.Show("Login Successful!")

            Form2.Show()
            Me.Hide()

        Else

            MessageBox.Show("Invalid Username or Password!")

        End If

    End Sub
End Class
