Imports System.Data.SqlClient.SqlConnection
Imports System.Data.SqlClient


Public Class Form1

    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Private Sub UPDATE_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabasestudDataSet.stud' table. You can move, or remove it, as needed.
        Me.StudTableAdapter.Fill(Me.DatabasestudDataSet.stud)
        con.ConnectionStringProvider = "Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SOMESH\OneDrive\Documents\Visual Studio 2012\Projects\StudentRecord\StudentRecord\Databasestud.accdb"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        cmd.CommandType = CommandType.Text Then


    End Sub

    Private Sub INSERT_Click(sender As Object, e As EventArgs) Handles INSERT.Click
        StudBindingSource.AddNew()
        con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandType = "insert into stud values('" + txtID.Text + ",'" + txtname.Text + "','" + txtaddr.Text + "','" + txtph.Text + "')"

        cmd.ExecuteNonQuery()

        MessageBox.Show("Record inserted")
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StudBindingSource.AddNew()



    End Sub

    Private Sub DELETE_Click(sender As Object, e As EventArgs) Handles DELETE.Click
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandType = "Delete from stud  where  txtID=""1"""

        cmd.ExecuteNonQuery()


        StudBindingSource.RemoveCurrent()
        MessageBox.Show("Record Deleted....")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PREVIOUS.Click
        StudBindingSource.MovePrevious()

        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandType = "update stud set Stud_name='" + txtname.Text + "'  where  txtID=""2"""

        cmd.ExecuteNonQuery()

        MessageBox.Show("Record updated....")
    End Sub
End Class