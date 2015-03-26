Imports System.Data.SqlClient
Public Class add

    Dim con As SqlConnection = New SqlConnection("Data Source= WEWEN-PC\SQLEXPRESS; Database= db_library; Trusted_Connection=yes;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Friend ID As String
    
    Public Sub OK()
        Txtbox_category.Clear()
        txtbox_title.Clear()
        txtbox_author.Clear()
        txtbox_copies.Clear()

    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        admininterface.Show()
        Me.Hide()

    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        cmd = New SqlCommand("Insert Into tbl_books (category, title, author ,copies) Values ('" + Txtbox_category.Text + "','" + txtbox_title.Text + "', '" + txtbox_author.Text + "', '" + txtbox_copies.Text + "')", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_library")
        MsgBox("Books Added!")
        display1()
        OK()
    End Sub

    Private Sub add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub delete_item_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
        display1()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If ID = Nothing Then
            MsgBox("Please choose a record to delete.", MsgBoxStyle.Exclamation)
        Else
            Dim result As Integer = MessageBox.Show("Do you want to delete this book with ID# " + ListView1.SelectedItems(0).Text + "?", "Question:", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Try

                    Dim str As String = "DELETE from tbl_books where book_id = '" + ListView1.SelectedItems(0).Text + "'"
                    Dim da As New SqlDataAdapter(str, con)
                    Dim ds As New DataSet
                    da.Fill(ds, "db_library")
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
                MsgBox("Information Deleted!")
            End If
            display1()

        End If
    End Sub

    Private Sub ListView1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick
        ID = ListView1.SelectedItems(0).Text
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        If ID = Nothing Then
            MsgBox("Please choose a book to edit.", MsgBoxStyle.Exclamation)
        Else
            Panel2.Enabled = True
            Dim cmd As SqlCommand
            Dim query As String = "SELECT * FROM tbl_books WHERE book_id='" + ListView1.SelectedItems(0).Text + "'"
            cmd = New SqlCommand(query, con)
            Try
                con.Open()
                Dim myreader As SqlDataReader = cmd.ExecuteReader()
                If myreader.Read() Then
                    lbl_bkid2.Text = myreader.GetValue(0)
                    txtbx_cat1.Text = myreader.GetValue(1)
                    txtbx_tit1.Text = myreader.GetValue(2)
                    txtbx_aut1.Text = myreader.GetValue(3)
                    txtbx_cop1.Text = myreader.GetValue(4)
                End If
                myreader.Close()
            Catch ex As System.Exception
                MsgBox(ex.Message)
            End Try
            ID = Nothing
        End If
        con.Close()
        display1()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        cmd = New SqlCommand("Update tbl_books Set category = '" + txtbx_cat1.Text + "', title = '" + txtbx_tit1.Text + "', author= '" + txtbx_aut1.Text + "', copies = '" + txtbx_cop1.Text + "' Where book_id = '" + lbl_bkid2.Text + "'", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_library")
        MsgBox("Updated!")
        display1()
        txtbx_cat1.Text = ""
        txtbx_tit1.Text = ""
        txtbx_aut1.Text = ""
        txtbx_cop1.Text = ""
        lbl_bkid2.Text = ""
        Panel2.Enabled = False
    End Sub

    Private Sub txbox_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbox_search.TextChanged
        Dim itemcoll(100) As String

        ListView1.Clear()
        ListView1.View = View.Details

        Dim strQ As String = String.Empty
        'strQ = "SELECT * FROM tblInfo"
        strQ = "SELECT * FROM tbl_books where title LIKE '" & txbox_search.Text & "%' or category LIKE '" & txbox_search.Text & "%' or author LIKE '" & txbox_search.Text & "%' "
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