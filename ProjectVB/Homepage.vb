Public Class Homepage

    Private Sub Homepage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.LogoProject
        TextBox1.Text = "Project" & Environment.NewLine & "Alternative Programming Language"
        TextBox2.Text = "นายภควัต ตันยาภิรมย์ " & Environment.NewLine & "056050201133-4 ปวค.60/2"
    End Sub
End Class
