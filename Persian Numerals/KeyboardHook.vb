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
                    Select Case (lParam.vkCode)
                        Case VK_LCONTROL, VK_RCONTROL
                            frmMain.isControlDown = True
                        Case VK_LSHIFT, VK_RSHIFT
                            frmMain.isShiftDown = True
                        Case VK_LMENU, VK_RMENU
                            frmMain.isAltDown = True
                    End Select
                    RaiseEvent KeyDown(CType(lParam.vkCode, Keys))
                    If frmMain.chkMain.Checked = True And frmMain.isPersian Then
                        ' Add support of zero-width non-joiner by pressing Shift + Space
                        If CType(lParam.vkCode, Keys) = Keys.Space And frmMain.isShiftDown Then
                            SendKeys.Send("‌")
                            Return 1
                        End If

                        If (Control.ModifierKeys And Keys.Shift) <> Keys.Shift Then
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
                            End Select
                        Else
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