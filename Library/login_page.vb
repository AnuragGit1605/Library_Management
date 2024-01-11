Public Class login_page

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtpw.TextChanged

    End Sub

    Private Sub Btnlog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlog.Click
        If Txtun.Text = "admin" And Txtpw.Text = "123" Then
            pb.Show()
            Txtun.Clear()
            Txtpw.Clear()
        Else
            MessageBox.Show("Invalid Username/Password", "Login Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            Txtun.Clear()
            Txtpw.Clear()
        End If
    End Sub

    Private Sub btncan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncan.Click
        Me.Close()
        mainpage.Close()
        pb.Close()
        pb1.Close()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Admin.Show()

    End Sub
End Class
