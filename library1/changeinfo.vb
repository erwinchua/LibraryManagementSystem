Imports System.Data.SqlClient
Public Class changeinfo

    Dim con As SqlConnection = New SqlConnection("Data Source= WEWEN-PC\SQLEXPRESS; Database= db_library; Trusted_Connection=yes;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dr As SqlDataReader

    Private Sub btn_submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_submit.Click
        cmd = New SqlCommand("Insert Into tbl_admin (Username, Password) Values ('" + txtbox_un.Text + "','" + txtbox_newpass.Text + "')", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_library")
        MsgBox("Account has been reset!")
        Me.Hide()
        account.Show()
    End Sub

    Private Sub btn_submit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_submit.Click

    End Sub
End Class