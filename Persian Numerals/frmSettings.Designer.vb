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
        Me.rbtnCtrlShiftAlt = New System.Windows.Forms.RadioButton()
        Me.rbtnCtrlAlt = New System.Windows.Forms.RadioButton()
        Me.rbtnCtrlShift = New System.Windows.Forms.RadioButton()
        Me.rbtnAlt = New System.Windows.Forms.RadioButton()
        Me.rbtnShift = New System.Windows.Forms.RadioButton()
        Me.rbtnCtrl = New System.Windows.Forms.RadioButton()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblPlus = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.cmbLetter = New System.Windows.Forms.ComboBox()
        Me.chkAutoStartup = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'rbtnCtrlShiftAlt
        '
        Me.rbtnCtrlShiftAlt.AutoSize = True
        Me.rbtnCtrlShiftAlt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCtrlShiftAlt.Location = New System.Drawing.Point(13, 174)
        Me.rbtnCtrlShiftAlt.Name = "rbtnCtrlShiftAlt"
        Me.rbtnCtrlShiftAlt.Size = New System.Drawing.Size(105, 17)
        Me.rbtnCtrlShiftAlt.TabIndex = 16
        Me.rbtnCtrlShiftAlt.TabStop = True
        Me.rbtnCtrlShiftAlt.Tag = "5"
        Me.rbtnCtrlShiftAlt.Text = "Ctrl + Shift + Alt"
        Me.rbtnCtrlShiftAlt.UseVisualStyleBackColor = True
        '
        'rbtnCtrlAlt
        '
        Me.rbtnCtrlAlt.AutoSize = True
        Me.rbtnCtrlAlt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCtrlAlt.Location = New System.Drawing.Point(13, 151)
        Me.rbtnCtrlAlt.Name = "rbtnCtrlAlt"
        Me.rbtnCtrlAlt.Size = New System.Drawing.Size(69, 17)
        Me.rbtnCtrlAlt.TabIndex = 15
        Me.rbtnCtrlAlt.TabStop = True
        Me.rbtnCtrlAlt.Tag = "4"
        Me.rbtnCtrlAlt.Text = "Ctrl + Alt"
        Me.rbtnCtrlAlt.UseVisualStyleBackColor = True
        '
        'rbtnCtrlShift
        '
        Me.rbtnCtrlShift.AutoSize = True
        Me.rbtnCtrlShift.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCtrlShift.Location = New System.Drawing.Point(13, 128)
        Me.rbtnCtrlShift.Name = "rbtnCtrlShift"
        Me.rbtnCtrlShift.Size = New System.Drawing.Size(78, 17)
        Me.rbtnCtrlShift.TabIndex = 14
        Me.rbtnCtrlShift.TabStop = True
        Me.rbtnCtrlShift.Tag = "3"
        Me.rbtnCtrlShift.Text = "Ctrl + Shift"
        Me.rbtnCtrlShift.UseVisualStyleBackColor = True
        '
        'rbtnAlt
        '
        Me.rbtnAlt.AutoSize = True
        Me.rbtnAlt.Location = New System.Drawing.Point(13, 105)
        Me.rbtnAlt.Name = "rbtnAlt"
        Me.rbtnAlt.Size = New System.Drawing.Size(37, 17)
        Me.rbtnAlt.TabIndex = 13
        Me.rbtnAlt.TabStop = True
        Me.rbtnAlt.Tag = "2"
        Me.rbtnAlt.Text = "Alt"
        Me.rbtnAlt.UseVisualStyleBackColor = True
        '
        'rbtnShift
        '
        Me.rbtnShift.AutoSize = True
        Me.rbtnShift.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnShift.Location = New System.Drawing.Point(13, 82)
        Me.rbtnShift.Name = "rbtnShift"
        Me.rbtnShift.Size = New System.Drawing.Size(47, 17)
        Me.rbtnShift.TabIndex = 12
        Me.rbtnShift.TabStop = True
        Me.rbtnShift.Tag = "1"
        Me.rbtnShift.Text = "Shift"
        Me.rbtnShift.UseVisualStyleBackColor = True
        '
        'rbtnCtrl
        '
        Me.rbtnCtrl.AutoSize = True
        Me.rbtnCtrl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCtrl.Location = New System.Drawing.Point(13, 59)
        Me.rbtnCtrl.Name = "rbtnCtrl"
        Me.rbtnCtrl.Size = New System.Drawing.Size(42, 17)
        Me.rbtnCtrl.TabIndex = 11
        Me.rbtnCtrl.TabStop = True
        Me.rbtnCtrl.Tag = "0"
        Me.rbtnCtrl.Text = "Ctrl"
        Me.rbtnCtrl.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(15, 251)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblPlus
        '
        Me.lblPlus.AutoSize = True
        Me.lblPlus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlus.Location = New System.Drawing.Point(186, 109)
        Me.lblPlus.Name = "lblPlus"
        Me.lblPlus.Size = New System.Drawing.Size(15, 13)
        Me.lblPlus.TabIndex = 17
        Me.lblPlus.Text = "+"
        Me.lblPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(10, 27)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(84, 13)
        Me.lbl1.TabIndex = 10
        Me.lbl1.Text = "Choose Hotkey:"
        '
        'cmbLetter
        '
        Me.cmbLetter.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Persian_Numerals.My.MySettings.Default, "cmbLetterVal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbLetter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLetter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLetter.FormattingEnabled = True
        Me.cmbLetter.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.cmbLetter.Location = New System.Drawing.Point(239, 59)
        Me.cmbLetter.Name = "cmbLetter"
        Me.cmbLetter.Size = New System.Drawing.Size(121, 21)
        Me.cmbLetter.TabIndex = 18
        Me.cmbLetter.Text = Global.Persian_Numerals.My.MySettings.Default.cmbLetterVal
        '
        'chkAutoStartup
        '
        Me.chkAutoStartup.AutoSize = True
        Me.chkAutoStartup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkAutoStartup.Enabled = False
        Me.chkAutoStartup.Location = New System.Drawing.Point(13, 212)
        Me.chkAutoStartup.Name = "chkAutoStartup"
        Me.chkAutoStartup.Size = New System.Drawing.Size(374, 17)
        Me.chkAutoStartup.TabIndex = 20
        Me.chkAutoStartup.Text = "Start Persian Numerals on system startup (Run as administrator to change)"
        Me.chkAutoStartup.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 286)
        Me.Controls.Add(Me.chkAutoStartup)
        Me.Controls.Add(Me.rbtnCtrlShiftAlt)
        Me.Controls.Add(Me.rbtnCtrlAlt)
        Me.Controls.Add(Me.rbtnCtrlShift)
        Me.Controls.Add(Me.rbtnAlt)
        Me.Controls.Add(Me.rbtnShift)
        Me.Controls.Add(Me.rbtnCtrl)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblPlus)
        Me.Controls.Add(Me.cmbLetter)
        Me.Controls.Add(Me.lbl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Persian Numerals - Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbtnCtrlShiftAlt As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCtrlAlt As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCtrlShift As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnAlt As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnShift As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCtrl As System.Windows.Forms.RadioButton
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblPlus As System.Windows.Forms.Label
    Friend WithEvents cmbLetter As System.Windows.Forms.ComboBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents chkAutoStartup As System.Windows.Forms.CheckBox
End Class
