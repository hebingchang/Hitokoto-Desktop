Public Class WinMenu
    Private Sub about_Click(sender As Object, e As RoutedEventArgs) Handles about.Click
        Dim mw As MainWindow
        mw = Me.Owner
        Me.Hide()
        mw.loadabout()
    End Sub

    Private Sub change_Click(sender As Object, e As RoutedEventArgs) Handles change.Click
        Dim mw As MainWindow
        mw = Me.Owner
        mw.RefHitokoto()
        Me.Hide()
    End Sub

    Private Sub close_Click(sender As Object, e As RoutedEventArgs) Handles close.Click
        Me.Hide()
    End Sub

    Private Sub exit_Click(sender As Object, e As RoutedEventArgs) Handles [exit].Click
        Application.Current.Shutdown()
    End Sub

    Private Sub like_Click(sender As Object, e As RoutedEventArgs) Handles [like].Click
        Dim mw As MainWindow
        mw = Me.Owner
        Me.Hide()
        mw.loadlike()
    End Sub

    Private Sub WinMenu_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        menu.IsOpen = True
    End Sub
End Class
