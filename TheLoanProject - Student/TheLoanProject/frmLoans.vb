Option Explicit On
Option Strict On

Public Class frmLoans

    Private ConnectionPath As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                                       "Data Source=" & Application.StartupPath & _
                                       "\Loans.mdb"



    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        '1 Declare the conConnection object
        Dim conConnection As New OleDb.OleDbConnection

        '2 Assign the path of the ConnectionString property of the conConnection object
        conConnection.ConnectionString = ConnectionPath

        '3 Open the conConnection object
        conConnection.Open()
        '4 Declare the cmdCommand object
        Dim cmdCommand As New OleDb.OleDbCommand

        '5 Assign the conConnection to the Connection property of the command object
        cmdCommand.Connection = conConnection

        '6 Assign the SQL statement to the CommandText property of the conConnection object
        cmdCommand.CommandText = "SELECT * FROM CustomerLoans"
        '7 Declare the parameter to the Command Object
        '8 Add the parameter to the Command object
        '9 Decalre the table object 
        Dim tblTable As New Data.DataTable

        '10 Perform the ExecuteReader method on the cmdCommand object of the tblTable

        tblTable.Load(cmdCommand.ExecuteReader())

        '11 Assign the tblTable to the datasource property of the datagrid view

        grvLoans.DataSource = tblTable
        '12 Close the conConnection
        conConnection.Close()


    End Sub
End Class
