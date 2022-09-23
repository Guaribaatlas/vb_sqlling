Imports System.Data.SqlClient
Imports System.Data

Public Class Form1

    Private Function Search1() As DataTable
        Dim query1 As String = "select id,nom,country from table1"
        query1 &= " WHERE id like '%' +@parm1+ '%' "
        query1 &= " OR nom like '%' +@parm1+ '%' "
        query1 &= " OR country like '%' +@parm1+ '%' "
        query1 &= " OR @parm1='' "
        Dim con1 As String = "Data Source=(localdb)\MSSqlLocalDB;Initial Catalog=Dev_Env;Integrated Security=True"
        Using conn As SqlConnection = New SqlConnection(con1)
            Using cmd As SqlCommand = New SqlCommand(query1, conn)
                cmd.Parameters.AddWithValue("@parm1", SearchBox.Text.Trim())
                Using sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    sda.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Me.Search1

    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        DataGridView1.DataSource = Me.Search1
    End Sub

    Private Sub Insert_button_Click(sender As Object, e As EventArgs) Handles Insert_button.Click
        Dim query2 As String = "insert into table1(id, nom, country)values((select ISNULL(MAX(id)+1, 1) from Table1), @nom, @country)"
        Dim query3 As String = "select * form table1"
        Dim con2 As String = "Data Source=(localdb)\MSSqlLocalDB;Initial Catalog=Dev_Env;Integrated Security=True"
        Using conn2 As SqlConnection = New SqlConnection(con2)
            Using cmd As SqlCommand = New SqlCommand(query2, conn2)
                cmd.Parameters.AddWithValue("nom", Nom_box.Text.Trim())
                cmd.Parameters.AddWithValue("country", Country_box.Text.Trim())
                conn2.Open()
                cmd.ExecuteNonQuery()
                Nom_box.Clear()
                Country_box.Clear()
                DataGridView1.DataSource = Me.Search1
                MessageBox.Show("user inserted !")
            End Using
        End Using
    End Sub
End Class
