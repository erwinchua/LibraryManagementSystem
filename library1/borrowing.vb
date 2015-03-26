Imports System.Data.SqlClient
Public Class borrowing

    Dim con As SqlConnection = New SqlConnection("Data Source= WEWEN-PC\SQLEXPRESS; Database= db_library; Trusted_Connection=yes;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Friend ID As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display1()
    End Sub

    Public Sub display1()
        Dim str As String = "Select * From tbl_borrows"
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim TABLE As New DataTable
        Dim i As Integer

        With cmd
            .CommandText = str
            .Connection = con
        End With

        With da
            .SelectCommand = cmd
            .Fill(TABLE)
        End With

        ListView1.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With ListView1
                .Items.Add(TABLE.Rows(i)("Stud_id"))

                With .Items(.Items.Count - 1).SubItems
                    'Respondent Profile
                    .Add(TABLE.Rows(i)("title"))
                    .Add(TABLE.Rows(i)("quantity"))
                End With
            End With
        Next

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim itemcoll(100) As String

        ListView1.Clear()
        ListView1.View = View.Details

        Dim strQ As String = String.Empty
        'strQ = "SELECT * FROM tblInfo"
        strQ = "SELECT * FROM tbl_borrows where Stud_id LIKE '" & TextBox1.Text & "%' or title LIKE '" & TextBox1.Text & "%' or quantity LIKE '" & TextBox1.Text & "%' "
        cmd = New SqlCommand(strQ, con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "db_library")
        Dim i As Integer = 0
        Dim j As Integer = 0
        ' adding the columns in ListView
        For i = 0 To ds.Tables(0).Columns.Count - 1
            Me.ListView1.Columns.Add(ds.Tables(0).Columns(i).ColumnName.ToString())
        Next
        'Now adding the Items in Listview
        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString()
            Next
            Dim lvi As New ListViewItem(itemcoll)
            Me.ListView1.Items.Add(lvi)
        Next

        con.Close()
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Hide()
        admininterface.Show()
    End Sub
End Class