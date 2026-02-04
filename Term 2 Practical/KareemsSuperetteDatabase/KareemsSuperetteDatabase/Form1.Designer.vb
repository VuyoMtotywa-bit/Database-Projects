<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvKareem = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.groupCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.grpProductDetails = New System.Windows.Forms.GroupBox()
        Me.btnSelectProd = New System.Windows.Forms.Button()
        Me.btnSaveProd = New System.Windows.Forms.Button()
        Me.btnDeleteProd = New System.Windows.Forms.Button()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpTransactionDetails = New System.Windows.Forms.GroupBox()
        Me.btnInsertTrans = New System.Windows.Forms.Button()
        Me.btnSearchTransactions = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.txtTransProductID = New System.Windows.Forms.TextBox()
        Me.txtTransCustomerID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgvKareem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupCustomerDetails.SuspendLayout()
        Me.grpProductDetails.SuspendLayout()
        Me.grpTransactionDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.WindowText
        Me.btnClear.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnClear.Location = New System.Drawing.Point(668, 358)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 37)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnExit.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnExit.Location = New System.Drawing.Point(668, 401)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 36)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnDelete.Location = New System.Drawing.Point(335, 108)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnSave.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnSave.Location = New System.Drawing.Point(335, 35)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(106, 512)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "&Update"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgvKareem
        '
        Me.dgvKareem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKareem.Location = New System.Drawing.Point(12, 443)
        Me.dgvKareem.Name = "dgvKareem"
        Me.dgvKareem.Size = New System.Drawing.Size(763, 240)
        Me.dgvKareem.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Customer Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Surname:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "CustomerID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Contact Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Email:"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(100, 69)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerName.TabIndex = 12
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(68, 98)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(100, 20)
        Me.txtSurname.TabIndex = 13
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(88, 32)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerID.TabIndex = 14
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(53, 142)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 15
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(108, 181)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtContactNumber.TabIndex = 16
        '
        'groupCustomerDetails
        '
        Me.groupCustomerDetails.Controls.Add(Me.btnSearch)
        Me.groupCustomerDetails.Controls.Add(Me.btnUpdate)
        Me.groupCustomerDetails.Controls.Add(Me.Label1)
        Me.groupCustomerDetails.Controls.Add(Me.txtContactNumber)
        Me.groupCustomerDetails.Controls.Add(Me.txtCustomerName)
        Me.groupCustomerDetails.Controls.Add(Me.Label4)
        Me.groupCustomerDetails.Controls.Add(Me.Label5)
        Me.groupCustomerDetails.Controls.Add(Me.btnDelete)
        Me.groupCustomerDetails.Controls.Add(Me.btnSave)
        Me.groupCustomerDetails.Controls.Add(Me.txtEmail)
        Me.groupCustomerDetails.Controls.Add(Me.Label2)
        Me.groupCustomerDetails.Controls.Add(Me.txtCustomerID)
        Me.groupCustomerDetails.Controls.Add(Me.txtSurname)
        Me.groupCustomerDetails.Controls.Add(Me.Label3)
        Me.groupCustomerDetails.Location = New System.Drawing.Point(12, 12)
        Me.groupCustomerDetails.Name = "groupCustomerDetails"
        Me.groupCustomerDetails.Size = New System.Drawing.Size(410, 229)
        Me.groupCustomerDetails.TabIndex = 17
        Me.groupCustomerDetails.TabStop = False
        Me.groupCustomerDetails.Text = "Customer Details"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnSearch.Location = New System.Drawing.Point(240, 107)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnUpdate.Location = New System.Drawing.Point(335, 184)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'grpProductDetails
        '
        Me.grpProductDetails.Controls.Add(Me.btnSelectProd)
        Me.grpProductDetails.Controls.Add(Me.btnSaveProd)
        Me.grpProductDetails.Controls.Add(Me.btnDeleteProd)
        Me.grpProductDetails.Controls.Add(Me.txtProductID)
        Me.grpProductDetails.Controls.Add(Me.txtProductName)
        Me.grpProductDetails.Controls.Add(Me.txtProductPrice)
        Me.grpProductDetails.Controls.Add(Me.Label8)
        Me.grpProductDetails.Controls.Add(Me.Label7)
        Me.grpProductDetails.Controls.Add(Me.Label6)
        Me.grpProductDetails.Location = New System.Drawing.Point(455, 12)
        Me.grpProductDetails.Name = "grpProductDetails"
        Me.grpProductDetails.Size = New System.Drawing.Size(288, 229)
        Me.grpProductDetails.TabIndex = 18
        Me.grpProductDetails.TabStop = False
        Me.grpProductDetails.Text = "Product Details"
        '
        'btnSelectProd
        '
        Me.btnSelectProd.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnSelectProd.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnSelectProd.Location = New System.Drawing.Point(113, 206)
        Me.btnSelectProd.Name = "btnSelectProd"
        Me.btnSelectProd.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectProd.TabIndex = 19
        Me.btnSelectProd.Text = "&Select"
        Me.btnSelectProd.UseVisualStyleBackColor = False
        '
        'btnSaveProd
        '
        Me.btnSaveProd.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnSaveProd.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnSaveProd.Location = New System.Drawing.Point(207, 206)
        Me.btnSaveProd.Name = "btnSaveProd"
        Me.btnSaveProd.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveProd.TabIndex = 7
        Me.btnSaveProd.Text = "&Insert"
        Me.btnSaveProd.UseVisualStyleBackColor = False
        '
        'btnDeleteProd
        '
        Me.btnDeleteProd.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnDeleteProd.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnDeleteProd.Location = New System.Drawing.Point(16, 206)
        Me.btnDeleteProd.Name = "btnDeleteProd"
        Me.btnDeleteProd.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteProd.TabIndex = 6
        Me.btnDeleteProd.Text = "&Delete"
        Me.btnDeleteProd.UseVisualStyleBackColor = False
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(67, 22)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(100, 20)
        Me.txtProductID.TabIndex = 5
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(83, 65)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(100, 20)
        Me.txtProductName.TabIndex = 4
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Location = New System.Drawing.Point(88, 110)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtProductPrice.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Product Price:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "ProductName:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ProductID:"
        '
        'grpTransactionDetails
        '
        Me.grpTransactionDetails.Controls.Add(Me.btnInsertTrans)
        Me.grpTransactionDetails.Controls.Add(Me.btnSearchTransactions)
        Me.grpTransactionDetails.Controls.Add(Me.Button7)
        Me.grpTransactionDetails.Controls.Add(Me.txtTotalAmount)
        Me.grpTransactionDetails.Controls.Add(Me.txtTransProductID)
        Me.grpTransactionDetails.Controls.Add(Me.txtTransCustomerID)
        Me.grpTransactionDetails.Controls.Add(Me.Label13)
        Me.grpTransactionDetails.Controls.Add(Me.DateTimePicker1)
        Me.grpTransactionDetails.Controls.Add(Me.Label12)
        Me.grpTransactionDetails.Controls.Add(Me.Label11)
        Me.grpTransactionDetails.Controls.Add(Me.Label10)
        Me.grpTransactionDetails.Location = New System.Drawing.Point(12, 264)
        Me.grpTransactionDetails.Name = "grpTransactionDetails"
        Me.grpTransactionDetails.Size = New System.Drawing.Size(427, 173)
        Me.grpTransactionDetails.TabIndex = 19
        Me.grpTransactionDetails.TabStop = False
        Me.grpTransactionDetails.Text = "Transaction Details"
        '
        'btnInsertTrans
        '
        Me.btnInsertTrans.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnInsertTrans.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnInsertTrans.Location = New System.Drawing.Point(240, 34)
        Me.btnInsertTrans.Name = "btnInsertTrans"
        Me.btnInsertTrans.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertTrans.TabIndex = 19
        Me.btnInsertTrans.Text = "&Insert"
        Me.btnInsertTrans.UseVisualStyleBackColor = False
        '
        'btnSearchTransactions
        '
        Me.btnSearchTransactions.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnSearchTransactions.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnSearchTransactions.Location = New System.Drawing.Point(346, 27)
        Me.btnSearchTransactions.Name = "btnSearchTransactions"
        Me.btnSearchTransactions.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchTransactions.TabIndex = 18
        Me.btnSearchTransactions.Text = "&Search"
        Me.btnSearchTransactions.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button7.Location = New System.Drawing.Point(352, 71)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 27)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "&Update"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(124, 105)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalAmount.TabIndex = 9
        '
        'txtTransProductID
        '
        Me.txtTransProductID.Location = New System.Drawing.Point(124, 68)
        Me.txtTransProductID.Name = "txtTransProductID"
        Me.txtTransProductID.Size = New System.Drawing.Size(100, 20)
        Me.txtTransProductID.TabIndex = 8
        '
        'txtTransCustomerID
        '
        Me.txtTransCustomerID.Location = New System.Drawing.Point(124, 34)
        Me.txtTransCustomerID.Name = "txtTransCustomerID"
        Me.txtTransCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.txtTransCustomerID.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Transaction Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(124, 131)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Total Amount:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "ProductID:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "CustomerID:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(817, 695)
        Me.Controls.Add(Me.grpTransactionDetails)
        Me.Controls.Add(Me.grpProductDetails)
        Me.Controls.Add(Me.groupCustomerDetails)
        Me.Controls.Add(Me.dgvKareem)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "Form1"
        Me.Text = "KareemsSuperette"
        CType(Me.dgvKareem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupCustomerDetails.ResumeLayout(False)
        Me.groupCustomerDetails.PerformLayout()
        Me.grpProductDetails.ResumeLayout(False)
        Me.grpProductDetails.PerformLayout()
        Me.grpTransactionDetails.ResumeLayout(False)
        Me.grpTransactionDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvKareem As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents groupCustomerDetails As GroupBox
    Friend WithEvents grpProductDetails As GroupBox
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents grpTransactionDetails As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtTransProductID As TextBox
    Friend WithEvents txtTransCustomerID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSaveProd As Button
    Friend WithEvents btnDeleteProd As Button
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnSelectProd As Button
    Friend WithEvents btnSearchTransactions As Button
    Friend WithEvents btnInsertTrans As Button
End Class
