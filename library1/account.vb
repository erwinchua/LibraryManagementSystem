Public Class account

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        admininterface.Show()
        Me.Hide()

    End Sub

    Private Sub btn_changepass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_changepass.Click
        Me.Hide()
        changeinfo.Show()
    End Sub
End Class