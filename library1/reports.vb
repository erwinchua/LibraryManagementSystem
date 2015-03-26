Imports System.Data.SqlClient
Public Class reports
    Dim con As SqlConnection = New SqlConnection("Data Source= WEWEN-PC\SQLEXPRESS; Database= db_library; Trusted_Connection=yes;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Friend ID As String

        Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
            admininterface.Show()
            Me.Hide()

        End Sub

        Private Sub reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            display1()
        End Sub
        Public Sub display1()
        Dim str As String = "Select * From tbl_penalties"
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
                .Items.Add(TABLE.Rows(i)("ID"))

                    With .Items(.Items.Count - 1).SubItems
                        'Respondent Profile
                    .Add(TABLE.Rows(i)("Student_id"))
                    .Add(TABLE.Rows(i)("Full_name"))
                    .Add(TABLE.Rows(i)("Course"))
                    .Add(TABLE.Rows(i)("Year"))
                    .Add(TABLE.Rows(i)("Penalties"))

                    End With
                End With
            Next

    End Sub
    Private Sub ListView1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick
        ID = ListView1.SelectedItems(0).Text
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Dim itemcoll(100) As String

        ListView1.Clear()
        ListView1.View = View.Details

        Dim strQ As String = String.Empty
        'strQ = "SELECT * FROM tblInfo"
        strQ = "SELECT * FROM tbl_penalties where Student_id LIKE '" & TextBox6.Text & "%' or Course LIKE '" & TextBox6.Text & "%' or Full_name LIKE '" & TextBox6.Text & "%' "
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd = New SqlCommand("Insert Into tbl_penalties (Student_id, Full_name, Course ,Year, Penalties) Values ('" + TextBox5.Text + "','" + TextBox4.Text + "', '" + TextBox3.Text + "', '" + TextBox2.Text + "', '" + TextBox1.Text + "')", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_library")
        MsgBox("Penalties Added!")
        display1()
        OK()
    End Sub
    Public Sub OK()
        TextBox5.Clear()
        TextBox4.Clear()
        TextBox3.Clear()
        TextBox2.Clear()
        TextBox1.Clear()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ID = Nothing Then
            MsgBox("Please choose a record to delete.", MsgBoxStyle.Exclamation)
        Else
            Dim result As Integer = MessageBox.Show("Do you want to delete this penalty with ID# " + ListView1.SelectedItems(0).Text + "?", "Question:", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Try

                    Dim str As String = "DELETE from tbl_penalties where ID = '" + ListView1.SelectedItems(0).Text + "'"
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
End Class