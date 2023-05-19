<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StudBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabasestudDataSet = New CURD_operation.DatabasestudDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudaddrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudphDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Database1DataSet1 = New CURD_operation.Database1DataSet()
        Me.StudTableAdapter = New CURD_operation.DatabasestudDataSetTableAdapters.studTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.INSERT = New System.Windows.Forms.Button()
        Me.DELETE = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtaddr = New System.Windows.Forms.TextBox()
        Me.txtph = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PREVIOUS = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.StudBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabasestudDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudBindingSource
        '
        Me.StudBindingSource.DataMember = "stud"
        Me.StudBindingSource.DataSource = Me.DatabasestudDataSet
        '
        'DatabasestudDataSet
        '
        Me.DatabasestudDataSet.DataSetName = "DatabasestudDataSet"
        Me.DatabasestudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudIDDataGridViewTextBoxColumn, Me.StudnameDataGridViewTextBoxColumn, Me.StudaddrDataGridViewTextBoxColumn, Me.StudphDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(396, 178)
        Me.DataGridView1.TabIndex = 12
        '
        'StudIDDataGridViewTextBoxColumn
        '
        Me.StudIDDataGridViewTextBoxColumn.DataPropertyName = "Stud_ID"
        Me.StudIDDataGridViewTextBoxColumn.HeaderText = "Stud_ID"
        Me.StudIDDataGridViewTextBoxColumn.Name = "StudIDDataGridViewTextBoxColumn"
        '
        'StudnameDataGridViewTextBoxColumn
        '
        Me.StudnameDataGridViewTextBoxColumn.DataPropertyName = "Stud_name"
        Me.StudnameDataGridViewTextBoxColumn.HeaderText = "Stud_name"
        Me.StudnameDataGridViewTextBoxColumn.Name = "StudnameDataGridViewTextBoxColumn"
        '
        'StudaddrDataGridViewTextBoxColumn
        '
        Me.StudaddrDataGridViewTextBoxColumn.DataPropertyName = "Stud_addr"
        Me.StudaddrDataGridViewTextBoxColumn.HeaderText = "Stud_addr"
        Me.StudaddrDataGridViewTextBoxColumn.Name = "StudaddrDataGridViewTextBoxColumn"
        '
        'StudphDataGridViewTextBoxColumn
        '
        Me.StudphDataGridViewTextBoxColumn.DataPropertyName = "Stud_ph"
        Me.StudphDataGridViewTextBoxColumn.HeaderText = "Stud_ph"
        Me.StudphDataGridViewTextBoxColumn.Name = "StudphDataGridViewTextBoxColumn"
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudTableAdapter
        '
        Me.StudTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(289, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 270)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'INSERT
        '
        Me.INSERT.Location = New System.Drawing.Point(8, 206)
        Me.INSERT.Name = "INSERT"
        Me.INSERT.Size = New System.Drawing.Size(82, 27)
        Me.INSERT.TabIndex = 0
        Me.INSERT.Text = "INSERT"
        Me.INSERT.UseVisualStyleBackColor = True
        '
        'DELETE
        '
        Me.DELETE.Location = New System.Drawing.Point(96, 206)
        Me.DELETE.Name = "DELETE"
        Me.DELETE.Size = New System.Drawing.Size(66, 27)
        Me.DELETE.TabIndex = 1
        Me.DELETE.Text = "DELETE"
        Me.DELETE.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Stud_ID", True))
        Me.txtID.Location = New System.Drawing.Point(118, 30)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 4
        '
        'txtname
        '
        Me.txtname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Stud_name", True))
        Me.txtname.Location = New System.Drawing.Point(118, 67)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 20)
        Me.txtname.TabIndex = 5
        '
        'txtaddr
        '
        Me.txtaddr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Stud_addr", True))
        Me.txtaddr.Location = New System.Drawing.Point(118, 109)
        Me.txtaddr.Name = "txtaddr"
        Me.txtaddr.Size = New System.Drawing.Size(100, 20)
        Me.txtaddr.TabIndex = 6
        '
        'txtph
        '
        Me.txtph.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Stud_ph", True))
        Me.txtph.Location = New System.Drawing.Point(118, 155)
        Me.txtph.Name = "txtph"
        Me.txtph.Size = New System.Drawing.Size(100, 20)
        Me.txtph.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Stud_ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Stud_name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Stud_Addr"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Stud_ph"
        '
        'PREVIOUS
        '
        Me.PREVIOUS.Location = New System.Drawing.Point(180, 206)
        Me.PREVIOUS.Name = "PREVIOUS"
        Me.PREVIOUS.Size = New System.Drawing.Size(74, 27)
        Me.PREVIOUS.TabIndex = 13
        Me.PREVIOUS.Text = "DELETE"
        Me.PREVIOUS.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(96, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "NEXT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.PREVIOUS)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtph)
        Me.GroupBox1.Controls.Add(Me.txtaddr)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.DELETE)
        Me.GroupBox1.Controls.Add(Me.INSERT)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 286)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 497)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.StudBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabasestudDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Database1DataSet1 As CURD_operation.Database1DataSet
    Friend WithEvents DatabasestudDataSet As CURD_operation.DatabasestudDataSet
    Friend WithEvents StudBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudTableAdapter As CURD_operation.DatabasestudDataSetTableAdapters.studTableAdapter
    Friend WithEvents StudIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudaddrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudphDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents INSERT As System.Windows.Forms.Button
    Friend WithEvents DELETE As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtaddr As System.Windows.Forms.TextBox
    Friend WithEvents txtph As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PREVIOUS As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
