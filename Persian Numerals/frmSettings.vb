﻿'Copyright (c) 2012, Mohammadamin Bandali
'All rights reserved.

'Redistribution and use in source and binary forms, with or without
'modification, are permitted provided that the following conditions are met: 

'1. Redistributions of source code must retain the above copyright notice, this
'   list of conditions and the following disclaimer. 
'2. Redistributions in binary form must reproduce the above copyright notice,
'   this list of conditions and the following disclaimer in the documentation
'   and/or other materials provided with the distribution. 

'THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
'ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
'WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
'DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
'ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
'(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
'LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
'ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
'(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
'SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

'The views and conclusions contained in the software and documentation are those
'of the authors and should not be interpreted as representing official policies, 
'either expressed or implied, of the FreeBSD Project.

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