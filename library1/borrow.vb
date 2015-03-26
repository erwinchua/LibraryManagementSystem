Imports System.Data.SqlClient
Public Class borrow
    Dim con As SqlConnection = New SqlConnection("Data Source=WEWEN-PC\SQLEXPRESS; Database=db_library; Trusted_Connection =yes;")
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Friend ID As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        admininterface.Show()
        Me.Hide()

    End Sub
    Public Sub OK()
        txtbox_studid.Clear()
        txtbox_book.Clear()
        txtbox_quan.Clear()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd = New SqlCommand("Insert Into tbl_borrows (Stud_id, title, quantity) Values ('" + txtbox_studid.Text + "','" + txtbox_book.Text + "', '" + txtbox_quan.Text + "')", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_library")
        MsgBox("Books Borrowed!")
        display1()
        OK()
    End Sub

    Private Sub borrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display1()
        OK()
    End Sub
    Public Sub display1()
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
                .Items.Add(TABLE.Rows(i)("book_id"))

                With .Items(.Items.Count - 1).SubItems
                    'Respondent Profile
                    .Add(TABLE.Rows(i)("category"))
                    .Add(TABLE.Rows(i)("title"))
                    .Add(TABLE.Rows(i)("author"))
                    .Add(TABLE.Rows(i)("copies"))

                End With
            End With
        Next

    End Sub

    Private Sub txtbox_book_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_book.TextChanged
        Dim itemcoll(100) As String

        ListView1.Clear()
        ListView1.View = View.Details

        Dim strQ As String = String.Empty
        'strQ = "SELECT * FROM tblInfo"
        strQ = "SELECT * FROM tbl_books where title LIKE '" & txtbox_book.Text & "%' or category LIKE '" & txtbox_book.Text & "%' or author LIKE '" & txtbox_book.Text & "%' "
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
    Private Sub ListView1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick
        ID = ListView1.SelectedItems(0).Text
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Studentinfo.Show()
    End Sub

    Private Sub txtbox_quan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_quan.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        borrowing.Show()

    End Sub
End Class