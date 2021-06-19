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
        Me.lblid = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.lblroll = New System.Windows.Forms.Label()
        Me.txtroll = New System.Windows.Forms.TextBox()
        Me.lblbranch = New System.Windows.Forms.Label()
        Me.txtbranch = New System.Windows.Forms.TextBox()
        Me.DGVStudentDetails = New System.Windows.Forms.DataGridView()
        Me.HasnainMakadaDataSet = New Practical_14_Dotnet_2_.HasnainMakadaDataSet()
        Me.STUDENTDETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STUDENT_DETAILSTableAdapter = New Practical_14_Dotnet_2_.HasnainMakadaDataSetTableAdapters.STUDENT_DETAILSTableAdapter()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.STDIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STDNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STDROLLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STDBRANCHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnclose = New System.Windows.Forms.Button()
        CType(Me.DGVStudentDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HasnainMakadaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTDETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(12, 15)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(79, 25)
        Me.lblid.TabIndex = 0
        Me.lblid.Text = "Enter Id"
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(115, 12)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(161, 28)
        Me.txtid.TabIndex = 1
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(629, 13)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(115, 25)
        Me.lblname.TabIndex = 2
        Me.lblname.Text = "Enter Name"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(773, 14)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(163, 28)
        Me.txtname.TabIndex = 3
        '
        'lblroll
        '
        Me.lblroll.AutoSize = True
        Me.lblroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblroll.Location = New System.Drawing.Point(12, 93)
        Me.lblroll.Name = "lblroll"
        Me.lblroll.Size = New System.Drawing.Size(95, 25)
        Me.lblroll.TabIndex = 4
        Me.lblroll.Text = "Enter Roll"
        '
        'txtroll
        '
        Me.txtroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtroll.Location = New System.Drawing.Point(115, 90)
        Me.txtroll.Name = "txtroll"
        Me.txtroll.Size = New System.Drawing.Size(161, 28)
        Me.txtroll.TabIndex = 5
        '
        'lblbranch
        '
        Me.lblbranch.AutoSize = True
        Me.lblbranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbranch.Location = New System.Drawing.Point(629, 90)
        Me.lblbranch.Name = "lblbranch"
        Me.lblbranch.Size = New System.Drawing.Size(125, 25)
        Me.lblbranch.TabIndex = 6
        Me.lblbranch.Text = "Enter Branch"
        '
        'txtbranch
        '
        Me.txtbranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbranch.Location = New System.Drawing.Point(773, 87)
        Me.txtbranch.Name = "txtbranch"
        Me.txtbranch.Size = New System.Drawing.Size(163, 28)
        Me.txtbranch.TabIndex = 7
        '
        'DGVStudentDetails
        '
        Me.DGVStudentDetails.AutoGenerateColumns = False
        Me.DGVStudentDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGVStudentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVStudentDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STDIDDataGridViewTextBoxColumn, Me.STDNAMEDataGridViewTextBoxColumn, Me.STDROLLDataGridViewTextBoxColumn, Me.STDBRANCHDataGridViewTextBoxColumn})
        Me.DGVStudentDetails.DataSource = Me.STUDENTDETAILSBindingSource
        Me.DGVStudentDetails.Location = New System.Drawing.Point(170, 169)
        Me.DGVStudentDetails.Name = "DGVStudentDetails"
        Me.DGVStudentDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGVStudentDetails.RowTemplate.Height = 24
        Me.DGVStudentDetails.Size = New System.Drawing.Size(574, 150)
        Me.DGVStudentDetails.TabIndex = 8
        '
        'HasnainMakadaDataSet
        '
        Me.HasnainMakadaDataSet.DataSetName = "HasnainMakadaDataSet"
        Me.HasnainMakadaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STUDENTDETAILSBindingSource
        '
        Me.STUDENTDETAILSBindingSource.DataMember = "STUDENT_DETAILS"
        Me.STUDENTDETAILSBindingSource.DataSource = Me.HasnainMakadaDataSet
        '
        'STUDENT_DETAILSTableAdapter
        '
        Me.STUDENT_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'btninsert
        '
        Me.btninsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.Location = New System.Drawing.Point(42, 383)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(100, 36)
        Me.btninsert.TabIndex = 9
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(284, 383)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(102, 36)
        Me.btnupdate.TabIndex = 10
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(539, 383)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(115, 36)
        Me.btndelete.TabIndex = 11
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'STDIDDataGridViewTextBoxColumn
        '
        Me.STDIDDataGridViewTextBoxColumn.DataPropertyName = "STD_ID"
        Me.STDIDDataGridViewTextBoxColumn.HeaderText = "STD_ID"
        Me.STDIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.STDIDDataGridViewTextBoxColumn.Name = "STDIDDataGridViewTextBoxColumn"
        Me.STDIDDataGridViewTextBoxColumn.Width = 86
        '
        'STDNAMEDataGridViewTextBoxColumn
        '
        Me.STDNAMEDataGridViewTextBoxColumn.DataPropertyName = "STD_NAME"
        Me.STDNAMEDataGridViewTextBoxColumn.HeaderText = "STD_NAME"
        Me.STDNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.STDNAMEDataGridViewTextBoxColumn.Name = "STDNAMEDataGridViewTextBoxColumn"
        Me.STDNAMEDataGridViewTextBoxColumn.Width = 112
        '
        'STDROLLDataGridViewTextBoxColumn
        '
        Me.STDROLLDataGridViewTextBoxColumn.DataPropertyName = "STD_ROLL"
        Me.STDROLLDataGridViewTextBoxColumn.HeaderText = "STD_ROLL"
        Me.STDROLLDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.STDROLLDataGridViewTextBoxColumn.Name = "STDROLLDataGridViewTextBoxColumn"
        Me.STDROLLDataGridViewTextBoxColumn.Width = 110
        '
        'STDBRANCHDataGridViewTextBoxColumn
        '
        Me.STDBRANCHDataGridViewTextBoxColumn.DataPropertyName = "STD_BRANCH"
        Me.STDBRANCHDataGridViewTextBoxColumn.HeaderText = "STD_BRANCH"
        Me.STDBRANCHDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.STDBRANCHDataGridViewTextBoxColumn.Name = "STDBRANCHDataGridViewTextBoxColumn"
        Me.STDBRANCHDataGridViewTextBoxColumn.Width = 130
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(773, 383)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(105, 36)
        Me.btnclose.TabIndex = 12
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 450)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.DGVStudentDetails)
        Me.Controls.Add(Me.txtbranch)
        Me.Controls.Add(Me.lblbranch)
        Me.Controls.Add(Me.txtroll)
        Me.Controls.Add(Me.lblroll)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.lblid)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGVStudentDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HasnainMakadaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTDETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblid As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents lblroll As Label
    Friend WithEvents txtroll As TextBox
    Friend WithEvents lblbranch As Label
    Friend WithEvents txtbranch As TextBox
    Friend WithEvents DGVStudentDetails As DataGridView
    Friend WithEvents HasnainMakadaDataSet As HasnainMakadaDataSet
    Friend WithEvents STUDENTDETAILSBindingSource As BindingSource
    Friend WithEvents STUDENT_DETAILSTableAdapter As HasnainMakadaDataSetTableAdapters.STUDENT_DETAILSTableAdapter
    Friend WithEvents btninsert As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents STDIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STDNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STDROLLDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STDBRANCHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnclose As Button
End Class
