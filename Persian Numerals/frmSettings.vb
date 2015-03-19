'This file is part of Persian Numerals.

' Foobar is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.

' Foobar is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.

' You should have received a copy of the GNU General Public License
' along with Foobar.  If not, see <http://www.gnu.org/licenses/>.

Public Class frmSettings

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        For Each ctrl As Control In GroupBox1.Controls
            If TypeOf ctrl Is RadioButton Then
                Dim selRadioButton As RadioButton = DirectCast(ctrl, RadioButton)
                If selRadioButton.Checked Then
                    My.Settings.cmbKeyCombination = Convert.ToInt32(selRadioButton.Tag)
                    Exit For
                End If
            End If
        Next
        My.Settings.cmbLetterVal = cmbLetter.SelectedItem.ToString

        If chkAutoStartup.Checked = True Then
            My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
        Else
            If My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).GetValue(Application.ProductName) <> Nothing Then My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
        End If

        If chkPersianKeyboard.Checked = True Then
            frmMain.PersianKeyboard = True
            My.Settings.pkEnabled = True
        Else
            frmMain.PersianKeyboard = False
            My.Settings.pkEnabled = False
        End If
        MsgBox("Settings Saved")
        Me.Close()
    End Sub

    Private Sub frmSettings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If frmMain.WindowState = FormWindowState.Minimized Then frmMain.WindowState = FormWindowState.Normal
        frmMain.Focus()
    End Sub

    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case (My.Settings.cmbKeyCombination)
            Case 0
                rbtnAlt.Checked = True
            Case 1
                rbtnCtrl.Checked = True
            Case 2
                rbtnShift.Checked = True
            Case 3
                rbtnCtrlAlt.Checked = True
            Case 4
                rbtnCtrlShift.Checked = True
            Case 5
                rbtnCtrlShiftAlt.Checked = True
        End Select
        cmbLetter.SelectedItem = My.Settings.cmbLetterVal.ToString

        If Not My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", Application.ProductName, Nothing) Is Nothing Then chkAutoStartup.Checked = True

        If Not KeyboardHook.isPersianInstalled Then chkPersianKeyboard.Enabled = True
        If (Not KeyboardHook.isPersianInstalled And frmMain.PersianKeyboard = True) Or My.Settings.pkEnabled = True Then chkPersianKeyboard.Checked = True
    End Sub
End Class