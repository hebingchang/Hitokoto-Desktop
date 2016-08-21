Imports System.Windows.Media.Animation

Public Class WinAbout
    Private Sub WinAbout_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim daV As DoubleAnimation = New DoubleAnimation(0, 1, New Duration(TimeSpan.FromSeconds(0.5)))
        Me.lblhitokoto.BeginAnimation(UIElement.OpacityProperty, daV)
        daV = New DoubleAnimation(0, 1, New Duration(TimeSpan.FromSeconds(1)))
        Me.lblyi.BeginAnimation(UIElement.OpacityProperty, daV)
        daV = New DoubleAnimation(0, 1, New Duration(TimeSpan.FromSeconds(1.5)))
        Me.lbloie.BeginAnimation(UIElement.OpacityProperty, daV)
        daV = New DoubleAnimation(0, 1, New Duration(TimeSpan.FromSeconds(2)))
        Me.lbloie_Copy.BeginAnimation(UIElement.OpacityProperty, daV)
        daV = New DoubleAnimation(0, 1, New Duration(TimeSpan.FromSeconds(2.5)))
        Me.lbloie_Copy1.BeginAnimation(UIElement.OpacityProperty, daV)
    End Sub

    Private Sub WinAbout_MouseUp(sender As Object, e As MouseButtonEventArgs) Handles Me.MouseUp
        Me.Hide()
    End Sub
End Class
