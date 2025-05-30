Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Dim x(3) As String
        Dim i As Integer
        x(0) = txtID.Text
        x(1) = txtName.Text
        x(2) = txtYear.Text
        x(3) = txtSemester.Text
        For i = 0 To 3
            ListBox1.Items.Add(x(i))
        Next
    End Sub
End Class
