Imports System.Data.SqlClient
Public Class Login
    Dim con As SqlConnection = New SqlConnection("Data Source=WEWEN-PC\SQLEXPRESS; Database=db_library; Trusted_Connection =yes;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dr As SqlDataReader


    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtbox_un.Text = "" Or txtbox_pass.Text = "" Then
            MsgBox("Enter your ID and Password")
        Else
            con.Close()
            Try
                con.Open()
            Catch myerror As SqlException
                MsgBox("Error Connecting to Database. Please Try again !")
            End Try
            cmd = New SqlCommand("Select * From tbl_admin where Username= '" + txtbox_un.Text + "' and Password='" + txtbox_pass.Text + "'", con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet()
            cmd.Connection = con
            da.SelectCommand = cmd
            Dim mydata As SqlDataReader
            mydata = cmd.ExecuteReader
            If mydata.HasRows = 0 Then
                MsgBox("Invalid login")
            Else
                admininterface.Show()
                Me.Hide()
            End If
        End If

    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Hide()
        accessinterface.Show()
    End Sub
End Class