<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoans
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
        Me.grvLoans = New System.Windows.Forms.DataGridView()
        Me.btnView = New System.Windows.Forms.Button()
        CType(Me.grvLoans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grvLoans
        '
        Me.grvLoans.AllowUserToAddRows = False
        Me.grvLoans.AllowUserToDeleteRows = False
        Me.grvLoans.AllowUserToResizeRows = False
        Me.grvLoans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grvLoans.Location = New System.Drawing.Point(11, 68)
        Me.grvLoans.Margin = New System.Windows.Forms.Padding(2)
        Me.grvLoans.MultiSelect = False
        Me.grvLoans.Name = "grvLoans"
        Me.grvLoans.RowHeadersWidth = 62
        Me.grvLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grvLoans.Size = New System.Drawing.Size(1148, 236)
        Me.grvLoans.TabIndex = 2
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(504, 309)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(111, 38)
        Me.btnView.TabIndex = 13
        Me.btnView.Text = "&Display"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'frmLoans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1186, 365)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.grvLoans)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmLoans"
        Me.Text = "Newton Loan Company (Pty) Ltd."
        CType(Me.grvLoans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grvLoans As System.Windows.Forms.DataGridView
    Friend WithEvents btnView As Button
End Class
