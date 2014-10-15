Public Class Form1

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Double
        Dim b As Double
        Dim c As Double

        b = TextBox2.Text

        b = TextBox2.Text
        c = TextBox3.Text
        ListBox1.Items.Add(Math.Sqrt(Math.Pow(c, 2) - Math.Pow(b, 2)))

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim a As Double
        Dim b As Double
        a = TextBox1.Text
        b = TextBox2.Text
        ListBox1.Items.Add(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)))
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
       
        Dim c As Double
        Dim a As Double

        a = TextBox1.Text
        c = TextBox3.Text
        ListBox1.Items.Add(Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2)))
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnSin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSin.Click
        Dim a As Double

        Dim c As Double
        c = TextBox3.Text
        a = TextBox1.Text


        ListBox1.Items.Add(Math.Sin(a / c))
    End Sub

    Private Sub btnCos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCos.Click

        Dim b As Double
        Dim c As Double

        c = TextBox2.Text
        b = TextBox2.Text

        ListBox1.Items.Add(Math.Cos(b / c))
    End Sub

    Private Sub btnTan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTan.Click
        Dim a As Double
        Dim b As Double
        Dim c As Double

        a = TextBox1.Text

        b = TextBox2.Text
        ListBox1.Items.Add(Math.Tan(a / b))
    End Sub
End Class
