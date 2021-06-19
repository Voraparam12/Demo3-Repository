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
        Me.LBLno1 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.GBArithmetic = New System.Windows.Forms.GroupBox()
        Me.RBAddition = New System.Windows.Forms.RadioButton()
        Me.RBSubtract = New System.Windows.Forms.RadioButton()
        Me.RBmulti = New System.Windows.Forms.RadioButton()
        Me.RBdiv = New System.Windows.Forms.RadioButton()
        Me.BTResult = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBArithmetic.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBLno1
        '
        Me.LBLno1.AutoSize = True
        Me.LBLno1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLno1.Location = New System.Drawing.Point(12, 42)
        Me.LBLno1.Name = "LBLno1"
        Me.LBLno1.Size = New System.Drawing.Size(148, 25)
        Me.LBLno1.TabIndex = 0
        Me.LBLno1.Text = "Enter Number 1"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(186, 39)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(119, 28)
        Me.MaskedTextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Number 2"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(186, 95)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(119, 28)
        Me.MaskedTextBox2.TabIndex = 3
        '
        'GBArithmetic
        '
        Me.GBArithmetic.Controls.Add(Me.RBdiv)
        Me.GBArithmetic.Controls.Add(Me.RBmulti)
        Me.GBArithmetic.Controls.Add(Me.RBSubtract)
        Me.GBArithmetic.Controls.Add(Me.RBAddition)
        Me.GBArithmetic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBArithmetic.Location = New System.Drawing.Point(17, 193)
        Me.GBArithmetic.Name = "GBArithmetic"
        Me.GBArithmetic.Size = New System.Drawing.Size(346, 186)
        Me.GBArithmetic.TabIndex = 4
        Me.GBArithmetic.TabStop = False
        Me.GBArithmetic.Text = "Arithmetic Operations"
        '
        'RBAddition
        '
        Me.RBAddition.AutoSize = True
        Me.RBAddition.Location = New System.Drawing.Point(15, 58)
        Me.RBAddition.Name = "RBAddition"
        Me.RBAddition.Size = New System.Drawing.Size(104, 29)
        Me.RBAddition.TabIndex = 0
        Me.RBAddition.TabStop = True
        Me.RBAddition.Text = "Addition"
        Me.RBAddition.UseVisualStyleBackColor = True
        '
        'RBSubtract
        '
        Me.RBSubtract.AutoSize = True
        Me.RBSubtract.Location = New System.Drawing.Point(190, 58)
        Me.RBSubtract.Name = "RBSubtract"
        Me.RBSubtract.Size = New System.Drawing.Size(132, 29)
        Me.RBSubtract.TabIndex = 1
        Me.RBSubtract.TabStop = True
        Me.RBSubtract.Text = "Subtraction"
        Me.RBSubtract.UseVisualStyleBackColor = True
        '
        'RBmulti
        '
        Me.RBmulti.AutoSize = True
        Me.RBmulti.Location = New System.Drawing.Point(15, 133)
        Me.RBmulti.Name = "RBmulti"
        Me.RBmulti.Size = New System.Drawing.Size(145, 29)
        Me.RBmulti.TabIndex = 2
        Me.RBmulti.TabStop = True
        Me.RBmulti.Text = "Multiplication"
        Me.RBmulti.UseVisualStyleBackColor = True
        '
        'RBdiv
        '
        Me.RBdiv.AutoSize = True
        Me.RBdiv.Location = New System.Drawing.Point(190, 133)
        Me.RBdiv.Name = "RBdiv"
        Me.RBdiv.Size = New System.Drawing.Size(101, 29)
        Me.RBdiv.TabIndex = 3
        Me.RBdiv.TabStop = True
        Me.RBdiv.Text = "Division"
        Me.RBdiv.UseVisualStyleBackColor = True
        '
        'BTResult
        '
        Me.BTResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTResult.Location = New System.Drawing.Point(326, 470)
        Me.BTResult.Name = "BTResult"
        Me.BTResult.Size = New System.Drawing.Size(121, 43)
        Me.BTResult.TabIndex = 5
        Me.BTResult.Text = "Result"
        Me.BTResult.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(562, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 525)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTResult)
        Me.Controls.Add(Me.GBArithmetic)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.LBLno1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GBArithmetic.ResumeLayout(False)
        Me.GBArithmetic.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLno1 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents GBArithmetic As GroupBox
    Friend WithEvents RBdiv As RadioButton
    Friend WithEvents RBmulti As RadioButton
    Friend WithEvents RBSubtract As RadioButton
    Friend WithEvents RBAddition As RadioButton
    Friend WithEvents BTResult As Button
    Friend WithEvents Label2 As Label
End Class
