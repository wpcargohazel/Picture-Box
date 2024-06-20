Public Class MovieSelect

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("17 and below")
        ComboBox1.Items.Add("18 and above")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "17 and below" Then
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            Label3.Text = "Available movie for " + TextBox1.Text + ": Spider Man, The Kid King"

        ElseIf ComboBox1.SelectedItem = ("18 and above") Then
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            Label3.Text = "Available movie for " + TextBox1.Text + ": Spider Man, The Kid King, Gemini Man, Terminator"
        End If
    End Sub
End Class
