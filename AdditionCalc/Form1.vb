Public Class Form1

    Dim a, b, r As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        r = a + b
        TextBox3.Text = r
    End Sub
End Class
