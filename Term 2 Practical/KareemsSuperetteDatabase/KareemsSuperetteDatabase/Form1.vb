Option Strict On
Option Explicit On

Public Class Form1



    Dim ConnectionPath As String = "Provider=Microsoft.Jet.OLEDB.4.0;" &
                                       "Data Source=" & Application.StartupPath &
                                       "\KareemsSuperetteDatabase.mdb"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clearing the neccessary textboxes
        txtContactNumber.Clear()
        txtCustomerID.Clear()
        txtCustomerName.Clear()
        txtEmail.Clear()
        txtProductID.Clear()
        txtProductName.Clear()
        txtProductPrice.Clear()
        txtSurname.Clear()
        txtTotalAmount.Clear()
        txtTransCustomerID.Clear()
        txtTransProductID.Clear()






    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
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
        cmdCommand.CommandText = "SELECT* FROM CustomerDetails"

        Dim tblTable As New Data.DataTable

        tblTable.Load(cmdCommand.ExecuteReader())

        dgvKareem.DataSource = tblTable
        '10.Close the conConnection
        conConnection.Close()
    End Sub

    Private Sub groupCustomerDetails_Enter(sender As Object, e As EventArgs) Handles groupCustomerDetails.Enter
        'Enabling the Customer Details Group Box


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
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
        '6. Possibly Assigning the SQL to the CommandText property of the cmdCommand
        cmdCommand.CommandText = "INSERT INTO CustomerDetails (CustomerID, CustomerName,CustomerSurname,ContactNumber,Email)VALUES(@CustomerID,@CustomerName,@CustomerSurname,@ContactNumber,@Email)"



        '7. Declare parameters
        Dim parCustomerID As New OleDb.OleDbParameter("@CustomerID", txtCustomerID.Text)
        Dim parCustomerName As New OleDb.OleDbParameter("@CustomerName", txtCustomerName.Text)
        Dim parCustomerSurname As New OleDb.OleDbParameter("@CustomerSurname", txtSurname.Text)
        Dim parContactNumber As New OleDb.OleDbParameter("@ContactNumber", txtContactNumber.Text)
        Dim parEmail As New OleDb.OleDbParameter("@Email", txtEmail.Text)




        '8. Add parameters to the cmdCommand object
        cmdCommand.Parameters.Add(parCustomerID)
        cmdCommand.Parameters.Add(parCustomerName)
        cmdCommand.Parameters.Add(parCustomerSurname)
        cmdCommand.Parameters.Add(parContactNumber)
        cmdCommand.Parameters.Add(parEmail)

        '9. Perform the ExecuteNonQuery on the command object
        cmdCommand.ExecuteNonQuery()

        '10.Close the conConnection
        conConnection.Close()


        MessageBox.Show("Record Added to the Database", "Notification", MessageBoxButtons.OK)





    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

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
        cmdCommand.CommandText = "DELETE * FROM CustomerDetails WHERE Email = @Email AND CustomerName = @CustomerName"

        '7. Declare parameters
        Dim parEmail As New OleDb.OleDbParameter("@Email", txtEmail.Text)
        Dim parCustomerName As New OleDb.OleDbParameter("@CustomerName", txtCustomerName)




        '8. Add parameters to the cmdCommand object
        cmdCommand.Parameters.Add(parEmail)
        cmdCommand.Parameters.Add(parCustomerName)
        '9. Perform the ExecuteNonQuery on the command object
        cmdCommand.ExecuteNonQuery()

        '10.Close the conConnection
        conConnection.Close()
    End Sub

    Private Sub grpProductDetails_Enter(sender As Object, e As EventArgs) Handles grpProductDetails.Enter
        'Enabling the current Group box while disabling the rest




    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        '1. Declaration of the conConnection object
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
        cmdCommand.CommandText = "UPDATE CustomerDetails SET CustomerID = @CustomerID, CustomerName = @CustomerName, CustomerSurname = @CustomerSurname WHERE ContactNumber = @ContactNumber"


        '7. Declare required parameter

        Dim parCustomerID As New OleDb.OleDbParameter("@CustomerID", txtCustomerID.Text)
        Dim parCustomerName As New OleDb.OleDbParameter("@CustomerName", txtCustomerName.Text)
        Dim parCustomerSurname As New OleDb.OleDbParameter("@CustomerSurname", txtSurname.Text)
        Dim parContactNumber As New OleDb.OleDbParameter("@ContactNumber", txtContactNumber.Text)








        '8. Add parameters to the cmdCommand object


        cmdCommand.Parameters.Add(parCustomerID)
        cmdCommand.Parameters.Add(parCustomerName)
        cmdCommand.Parameters.Add(parCustomerSurname)
        cmdCommand.Parameters.Add(parContactNumber)


        '9. Perform the ExecuteNonQuery on the command object
        cmdCommand.ExecuteNonQuery()

        '10.Close the conConnection
        conConnection.Close()

        MessageBox.Show("Record Updated, Probably", "Notification", MessageBoxButtons.OK)


    End Sub

    Private Sub btnDeleteProd_Click(sender As Object, e As EventArgs) Handles btnDeleteProd.Click
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
        '6. Assign the Delete SQL to the CommandText property of the cmdCommand
        cmdCommand.CommandText = "DELETE * FROM ProductDetails WHERE ProductName = @ProductName AND ProductID = @ProductID"

        '7. Declare parameters
        Dim parProductName As New OleDb.OleDbParameter("@ProductName", txtProductName.Text)
        Dim parProductID As New OleDb.OleDbParameter("@ProductID", txtProductID.Text)


        '8. Add parameters to the cmdCommand object
        cmdCommand.Parameters.Add(parProductName)
        cmdCommand.Parameters.Add(parProductID)

        '9. Perform the ExecuteNonQuery on the command object
        cmdCommand.ExecuteNonQuery()

        '10.Close the conConnection
        conConnection.Close()

        MessageBox.Show("Record Deleted From the Database, I wouldn't do that if I were you", "Notification", MessageBoxButtons.OK)
    End Sub

    Private Sub btnSelectProd_Click(sender As Object, e As EventArgs) Handles btnSelectProd.Click
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
        cmdCommand.CommandText = "SELECT  ProductName, ProductID, ProductPrice FROM ProductDetails; "

        Dim tblTable As New Data.DataTable

        tblTable.Load(cmdCommand.ExecuteReader())

        dgvKareem.DataSource = tblTable
        '10.Close the conConnection
        conConnection.Close()
    End Sub

    Private Sub btnSaveProd_Click(sender As Object, e As EventArgs) Handles btnSaveProd.Click
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
        '6. Possibly Assigning the SQL to the CommandText property of the cmdCommand
        cmdCommand.CommandText = "INSERT INTO ProductDetails (ProductID,ProductName,ProductPrice) VALUES (@ProductID,@ProductName,@ProductPrice)"



        '7. Declare parameters
        Dim parProductID As New OleDb.OleDbParameter("@ProductID", txtProductID.Text)
        Dim parProductName As New OleDb.OleDbParameter("@ProductName", txtProductName.Text)
        Dim parProductPrice As New OleDb.OleDbParameter("@ProductPrice", txtProductPrice.Text)



        '8. Add parameters to the cmdCommand object
        cmdCommand.Parameters.Add(parProductID)
        cmdCommand.Parameters.Add(parProductName)
        cmdCommand.Parameters.Add(parProductPrice)


        '9. Perform the ExecuteNonQuery on the command object
        cmdCommand.ExecuteNonQuery()

        '10.Close the conConnection
        conConnection.Close()


        MessageBox.Show("Record Added to the Database, I think", "Notification", MessageBoxButtons.OK)




    End Sub

    Private Sub grpTransactionDetails_Enter(sender As Object, e As EventArgs) Handles grpTransactionDetails.Enter
        'Enabling the current Group box while disabling the rest



    End Sub

    Private Sub btnSearchTransactions_Click(sender As Object, e As EventArgs) Handles btnSearchTransactions.Click
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
        cmdCommand.CommandText = "SELECT * FROM TransactionDetails WHERE CustomerID = @CustomerID AND ProductID = @ProductID AND TotalAmount = @TotalAmount"
        Dim tblTable As New Data.DataTable

        tblTable.Load(cmdCommand.ExecuteReader())

        dgvKareem.DataSource = tblTable
        '10.Close the conConnection
        conConnection.Close()
    End Sub

    Private Sub grpCustomerDetails_Enter(sender As Object, e As EventArgs) Handles groupCustomerDetails.Enter
        'Enabling the Customer Details Group Box


    End Sub

    Private Sub btnInsertTrans_Click(sender As Object, e As EventArgs) Handles btnInsertTrans.Click
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
        '6. Possibly Assigning the SQL to the CommandText property of the cmdCommand
        cmdCommand.CommandText = "INSERT INTO TransactionDetails(TransactionID, CustomerID, ProductID,TotalAmount)VALUES(@TransactionID,@CustomerID, @ProductID"



        '7. Declare parameters
        Dim parTransactionID As New OleDb.OleDbParameter("@TransactionID", txtProductID.Text)
        Dim parCustomerID As New OleDb.OleDbParameter("@CustomerID", txtProductName.Text)
        Dim parProductID As New OleDb.OleDbParameter("@ProductID", txtProductPrice.Text)



        '8. Add parameters to the cmdCommand object

        cmdCommand.Parameters.Add(parTransactionID)
        cmdCommand.Parameters.Add(parCustomerID)
        cmdCommand.Parameters.Add(parProductID)

        '9. Perform the ExecuteNonQuery on the command object
        cmdCommand.ExecuteNonQuery()

        '10.Close the conConnection
        conConnection.Close()




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim intResponse As Integer

        intResponse = MessageBox.Show("Are You sure you want to exit this wonderful program", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

        If intResponse = vbYes Then
            Me.Close()
        End If

    End Sub
End Class
