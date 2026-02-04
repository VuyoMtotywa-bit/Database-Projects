'Name:Vuyo  
'Surname:Mtotywa
'Date: 21/05/2025


Public Class Form1



    Private ConnectionPath As String = "Provider=Microsoft.Jet.OLEDB.4.0;" &
                                       "Data Source=" & Application.StartupPath &
                                       "\StudentDatabase.mdb"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'The 10 Point Plan
        '1. Declaring a conConnection object
        Dim conConnection As New OleDb.OleDbConnection
        '2. Assigning path tos the ConnectionString property of the conConnection object
        conConnection.ConnectionString = ConnectionPath

        '3. Open the conConnection object 
        conConnection.Open()
        '4. Declare the cmdCommand object
        Dim cmdCommand As New OleDb.OleDbCommand
        '5. Assign the conConnection to the Connection property of the cmdCommand object
        cmdCommand.Connection = conConnection
        '6. Assign the SQL to the CommandText property of the cmdCommand
        cmdCommand.CommandText = "INSERT INTO StudentDetails (StudentNumber, FirstName,Surname,MobileNumber,Email)VALUES(@StudentNumber,@FirstName,@Surname,@MobileNumber,@Email"

        '7. Declare parameters
        Dim parStudentNumber As New OleDb.OleDbParameter("@StudentNumber", txtStudentNumber.Text)
        Dim parFirstName As New OleDb.OleDbParameter("@FirstName", txtFirstname.Text)
        Dim parsSurname As New OleDb.OleDbParameter("@Surname", txtSurname.Text)
        Dim parMobileNumber As New OleDb.OleDbParameter("@MobileNumber", txtMobileNumber.Text)
        Dim parEmail As New OleDb.OleDbParameter("@Email", txtEmail.Text)




        '8. Add parameters to the cmdCommand object
        cmdCommand.Parameters.Add(parStudentNumber)
        cmdCommand.Parameters.Add(parFirstName)
        cmdCommand.Parameters.Add(parsSurname)
        cmdCommand.Parameters.Add(parMobileNumber)
        cmdCommand.Parameters.Add(parEmail)

        '9. Perform the ExecuteNonQuery on the command object
        cmdCommand.ExecuteNonQuery()

        '10.Close the conConnection
        conConnection.Close()



    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        '1. Declaring a conConnection object
        Dim conConnection As New OleDb.OleDbConnection
        '2. Assigning path to the ConnectionString property of the conConnection object
        conConnection.ConnectionString = ConnectionPath

        '3. Open the conConnection object 
        conConnection.Open()
        '4. Declare the cmdCommand object
        Dim cmdCommand As New OleDb.OleDbCommand
        '5. Assign the conConnection to the Connection property of the cmdCommand object
        cmdCommand.Connection = conConnection
        '6. Assign the SQL to the CommandText property of the cmdCommand
        cmdCommand.CommandText = "UPDATE StudentDetails SET @MobileNumber WHERE FirstName = @FirstName"


        '7. Declare parameters


        Dim parMobileNumber As New OleDb.OleDbParameter("@MobileNumber", txtMobileNumber.Text)


        Dim parFirstName As New OleDb.OleDbParameter("@FirstName", txtFirstname.Text)






        '8. Add parameters to the cmdCommand object


        cmdCommand.Parameters.Add(parMobileNumber)

        cmdCommand.Parameters.Add(parFirstName)


        '9. Perform the ExecuteNonQuery on the command object
        cmdCommand.ExecuteNonQuery()

        '10.Close the conConnection
        conConnection.Close()




    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        '1. Declaring a conConnection object
        Dim conConnection As New OleDb.OleDbConnection
        '2. Assigning path to the ConnectionString property of the conConnection object
        conConnection.ConnectionString = ConnectionPath

        '3. Open the conConnection object 
        conConnection.Open()
        '4. Declare the cmdCommand object
        Dim cmdCommand As New OleDb.OleDbCommand
        '5. Assign the conConnection to the Connection property of the cmdCommand object
        cmdCommand.Connection = conConnection
        '6. Assign the SQL to the CommandText property of the cmdCommand
        cmdCommand.CommandText = "DELETE * FROM StudentDetails WHERE FirstName = @FirstName"


        '7. Declare parameters
        Dim parFirstName As New OleDb.OleDbParameter("@FirstName", txtFirstname.Text)

        '8. Add parameters to the cmdCommand object

        cmdCommand.Parameters.Add(parFirstName)


        '9. Perform the ExecuteNonQuery on the command object
        cmdCommand.ExecuteNonQuery()

        '10.Close the conConnection
        conConnection.Close()




    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        '1. Declaring a conConnection object
        Dim conConnection As New OleDb.OleDbConnection
        '2. Assigning path to the ConnectionString property of the conConnection object
        conConnection.ConnectionString = ConnectionPath

        '3. Open the conConnection object 
        conConnection.Open()
        '4. Declare the cmdCommand object
        Dim cmdCommand As New OleDb.OleDbCommand
        '5. Assign the conConnection to the Connection property of the cmdCommand object
        cmdCommand.Connection = conConnection
        '6. Assign the SQL to the CommandText property of the cmdCommand
        cmdCommand.CommandText = "SELECT * FROM StudentDetails WHERE FirstName = @FirstName"


        '7. Declare parameters
        Dim parFirstName As New OleDb.OleDbParameter("@FirstName", txtFirstname.Text)

        '8. Add parameters to the cmdCommand object

        cmdCommand.Parameters.Add(parFirstName)

        '9 Declare a Table Object
        Dim tblTable As New Data.DataTable
        '9. Perform the ExecuteNonQuery on the command object
        cmdCommand.ExecuteReader()


        '10 Perform ExecuteReader() method on the tblTable.Load object
        tblTable.Load(cmdCommand.ExecuteReader())

        '11 Assign tblTable object to the data source property of data grid view
        dgvStudent.DataSource = tblTable



        '12.Close the conConnection
        conConnection.Close()

    End Sub

    Private Sub dgvStudent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudent.CellContentClick

    End Sub
End Class
