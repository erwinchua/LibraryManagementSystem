Imports System.Data.SqlClient
Public Class studentinterface
    Dim con As SqlConnection = New SqlConnection("Data Source=WEWEN-PC\SQLEXPRESS; Database=db_library; Trusted_Connection =yes;")
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter

    Private Sub studentinterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listview()
    End Sub

    Private Sub listview()
        Dim str As String = "Select * From tbl_books"
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
                .Items.Add(TABLE.Rows(i)("Book_ID"))

                With .Items(.Items.Count - 1).SubItems
                    'Respondent Profile
                    .Add(TABLE.Rows(i)("Category"))
                    .Add(TABLE.Rows(i)("Title"))
                    .Add(TABLE.Rows(i)("Author"))
                    .Add(TABLE.Rows(i)("Copies"))

                End With
            End With
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        accessinterface.Show()
        Me.Hide()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub txtbx_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbx_search.TextChanged
        Dim itemcoll(100) As String

        ListView1.Clear()
        ListView1.View = View.Details

        Dim strQ As String = String.Empty
        'strQ = "SELECT * FROM tblInfo"
        strQ = "SELECT * FROM tbl_books where title LIKE '" & txtbx_search.Text & "%' or category LIKE '" & txtbx_search.Text & "%' or author LIKE '" & txtbx_search.Text & "%' "
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
End Class
