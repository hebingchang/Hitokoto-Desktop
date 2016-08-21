Imports System.Timers
Imports System.Windows.Interop
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Threading
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Class MainWindow
    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Public Declare Function SetParent Lib "user32" Alias "SetParent" (ByVal hWndChild As Integer, ByVal hWndNewParent As Integer) As Integer
    Public Declare Function GetDesktopWindow Lib "user32" Alias "GetDesktopWindow" () As Integer
    Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Private Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer
    Declare Auto Function ReleaseCapture Lib "user32.dll" Alias "ReleaseCapture" () As Boolean
    'API ReleaseCapture函数是用来释放鼠标捕获的  
    Declare Auto Function SendMessage Lib "user32.dll" Alias "SendMessage" (ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    '向windows发送消息  
    Public Const WM_SYSCOMMAND As Integer = &H112&
    Public Const SC_MOVE As Integer = &HF010&
    Public Const HTCAPTION As Integer = &H2&

    Const GWL_EXSTYLE = (-20)
    Const WS_EX_LAYERED = &H80000
    Const WS_EX_TRANSPARENT As Integer = &H20&

    Dim movetime As Date
    Dim timeoutTimer As New System.Timers.Timer

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        'Me.Background = Brushes.Transparent
        Me.ShowInTaskbar = False
        Dim handle As New WindowInteropHelper(Me)
        SetParent(handle.Handle, GetDesktopWindow())
        'SetWindowLong(handle.Handle, GWL_EXSTYLE, GetWindowLong(handle.Handle, GWL_EXSTYLE) Or WS_EX_LAYERED Or WS_EX_TRANSPARENT)
        RefHitokoto()
        timeoutTimer.Interval = 1000
        timeoutTimer.Enabled = True



        'Function that gets called after each interval
        AddHandler timeoutTimer.Elapsed, AddressOf OnTimedEvent
        movetime = Now
    End Sub


    Private Sub OnTimedEvent(sender As Object, e As ElapsedEventArgs)
        Dim nowtime = Format(DateTime.Now, "yyyy/MM/dd hh:mm:ss")
        If DateDiff(DateInterval.Second, movetime, Now) > 5 Then
            Me.Dispatcher.Invoke(Sub()
                                     timeoutTimer.Enabled = False
                                     Dim daV As DoubleAnimation = New DoubleAnimation(1, 0.5, New Duration(TimeSpan.FromSeconds(0.5)))
                                     Me.BeginAnimation(UIElement.OpacityProperty, daV)
                                 End Sub)
        End If
    End Sub

    Public Sub RefHitokoto()
        On Error GoTo retry
retry:
        Dim MyClient As Net.WebClient = New Net.WebClient
        Dim MyReader As New System.IO.StreamReader(MyClient.OpenRead("https://api.imjad.cn/hitokoto/?encode=json&source=0&charset=gbk"), System.Text.Encoding.Default)
        Dim json As String = MyReader.ReadToEnd
        MyReader.Close()
        Dim p As Object = CType(JsonConvert.DeserializeObject(json), JObject)
        lblText.Content = (p("hitokoto").ToString)
        'Me.Width = lblText.ActualWidth

        Dim daV As DoubleAnimation = New DoubleAnimation(0, 1, New Duration(TimeSpan.FromSeconds(0.5)))
        Me.lblText.BeginAnimation(UIElement.OpacityProperty, daV)

        lblText.Measure(New Size(Double.PositiveInfinity, Double.PositiveInfinity))
        lblText.Tag = json

        Me.Width = lblText.DesiredSize.Width
        Me.Top = SystemParameters.PrimaryScreenHeight - Me.Height - SystemParameters.MenuBarHeight * 2
        Me.Left = SystemParameters.PrimaryScreenWidth - Me.Width


    End Sub

    Private Sub MainWindow_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.LeftButton = MouseButtonState.Pressed Then
            ReleaseCapture()
            Dim handle As New WindowInteropHelper(Me)
            SendMessage(handle.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)
        End If
        Dim daV As DoubleAnimation = New DoubleAnimation(0.5, 1, New Duration(TimeSpan.FromSeconds(0.5)))
        If DateDiff(DateInterval.Second, movetime, Now) > 5 Then
            Me.BeginAnimation(UIElement.OpacityProperty, daV)
        End If
        movetime = Now
        timeoutTimer.Enabled = True
    End Sub

    Private Sub lblText_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs) Handles lblText.MouseDoubleClick
        Dim daV As DoubleAnimation = New DoubleAnimation(1, 0, New Duration(TimeSpan.FromSeconds(0.5)))
        Me.lblText.BeginAnimation(UIElement.OpacityProperty, daV)
        RefHitokoto()
    End Sub

    Private Sub MainWindow_MouseRightButtonUp(sender As Object, e As MouseButtonEventArgs) Handles Me.MouseRightButtonUp
        Dim winmenu As New WinMenu
        winmenu.Owner = Me
        winmenu.ShowDialog()
    End Sub

    Public Sub loadlike()
        Dim winlike As New WinLike
        winlike.Owner = Me
        winlike.ShowDialog()
    End Sub

    Public Sub loadabout()
        Dim winabout As New WinAbout
        winabout.Owner = Me
        winabout.ShowDialog()
    End Sub
End Class
