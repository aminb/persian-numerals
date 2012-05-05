'Copyright (c) 2012, Mohammadamin Bandali
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

Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms.KeysConverter
Public Class frmMain

#Region "API Declarations"
    Declare Auto Function GetForegroundWindow Lib "user32" () As System.IntPtr
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Private Shared Function GetWindowText(ByVal hwnd As IntPtr, ByVal lpString As StringBuilder, ByVal cch As Integer) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Private Shared Function GetWindowTextLength(ByVal hwnd As IntPtr) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=True)> _
    Private Shared Function GetWindowThreadProcessId(ByVal hwnd As IntPtr, _
                          ByRef lpdwProcessId As Integer) As Integer
    End Function
    Private Declare Function GetKeyboardLayout Lib "user32" (ByVal dwLayout As Long) As Long
#End Region

    ' Create a new instance of KeyboardHook Class
    Private WithEvents kbHook As New KeyboardHook

    Sub ShowAbout()
        Dim frmAbout As New frmAbout
        frmAbout.Show()
        frmAbout.Focus()
    End Sub

    Sub ShowSettings()
        Dim frmSettings As New frmSettings
        frmSettings.Show()
        frmSettings.Focus()
    End Sub

    Sub ShowHelpEN()
        Dim frmHelpEN As New frmHelpEN
        frmHelpEN.Show()
        frmHelpEN.Focus()
    End Sub

    Sub ShowHelpFA()
        Dim frmHelpFA As New frmHelpFA
        frmHelpFA.Show()
        frmHelpFA.Focus()
    End Sub

    Sub ShowMe()
        Me.Show()
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        Me.Activate()
        Me.Focus()
        ntfyIcon.Visible = False
    End Sub

    Sub checkforUpdates()
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://afrait.com/persian-numerals/version.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()

        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion

        If newestversion.Contains(currentversion) Then
            MessageBox.Show("You have the latest version!", "Check for Updates - Persian Numerals", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim mbResult As MsgBoxResult = MessageBox.Show("A Newer version is available. Click ""Yes"" to open the website.", "Check for Updates - Persian Numerals", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If mbResult = MsgBoxResult.Yes Then
                System.Diagnostics.Process.Start("http://afrait.com/projects/persian-numerals/")
            End If
        End If
    End Sub

    Private Sub menuSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSettings.Click
        ShowSettings()
    End Sub

    Private Sub menuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAbout.Click
        ShowAbout()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub frmMain_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If My.Settings.cmbKeyCombination.ToString = "" Or My.Settings.cmbLetterVal = "" Then ShowSettings()
    End Sub

    Public isPersian As Boolean = False
    Public isControlDown As Boolean
    Public isShiftDown As Boolean
    Public isAltDown As Boolean

    ' Event to process the hotkey
    Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
        Dim keyconverter As New KeysConverter
        Dim thekey As Keys = keyconverter.ConvertFromString(My.Settings.cmbLetterVal.ToString)
        Select Case My.Settings.cmbKeyCombination
            Case 0
                If isControlDown And Not (isShiftDown Or isAltDown) And Key = thekey Then chkMain.Checked = Not chkMain.Checked
            Case 1
                If isShiftDown And Not (isControlDown Or isAltDown) And Key = thekey Then chkMain.Checked = Not chkMain.Checked
            Case 2
                If isAltDown And Not (isControlDown Or isShiftDown) And Key = thekey Then chkMain.Checked = Not chkMain.Checked
            Case 3
                If isControlDown And isShiftDown And Not isAltDown And Key = thekey Then chkMain.Checked = Not chkMain.Checked
            Case 4
                If isControlDown And isAltDown And Not isShiftDown And Key = thekey Then chkMain.Checked = Not chkMain.Checked
            Case 5
                If isControlDown And isShiftDown And isAltDown And Key = thekey Then chkMain.Checked = Not chkMain.Checked
        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Holds the handle of the focused window
        Dim hWnd As IntPtr = GetForegroundWindow()
        Dim lngPid As Integer
        'Holds thread process ID
        Dim tpid As Integer = GetWindowThreadProcessId(hWnd, lngPid)
        'Holds the keyboard layout code
        Dim klval As Long = GetKeyboardLayout(tpid)
        'Logical AND to get the correct value
        Dim klvalint As Integer = klval And &HFFFF
        'If the value is 1065 it means the language of the focused windows is Persian
        If klvalint = 1065 Then isPersian = True Else isPersian = False

        'Update the status label
        If chkMain.Checked = True Then ToolStripStatusLabelStatus.Text = "Enabled" Else ToolStripStatusLabelStatus.Text = "Disabled"
    End Sub

    Dim shallConfirmExit As Boolean = True

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If shallConfirmExit Then
            Dim msgboxResult As DialogResult = MessageBox.Show("Do you want to exit? (Click ""Yes"" to exit or ""No"" to minimize to system tray)", My.Application.Info.AssemblyName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If msgboxResult = Windows.Forms.DialogResult.Yes Then
                Timer1.Enabled = False
                'Calls kbHook.Kill to unhook the keyboard before closing
                kbHook.Kill()
            Else
                e.Cancel = True
                Me.Hide()
                Me.WindowState = FormWindowState.Minimized
                ntfyIcon.Visible = True
            End If
        Else
            Timer1.Enabled = False
            'Calls kbHook.Kill to unhook the keyboard before closing
            kbHook.Kill()
        End If
    End Sub

    Private Sub ntfyIcon_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ntfyIcon.MouseClick
        'Restore the form when the user clicks on the icon in the system tray
        If e.Button = Windows.Forms.MouseButtons.Left Then ShowMe()
    End Sub

    Private Sub frmMain_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            Me.WindowState = FormWindowState.Minimized
            ntfyIcon.Visible = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        shallConfirmExit = False
        Me.Close()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        ShowSettings()
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreToolStripMenuItem.Click
        ShowMe()
    End Sub

    Private Sub menuHelpFA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuHelpFA.Click
        ShowHelpFA()
    End Sub

    Private Sub menuHelpEN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuHelpEN.Click
        ShowHelpEN()
    End Sub

    Private Sub HelpFAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpFAToolStripMenuItem.Click
        ShowHelpFA()
    End Sub

    Private Sub HelpENToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpENToolStripMenuItem.Click
        ShowHelpEN()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ShowAbout()
    End Sub

    Private Sub menuUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuUpdate.Click
        checkforUpdates()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        checkforUpdates()
    End Sub
End Class
