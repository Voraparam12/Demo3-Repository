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
        Me.Lblname = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.DTPDob = New System.Windows.Forms.DateTimePicker()
        Me.Lblmobile = New System.Windows.Forms.Label()
        Me.MTBMobile = New System.Windows.Forms.MaskedTextBox()
        Me.LblHobbies = New System.Windows.Forms.Label()
        Me.LB1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LB2 = New System.Windows.Forms.ListBox()
        Me.Lbladdress = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.LblDisplay = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LLSubmit = New System.Windows.Forms.LinkLabel()
        Me.LLClear = New System.Windows.Forms.LinkLabel()
        Me.LLCancel = New System.Windows.Forms.LinkLabel()
        Me.Lblcity = New System.Windows.Forms.Label()
        Me.CBCity = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Lblname
        '
        Me.Lblname.AutoSize = True
        Me.Lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblname.Location = New System.Drawing.Point(12, 43)
        Me.Lblname.Name = "Lblname"
        Me.Lblname.Size = New System.Drawing.Size(64, 25)
        Me.Lblname.TabIndex = 0
        Me.Lblname.Text = "Name"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(107, 47)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(211, 22)
        Me.txtname.TabIndex = 1
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldob.Location = New System.Drawing.Point(12, 103)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(89, 25)
        Me.lbldob.TabIndex = 2
        Me.lbldob.Text = "Birthdate"
        '
        'DTPDob
        '
        Me.DTPDob.Location = New System.Drawing.Point(107, 105)
        Me.DTPDob.Name = "DTPDob"
        Me.DTPDob.Size = New System.Drawing.Size(211, 22)
        Me.DTPDob.TabIndex = 3
        '
        'Lblmobile
        '
        Me.Lblmobile.AutoSize = True
        Me.Lblmobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblmobile.Location = New System.Drawing.Point(12, 163)
        Me.Lblmobile.Name = "Lblmobile"
        Me.Lblmobile.Size = New System.Drawing.Size(105, 25)
        Me.Lblmobile.TabIndex = 4
        Me.Lblmobile.Text = "Mobile No."
        '
        'MTBMobile
        '
        Me.MTBMobile.Location = New System.Drawing.Point(123, 166)
        Me.MTBMobile.Name = "MTBMobile"
        Me.MTBMobile.Size = New System.Drawing.Size(195, 22)
        Me.MTBMobile.TabIndex = 5
        '
        'LblHobbies
        '
        Me.LblHobbies.AutoSize = True
        Me.LblHobbies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHobbies.Location = New System.Drawing.Point(12, 231)
        Me.LblHobbies.Name = "LblHobbies"
        Me.LblHobbies.Size = New System.Drawing.Size(84, 25)
        Me.LblHobbies.TabIndex = 6
        Me.LblHobbies.Text = "Hobbies"
        '
        'LB1
        '
        Me.LB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB1.FormattingEnabled = True
        Me.LB1.ItemHeight = 22
        Me.LB1.Items.AddRange(New Object() {"Singing", "Dancing", "Listening", "Travelling", "Foodie", "Watching Series"})
        Me.LB1.Location = New System.Drawing.Point(12, 276)
        Me.LB1.Name = "LB1"
        Me.LB1.Size = New System.Drawing.Size(120, 92)
        Me.LB1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(192, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = ">>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(192, 352)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "<<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LB2
        '
        Me.LB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB2.FormattingEnabled = True
        Me.LB2.ItemHeight = 22
        Me.LB2.Location = New System.Drawing.Point(308, 276)
        Me.LB2.Name = "LB2"
        Me.LB2.Size = New System.Drawing.Size(120, 92)
        Me.LB2.TabIndex = 10
        '
        'Lbladdress
        '
        Me.Lbladdress.AutoSize = True
        Me.Lbladdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbladdress.Location = New System.Drawing.Point(12, 443)
        Me.Lbladdress.Name = "Lbladdress"
        Me.Lbladdress.Size = New System.Drawing.Size(85, 25)
        Me.Lbladdress.TabIndex = 11
        Me.Lbladdress.Text = "Address"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(133, 443)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(185, 67)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = ""
        '
        'LblDisplay
        '
        Me.LblDisplay.AutoSize = True
        Me.LblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDisplay.Location = New System.Drawing.Point(608, 51)
        Me.LblDisplay.Name = "LblDisplay"
        Me.LblDisplay.Size = New System.Drawing.Size(0, 25)
        Me.LblDisplay.TabIndex = 14
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(491, 223)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(195, 33)
        Me.ProgressBar1.TabIndex = 15
        '
        'LLSubmit
        '
        Me.LLSubmit.AutoSize = True
        Me.LLSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLSubmit.Location = New System.Drawing.Point(128, 544)
        Me.LLSubmit.Name = "LLSubmit"
        Me.LLSubmit.Size = New System.Drawing.Size(73, 25)
        Me.LLSubmit.TabIndex = 16
        Me.LLSubmit.TabStop = True
        Me.LLSubmit.Text = "Submit"
        '
        'LLClear
        '
        Me.LLClear.AutoSize = True
        Me.LLClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLClear.Location = New System.Drawing.Point(303, 544)
        Me.LLClear.Name = "LLClear"
        Me.LLClear.Size = New System.Drawing.Size(59, 25)
        Me.LLClear.TabIndex = 17
        Me.LLClear.TabStop = True
        Me.LLClear.Text = "Clear"
        '
        'LLCancel
        '
        Me.LLCancel.AutoSize = True
        Me.LLCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLCancel.Location = New System.Drawing.Point(486, 544)
        Me.LLCancel.Name = "LLCancel"
        Me.LLCancel.Size = New System.Drawing.Size(74, 25)
        Me.LLCancel.TabIndex = 18
        Me.LLCancel.TabStop = True
        Me.LLCancel.Text = "Cancel"
        '
        'Lblcity
        '
        Me.Lblcity.AutoSize = True
        Me.Lblcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcity.Location = New System.Drawing.Point(423, 439)
        Me.Lblcity.Name = "Lblcity"
        Me.Lblcity.Size = New System.Drawing.Size(46, 25)
        Me.Lblcity.TabIndex = 19
        Me.Lblcity.Text = "City"
        '
        'CBCity
        '
        Me.CBCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCity.FormattingEnabled = True
        Me.CBCity.Items.AddRange(New Object() {"Rajkot", "Ahmedabad", "Surat", "Jamnagar", "Junagadh", "Upleta", "Bhavnagar"})
        Me.CBCity.Location = New System.Drawing.Point(501, 438)
        Me.CBCity.Name = "CBCity"
        Me.CBCity.Size = New System.Drawing.Size(185, 30)
        Me.CBCity.TabIndex = 20
        Me.CBCity.Text = "Choose Your City"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 589)
        Me.Controls.Add(Me.CBCity)
        Me.Controls.Add(Me.Lblcity)
        Me.Controls.Add(Me.LLCancel)
        Me.Controls.Add(Me.LLClear)
        Me.Controls.Add(Me.LLSubmit)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LblDisplay)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Lbladdress)
        Me.Controls.Add(Me.LB2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LB1)
        Me.Controls.Add(Me.LblHobbies)
        Me.Controls.Add(Me.MTBMobile)
        Me.Controls.Add(Me.Lblmobile)
        Me.Controls.Add(Me.DTPDob)
        Me.Controls.Add(Me.lbldob)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Lblname)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lblname As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents lbldob As Label
    Friend WithEvents DTPDob As DateTimePicker
    Friend WithEvents Lblmobile As Label
    Friend WithEvents MTBMobile As MaskedTextBox
    Friend WithEvents LblHobbies As Label
    Friend WithEvents LB1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents LB2 As ListBox
    Friend WithEvents Lbladdress As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents LblDisplay As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents LLSubmit As LinkLabel
    Friend WithEvents LLClear As LinkLabel
    Friend WithEvents LLCancel As LinkLabel
    Friend WithEvents Lblcity As Label
    Friend WithEvents CBCity As ComboBox
End Class
