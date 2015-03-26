Imports System.Data.SqlClient
Public Class inventory
    Dim con As SqlConnection = New SqlConnection("Data Source=WEWEN-PC\SQLEXPRESS; Database=db_library; Trusted_Connection =yes;")
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Friend ID As String
    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        admininterface.Show()
        Me.Hide()

    End Sub
    Private Sub ListView1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick
        ID = ListView1.SelectedItems(0).Text
    End Sub
    Private Sub inventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listview()
    End Sub
    Public Sub OK()
        Txtbox_category.Clear()
        txtbox_title.Clear()
        txtbox_author.Clear()
        txtbox_copies.Clear()

    End Sub
    Private Sub listview()
        Dim str As String = "Select * From tbl_bookswithmaintenance"
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
    Private Sub Txtbox_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtbox_search.TextChanged
        Dim itemcoll(100) As String

        ListView1.Clear()
        ListView1.View = View.Details

        Dim strQ As String = String.Empty
        'strQ = "SELECT * FROM tblInfo"
        strQ = "SELECT * FROM tbl_bookswithmaintenance where Title LIKE '" & Txtbox_search.Text & "%' or Category LIKE '" & Txtbox_search.Text & "%' or Author LIKE '" & Txtbox_search.Text & "%' "
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
    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        cmd = New SqlCommand("Insert Into tbl_bookswithmaintenance (Category, Title, Author ,Copies) Values ('" + Txtbox_category.Text + "','" + txtbox_title.Text + "', '" + txtbox_author.Text + "', '" + txtbox_copies.Text + "')", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_library")
        MsgBox("Books Added!")
        listview()
        OK()

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        If ID = Nothing Then
            MsgBox("Please choose a book to edit.", MsgBoxStyle.Exclamation)
        Else
            Panel2.Enabled = True
            Dim cmd As SqlCommand
            Dim query As String = "SELECT * FROM tbl_bookswithmaintenance WHERE Book_ID='" + ListView1.SelectedItems(0).Text + "'"
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
        listview()
        con.Close()
    End Sub
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        cmd = New SqlCommand("Update tbl_bookswithmaintenance Set Category = '" + txtbx_cat1.Text + "', Title = '" + txtbx_tit1.Text + "', Author= '" + txtbx_aut1.Text + "', Copies = '" + txtbx_cop1.Text + "' Where Book_ID = '" + lbl_bkid2.Text + "'", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_library")
        MsgBox("Updated!")
        listview()
        txtbx_cat1.Text = ""
        txtbx_tit1.Text = ""
        txtbx_aut1.Text = ""
        txtbx_cop1.Text = ""
        lbl_bkid2.Text = ""
        Panel2.Enabled = False
    End Sub
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class