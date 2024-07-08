Public Class Form1
    Dim x, y, r As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        r = x + y
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Tambah" Then
            TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
        ElseIf ComboBox1.Text = "Kurang" Then
            TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
        ElseIf ComboBox1.Text = "Bagi" Then
            TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
        ElseIf ComboBox1.Text = "Kali" Then
            TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)

        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class