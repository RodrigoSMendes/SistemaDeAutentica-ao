Public Class Form2
    Dim c As Integer = 0

    Private Sub btnLogin_Click(sender As Object, e As EventArgs)

        Dim f As New Form3
        f.Show()
    End Sub

    Private Sub waitaminute_Tick(sender As Object, e As EventArgs) Handles waitaminute.Tick
        c += 1
        If c = 1 Then
            Me.Hide()
            Form3.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class