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
        Me.Lblef_name = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblM_name = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LblL_name = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Lble_Email = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Male = New System.Windows.Forms.RadioButton()
        Me.Female = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.BTNSubmit = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lblef_name
        '
        Me.Lblef_name.AutoSize = True
        Me.Lblef_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblef_name.Location = New System.Drawing.Point(42, 56)
        Me.Lblef_name.Name = "Lblef_name"
        Me.Lblef_name.Size = New System.Drawing.Size(92, 20)
        Me.Lblef_name.TabIndex = 0
        Me.Lblef_name.Text = "First Name"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(163, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(158, 49)
        Me.TextBox1.TabIndex = 1
        '
        'lblM_name
        '
        Me.lblM_name.AutoSize = True
        Me.lblM_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblM_name.Location = New System.Drawing.Point(43, 142)
        Me.lblM_name.Name = "lblM_name"
        Me.lblM_name.Size = New System.Drawing.Size(90, 17)
        Me.lblM_name.TabIndex = 2
        Me.lblM_name.Text = "Middle Name"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(163, 142)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(158, 49)
        Me.TextBox2.TabIndex = 3
        '
        'LblL_name
        '
        Me.LblL_name.AutoSize = True
        Me.LblL_name.Location = New System.Drawing.Point(49, 257)
        Me.LblL_name.Name = "LblL_name"
        Me.LblL_name.Size = New System.Drawing.Size(74, 17)
        Me.LblL_name.TabIndex = 4
        Me.LblL_name.Text = "Last name"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(163, 257)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(158, 49)
        Me.TextBox3.TabIndex = 5
        '
        'Lble_Email
        '
        Me.Lble_Email.AutoSize = True
        Me.Lble_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Lble_Email.Location = New System.Drawing.Point(59, 365)
        Me.Lble_Email.Name = "Lble_Email"
        Me.Lble_Email.Size = New System.Drawing.Size(57, 17)
        Me.Lble_Email.TabIndex = 6
        Me.Lble_Email.Text = "Email Id"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(161, 363)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(159, 49)
        Me.TextBox4.TabIndex = 7
        '
        'Male
        '
        Me.Male.AutoSize = True
        Me.Male.Location = New System.Drawing.Point(78, 513)
        Me.Male.Name = "Male"
        Me.Male.Size = New System.Drawing.Size(59, 21)
        Me.Male.TabIndex = 8
        Me.Male.TabStop = True
        Me.Male.Text = "Male"
        Me.Male.UseVisualStyleBackColor = True
        '
        'Female
        '
        Me.Female.AutoSize = True
        Me.Female.Location = New System.Drawing.Point(174, 513)
        Me.Female.Name = "Female"
        Me.Female.Size = New System.Drawing.Size(75, 21)
        Me.Female.TabIndex = 9
        Me.Female.TabStop = True
        Me.Female.Text = "Female"
        Me.Female.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 460)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(422, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Age"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(501, 55)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(152, 22)
        Me.NumericUpDown1.TabIndex = 12
        Me.NumericUpDown1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'BTNSubmit
        '
        Me.BTNSubmit.Location = New System.Drawing.Point(184, 582)
        Me.BTNSubmit.Name = "BTNSubmit"
        Me.BTNSubmit.Size = New System.Drawing.Size(135, 31)
        Me.BTNSubmit.TabIndex = 13
        Me.BTNSubmit.Text = "Submit"
        Me.BTNSubmit.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(375, 581)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 31)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(545, 580)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 31)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 640)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BTNSubmit)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Female)
        Me.Controls.Add(Me.Male)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Lble_Email)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.LblL_name)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblM_name)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Lblef_name)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lblef_name As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblM_name As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LblL_name As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Lble_Email As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Male As RadioButton
    Friend WithEvents Female As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents BTNSubmit As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
