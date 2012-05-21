<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkAutoStartup = New System.Windows.Forms.CheckBox()
        Me.chkPersianKeyboard = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnCtrlShiftAlt = New System.Windows.Forms.RadioButton()
        Me.rbtnCtrlAlt = New System.Windows.Forms.RadioButton()
        Me.rbtnCtrlShift = New System.Windows.Forms.RadioButton()
        Me.rbtnAlt = New System.Windows.Forms.RadioButton()
        Me.rbtnShift = New System.Windows.Forms.RadioButton()
        Me.rbtnCtrl = New System.Windows.Forms.RadioButton()
        Me.lblPlus = New System.Windows.Forms.Label()
        Me.cmbLetter = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(260, 194)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'chkAutoStartup
        '
        Me.chkAutoStartup.AutoSize = True
        Me.chkAutoStartup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkAutoStartup.Location = New System.Drawing.Point(14, 177)
        Me.chkAutoStartup.Name = "chkAutoStartup"
        Me.chkAutoStartup.Size = New System.Drawing.Size(218, 17)
        Me.chkAutoStartup.TabIndex = 1
        Me.chkAutoStartup.Text = "Start Persian Numerals on system startup"
        Me.chkAutoStartup.UseVisualStyleBackColor = True
        '
        'chkPersianKeyboard
        '
        Me.chkPersianKeyboard.AutoSize = True
        Me.chkPersianKeyboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkPersianKeyboard.Enabled = False
        Me.chkPersianKeyboard.Location = New System.Drawing.Point(14, 200)
        Me.chkPersianKeyboard.Name = "chkPersianKeyboard"
        Me.chkPersianKeyboard.Size = New System.Drawing.Size(152, 17)
        Me.chkPersianKeyboard.TabIndex = 2
        Me.chkPersianKeyboard.Text = "Simulate Persian Keyboard"
        Me.chkPersianKeyboard.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnCtrlShiftAlt)
        Me.GroupBox1.Controls.Add(Me.rbtnCtrlAlt)
        Me.GroupBox1.Controls.Add(Me.rbtnCtrlShift)
        Me.GroupBox1.Controls.Add(Me.rbtnAlt)
        Me.GroupBox1.Controls.Add(Me.rbtnShift)
        Me.GroupBox1.Controls.Add(Me.rbtnCtrl)
        Me.GroupBox1.Controls.Add(Me.lblPlus)
        Me.GroupBox1.Controls.Add(Me.cmbLetter)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Hotkey"
        '
        'rbtnCtrlShiftAlt
        '
        Me.rbtnCtrlShiftAlt.AutoSize = True
        Me.rbtnCtrlShiftAlt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnCtrlShiftAlt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCtrlShiftAlt.Location = New System.Drawing.Point(5, 134)
        Me.rbtnCtrlShiftAlt.Name = "rbtnCtrlShiftAlt"
        Me.rbtnCtrlShiftAlt.Size = New System.Drawing.Size(105, 17)
        Me.rbtnCtrlShiftAlt.TabIndex = 5
        Me.rbtnCtrlShiftAlt.TabStop = True
        Me.rbtnCtrlShiftAlt.Tag = "5"
        Me.rbtnCtrlShiftAlt.Text = "Ctrl + Shift + Alt"
        Me.rbtnCtrlShiftAlt.UseVisualStyleBackColor = True
        '
        'rbtnCtrlAlt
        '
        Me.rbtnCtrlAlt.AutoSize = True
        Me.rbtnCtrlAlt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnCtrlAlt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCtrlAlt.Location = New System.Drawing.Point(5, 88)
        Me.rbtnCtrlAlt.Name = "rbtnCtrlAlt"
        Me.rbtnCtrlAlt.Size = New System.Drawing.Size(69, 17)
        Me.rbtnCtrlAlt.TabIndex = 3
        Me.rbtnCtrlAlt.TabStop = True
        Me.rbtnCtrlAlt.Tag = "3"
        Me.rbtnCtrlAlt.Text = "Ctrl + Alt"
        Me.rbtnCtrlAlt.UseVisualStyleBackColor = True
        '
        'rbtnCtrlShift
        '
        Me.rbtnCtrlShift.AutoSize = True
        Me.rbtnCtrlShift.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnCtrlShift.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCtrlShift.Location = New System.Drawing.Point(5, 111)
        Me.rbtnCtrlShift.Name = "rbtnCtrlShift"
        Me.rbtnCtrlShift.Size = New System.Drawing.Size(78, 17)
        Me.rbtnCtrlShift.TabIndex = 4
        Me.rbtnCtrlShift.TabStop = True
        Me.rbtnCtrlShift.Tag = "4"
        Me.rbtnCtrlShift.Text = "Ctrl + Shift"
        Me.rbtnCtrlShift.UseVisualStyleBackColor = True
        '
        'rbtnAlt
        '
        Me.rbtnAlt.AutoSize = True
        Me.rbtnAlt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnAlt.Location = New System.Drawing.Point(5, 19)
        Me.rbtnAlt.Name = "rbtnAlt"
        Me.rbtnAlt.Size = New System.Drawing.Size(37, 17)
        Me.rbtnAlt.TabIndex = 0
        Me.rbtnAlt.TabStop = True
        Me.rbtnAlt.Tag = "0"
        Me.rbtnAlt.Text = "Alt"
        Me.rbtnAlt.UseVisualStyleBackColor = True
        '
        'rbtnShift
        '
        Me.rbtnShift.AutoSize = True
        Me.rbtnShift.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnShift.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnShift.Location = New System.Drawing.Point(5, 65)
        Me.rbtnShift.Name = "rbtnShift"
        Me.rbtnShift.Size = New System.Drawing.Size(47, 17)
        Me.rbtnShift.TabIndex = 2
        Me.rbtnShift.TabStop = True
        Me.rbtnShift.Tag = "2"
        Me.rbtnShift.Text = "Shift"
        Me.rbtnShift.UseVisualStyleBackColor = True
        '
        'rbtnCtrl
        '
        Me.rbtnCtrl.AutoSize = True
        Me.rbtnCtrl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnCtrl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCtrl.Location = New System.Drawing.Point(5, 42)
        Me.rbtnCtrl.Name = "rbtnCtrl"
        Me.rbtnCtrl.Size = New System.Drawing.Size(42, 17)
        Me.rbtnCtrl.TabIndex = 1
        Me.rbtnCtrl.TabStop = True
        Me.rbtnCtrl.Tag = "1"
        Me.rbtnCtrl.Text = "Ctrl"
        Me.rbtnCtrl.UseVisualStyleBackColor = True
        '
        'lblPlus
        '
        Me.lblPlus.AutoSize = True
        Me.lblPlus.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlus.Location = New System.Drawing.Point(135, 74)
        Me.lblPlus.Name = "lblPlus"
        Me.lblPlus.Size = New System.Drawing.Size(22, 19)
        Me.lblPlus.TabIndex = 33
        Me.lblPlus.Text = "+"
        Me.lblPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbLetter
        '
        Me.cmbLetter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbLetter.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Persian_Numerals.My.MySettings.Default, "cmbLetterVal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbLetter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLetter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLetter.FormattingEnabled = True
        Me.cmbLetter.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.cmbLetter.Location = New System.Drawing.Point(201, 72)
        Me.cmbLetter.Name = "cmbLetter"
        Me.cmbLetter.Size = New System.Drawing.Size(121, 21)
        Me.cmbLetter.TabIndex = 6
        Me.cmbLetter.Text = Global.Persian_Numerals.My.MySettings.Default.cmbLetterVal
        '
        'frmSettings
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 227)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkPersianKeyboard)
        Me.Controls.Add(Me.chkAutoStartup)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(351, 255)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(351, 255)
        Me.Name = "frmSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Persian Numerals - Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents chkAutoStartup As System.Windows.Forms.CheckBox
    Friend WithEvents chkPersianKeyboard As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnCtrlShiftAlt As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCtrlAlt As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCtrlShift As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnAlt As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnShift As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCtrl As System.Windows.Forms.RadioButton
    Friend WithEvents lblPlus As System.Windows.Forms.Label
    Friend WithEvents cmbLetter As System.Windows.Forms.ComboBox
End Class
