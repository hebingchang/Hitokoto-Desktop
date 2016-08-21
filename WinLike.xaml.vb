Imports System.Windows.Media.Animation
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class WinLike
    Private Sub txtText_MouseUp(sender As Object, e As MouseButtonEventArgs) Handles txtText.MouseUp
        Clipboard.SetText(txtText.Text)
        MsgBox("已复制到剪贴板 (′▽`〃)", MsgBoxStyle.Information, "成功")
    End Sub

    Private Sub WinLike_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim mw As MainWindow
        mw = Me.Owner
        Dim json = mw.lblText.Tag
        Dim p As Object = CType(JsonConvert.DeserializeObject(json), JObject)
        lblText.MaxWidth = Me.Width - 50

        txtText.Text = (p("hitokoto").ToString)
        Dim daV As DoubleAnimation = New DoubleAnimation(0, 1, New Duration(TimeSpan.FromSeconds(0.5)))
        Me.txtText.BeginAnimation(UIElement.OpacityProperty, daV)

        lblFrom.Content = (p("source").ToString)
        If p("source").ToString = "" Then lblFrom.Content = "无"
        daV = New DoubleAnimation(0, 1, New Duration(TimeSpan.FromSeconds(1)))
        Me.lblFrom.BeginAnimation(UIElement.OpacityProperty, daV)
        Me.lblFromC.BeginAnimation(UIElement.OpacityProperty, daV)

        lblCat.Content = (p("catname").ToString)
        daV = New DoubleAnimation(0, 1, New Duration(TimeSpan.FromSeconds(1.5)))
        Me.lblCat.BeginAnimation(UIElement.OpacityProperty, daV)
        Me.lblCatC.BeginAnimation(UIElement.OpacityProperty, daV)

        daV = New DoubleAnimation(0, 1, New Duration(TimeSpan.FromSeconds(2)))
        Me.lblHint.BeginAnimation(UIElement.OpacityProperty, daV)
    End Sub

    Private Sub WinLike_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs) Handles Me.MouseDoubleClick
        Me.Hide()
    End Sub
End Class
