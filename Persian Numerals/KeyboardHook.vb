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

'This is a modified and improved version of the KeyboardHook class. The original version was written by sim0n and is available at
'http://sim0n.wordpress.com/2009/03/28/vbnet-keyboard-hook-class/

Public Class KeyboardHook
    Private Const HC_ACTION As Integer = 0
    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const WM_KEYDOWN = &H100
    Private Const WM_KEYUP = &H101
    Private Const WM_SYSKEYDOWN = &H104
    Private Const WM_SYSKEYUP = &H105
    Private Const VK_LWinKey As Integer = 91
    Private Const VK_RWinKey As Integer = 92
    Private Structure KBDLLHOOKSTRUCT
        Public vkCode As Integer
        Public scancode As Integer
        Public flags As Integer
        Public time As Integer
        Public dwExtraInfo As Integer
    End Structure
    Private Declare Function SetWindowsHookEx Lib "user32" _
    Alias "SetWindowsHookExA" _
    (ByVal idHook As Integer, _
    ByVal lpfn As KeyboardProcDelegate, _
    ByVal hmod As Integer, _
    ByVal dwThreadId As Integer) As Integer

    Private Declare Function CallNextHookEx Lib "user32" _
    (ByVal hHook As Integer, _
    ByVal nCode As Integer, _
    ByVal wParam As Integer, _
    ByVal lParam As KBDLLHOOKSTRUCT) As Integer

    Private Declare Function UnhookWindowsHookEx Lib "user32" _
    (ByVal hHook As Integer) As Integer

    Private Delegate Function KeyboardProcDelegate _
    (ByVal nCode As Integer, _
    ByVal wParam As Integer, _
    ByRef lParam As KBDLLHOOKSTRUCT) As Integer


    Public Shared Event KeyDown(ByVal Key As Keys)
    Public Shared Event KeyUp(ByVal Key As Keys)
    Private Shared KeyHook As Integer
    Private Shared KeyHookDelegate As KeyboardProcDelegate
    <Runtime.InteropServices.DllImport("user32.dll")> _
    Public Shared Function GetAsyncKeyState(ByVal vKey As System.Windows.Forms.Keys) As Short
    End Function
    Public Sub New()
        KeyHookDelegate = New KeyboardProcDelegate(AddressOf KeyboardProc)
        KeyHook = SetWindowsHookEx(WH_KEYBOARD_LL, KeyHookDelegate, System.Runtime.InteropServices.Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0)).ToInt32, 0)
    End Sub
    Private Overloads Shared Function HexToUniCode(ByVal Value As String) As String
        Dim lng As Long
        Dim str As String
        Dim convertVal As String
        convertVal = ""
        For lng = 1 To Len(Value) Step 4
            str = ChrW("&H" & Mid(Value, lng, 4))
            convertVal = convertVal & str
        Next
        HexToUniCode = convertVal
    End Function
    Public Shared Function isPersianInstalled() As Boolean
        Dim PersianInstalled = False
        ' Gets the list of installed languages and returns true if Persian is installed.
        Dim lang As InputLanguage
        For Each lang In InputLanguage.InstalledInputLanguages
            If lang.Culture.TwoLetterISOLanguageName.ToString = "fa" Then PersianInstalled = True
        Next lang
        Return PersianInstalled
    End Function
#Region "Main vkCodes"
    Private Const VK_LSHIFT = &HA0
    Private Const VK_RSHIFT = &HA1
    Private Const VK_LCONTROL = &HA2
    Private Const VK_RCONTROL = &HA3
    Private Const VK_LMENU = &HA4
    Private Const VK_RMENU = &HA5
#End Region
    Private Shared Function KeyboardProc(ByVal nCode As Integer, ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) As Integer
        If (nCode = HC_ACTION) Then
            Select Case wParam
                Case WM_KEYDOWN, WM_SYSKEYDOWN
                    'Check if Ctrl or Shift or Alt is down or not
                    Select Case (lParam.vkCode)
                        Case VK_LCONTROL, VK_RCONTROL
                            frmMain.isControlDown = True
                        Case VK_LSHIFT, VK_RSHIFT
                            frmMain.isShiftDown = True
                        Case VK_LMENU, VK_RMENU
                            frmMain.isAltDown = True
                    End Select
                    RaiseEvent KeyDown(CType(lParam.vkCode, Keys))
                    If frmMain.chkMain.Checked = True Then
                        ' Add support of zero-width non-joiner by pressing Shift + Space
                        If CType(lParam.vkCode, Keys) = Keys.Space And frmMain.isShiftDown Then
                            SendKeys.Send(HexToUniCode("200c"))
                            Return 1
                        End If

                        'Persian Numerals
                        If (Control.ModifierKeys And Keys.Shift) <> Keys.Shift And (frmMain.isPersian Or (frmMain.PersianKeyboard And My.Settings.pkEnabled = True)) Then
                            Select Case lParam.vkCode
                                Case Keys.D0, Keys.NumPad0
                                    SendKeys.Send(HexToUniCode("06f0"))
                                    Return 1
                                Case Keys.D1, Keys.NumPad1
                                    SendKeys.Send(HexToUniCode("06f1"))
                                    Return 1
                                Case Keys.D2, Keys.NumPad2
                                    SendKeys.Send(HexToUniCode("06f2"))
                                    Return 1
                                Case Keys.D3, Keys.NumPad3
                                    SendKeys.Send(HexToUniCode("06f3"))
                                    Return 1
                                Case Keys.D4, Keys.NumPad4
                                    SendKeys.Send(HexToUniCode("06f4"))
                                    Return 1
                                Case Keys.D5, Keys.NumPad5
                                    SendKeys.Send(HexToUniCode("06f5"))
                                    Return 1
                                Case Keys.D6, Keys.NumPad6
                                    SendKeys.Send(HexToUniCode("06f6"))
                                    Return 1
                                Case Keys.D7, Keys.NumPad7
                                    SendKeys.Send(HexToUniCode("06f7"))
                                    Return 1
                                Case Keys.D8, Keys.NumPad8
                                    SendKeys.Send(HexToUniCode("06f8"))
                                    Return 1
                                Case Keys.D9, Keys.NumPad9
                                    SendKeys.Send(HexToUniCode("06f9"))
                                    Return 1
                            End Select

                            'Persian Keyboard (Not Shift down)
                            If (frmMain.PersianKeyboard And My.Settings.pkEnabled = True) And Not frmMain.isControlDown And Not frmMain.isAltDown Then
                                Select Case lParam.vkCode
                                    Case Keys.A
                                        SendKeys.Send(HexToUniCode("0634"))
                                        Return 1
                                    Case Keys.B
                                        SendKeys.Send(HexToUniCode("0630"))
                                        Return 1
                                    Case Keys.C
                                        SendKeys.Send(HexToUniCode("0632"))
                                        Return 1
                                    Case Keys.D
                                        SendKeys.Send(HexToUniCode("06CC"))
                                        Return 1
                                    Case Keys.E
                                        SendKeys.Send(HexToUniCode("062B"))
                                        Return 1
                                    Case Keys.F
                                        SendKeys.Send(HexToUniCode("0628"))
                                        Return 1
                                    Case Keys.G
                                        SendKeys.Send(HexToUniCode("0644"))
                                        Return 1
                                    Case Keys.H
                                        SendKeys.Send(HexToUniCode("0627"))
                                        Return 1
                                    Case Keys.I
                                        SendKeys.Send(HexToUniCode("0647"))
                                        Return 1
                                    Case Keys.J
                                        SendKeys.Send(HexToUniCode("062A"))
                                        Return 1
                                    Case Keys.K
                                        SendKeys.Send(HexToUniCode("0646"))
                                        Return 1
                                    Case Keys.L
                                        SendKeys.Send(HexToUniCode("0645"))
                                        Return 1
                                    Case Keys.M
                                        SendKeys.Send(HexToUniCode("0626"))
                                        Return 1
                                    Case Keys.N
                                        SendKeys.Send(HexToUniCode("062F"))
                                        Return 1
                                    Case Keys.O
                                        SendKeys.Send(HexToUniCode("062E"))
                                        Return 1
                                    Case Keys.P
                                        SendKeys.Send(HexToUniCode("062D"))
                                        Return 1
                                    Case Keys.Q
                                        SendKeys.Send(HexToUniCode("0636"))
                                        Return 1
                                    Case Keys.R
                                        SendKeys.Send(HexToUniCode("0642"))
                                        Return 1
                                    Case Keys.S
                                        SendKeys.Send(HexToUniCode("0633"))
                                        Return 1
                                    Case Keys.T
                                        SendKeys.Send(HexToUniCode("0641"))
                                        Return 1
                                    Case Keys.U
                                        SendKeys.Send(HexToUniCode("0639"))
                                        Return 1
                                    Case Keys.V
                                        SendKeys.Send(HexToUniCode("0631"))
                                        Return 1
                                    Case Keys.W
                                        SendKeys.Send(HexToUniCode("0635"))
                                        Return 1
                                    Case Keys.X
                                        SendKeys.Send(HexToUniCode("0637"))
                                        Return 1
                                    Case Keys.Y
                                        SendKeys.Send(HexToUniCode("063A"))
                                        Return 1
                                    Case Keys.Z
                                        SendKeys.Send(HexToUniCode("0638"))
                                        Return 1
                                    Case Keys.OemBackslash, 220
                                        SendKeys.Send(HexToUniCode("067E"))
                                        Return 1
                                    Case Keys.OemOpenBrackets
                                        SendKeys.Send(HexToUniCode("062C"))
                                        Return 1
                                    Case Keys.OemCloseBrackets
                                        SendKeys.Send(HexToUniCode("0686"))
                                        Return 1
                                    Case Keys.OemSemicolon
                                        SendKeys.Send(HexToUniCode("06A9"))
                                        Return 1
                                    Case Keys.OemQuotes
                                        SendKeys.Send(HexToUniCode("06AF"))
                                        Return 1
                                    Case Keys.Oemcomma
                                        SendKeys.Send(HexToUniCode("0648"))
                                        Return 1
                                End Select
                            End If
                        Else
                            'Persian Keyboard (Shift is down)
                            If (frmMain.PersianKeyboard And My.Settings.pkEnabled = True) And Not frmMain.isControlDown And Not frmMain.isAltDown Then
                                Select Case lParam.vkCode
                                    Case Keys.A
                                        SendKeys.Send(HexToUniCode("064E"))
                                        Return 1
                                    Case Keys.B
                                        SendKeys.Send(HexToUniCode("0625"))
                                        Return 1
                                    Case Keys.C
                                        SendKeys.Send(HexToUniCode("0698"))
                                        Return 1
                                    Case Keys.D
                                        SendKeys.Send(HexToUniCode("0650"))
                                        Return 1
                                    Case Keys.E
                                        SendKeys.Send(HexToUniCode("064D"))
                                        Return 1
                                    Case Keys.F
                                        SendKeys.Send(HexToUniCode("0651"))
                                        Return 1
                                    Case Keys.H
                                        SendKeys.Send(HexToUniCode("0622"))
                                        Return 1
                                    Case Keys.I
                                        SendKeys.Send("]")
                                        Return 1
                                    Case Keys.J
                                        SendKeys.Send(HexToUniCode("0640"))
                                        Return 1
                                    Case Keys.K
                                        SendKeys.Send(HexToUniCode("00AB"))
                                        Return 1
                                    Case Keys.L
                                        SendKeys.Send(HexToUniCode("00BB"))
                                        Return 1
                                    Case Keys.M
                                        SendKeys.Send(HexToUniCode("0621"))
                                        Return 1
                                    Case Keys.N
                                        SendKeys.Send(HexToUniCode("0623"))
                                        Return 1
                                    Case Keys.O
                                        SendKeys.Send("[")
                                        Return 1
                                    Case Keys.P
                                        SendKeys.Send("\")
                                        Return 1
                                    Case Keys.Q
                                        SendKeys.Send(HexToUniCode("064B"))
                                        Return 1
                                    Case Keys.R
                                        SendKeys.Send("ریال")
                                        Return 1
                                    Case Keys.S
                                        SendKeys.Send(HexToUniCode("064F"))
                                        Return 1
                                    Case Keys.T
                                        SendKeys.Send(HexToUniCode("060C"))
                                        Return 1
                                    Case Keys.V
                                        SendKeys.Send(HexToUniCode("0624"))
                                        Return 1
                                    Case Keys.W
                                        SendKeys.Send(HexToUniCode("064C"))
                                        Return 1
                                    Case Keys.X
                                        SendKeys.Send(HexToUniCode("064A"))
                                        Return 1
                                    Case Keys.Y
                                        SendKeys.Send(HexToUniCode("061B"))
                                        Return 1
                                    Case Keys.Z
                                        SendKeys.Send(HexToUniCode("0629"))
                                        Return 1
                                    Case Keys.OemQuestion
                                        SendKeys.Send(HexToUniCode("061F"))
                                        Return 1
                                End Select
                            End If
                            Return CallNextHookEx(KeyHook, nCode, wParam, lParam)
                        End If
                    End If
                Case WM_KEYUP, WM_SYSKEYUP
                    RaiseEvent KeyUp(CType(lParam.vkCode, Keys))
                    Select Case (lParam.vkCode)
                        Case VK_LCONTROL, VK_RCONTROL
                            frmMain.isControlDown = False
                        Case VK_LSHIFT, VK_RSHIFT
                            frmMain.isShiftDown = False
                        Case VK_LMENU, VK_RMENU
                            frmMain.isAltDown = False
                    End Select
            End Select
        End If
        Return 0
    End Function
    Protected Overrides Sub Finalize()
        UnhookWindowsHookEx(KeyHook)
        MyBase.Finalize()
    End Sub
    Sub Kill()
        Finalize()
    End Sub
End Class