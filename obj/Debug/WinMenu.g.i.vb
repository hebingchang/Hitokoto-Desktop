﻿#ExternalChecksum("..\..\WinMenu.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","7729804A96DF235B7EF2F3BF48CA6F98")
'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.42000
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Hitokoto
Imports RadialMenu.Controls
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''WinMenu
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class WinMenu
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\WinMenu.xaml",23)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents menu As RadialMenu.Controls.RadialMenu
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\WinMenu.xaml",28)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents close As RadialMenu.Controls.RadialMenuCentralItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\WinMenu.xaml",35)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents change As RadialMenu.Controls.RadialMenuItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\WinMenu.xaml",46)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents [exit] As RadialMenu.Controls.RadialMenuItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\WinMenu.xaml",58)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents [like] As RadialMenu.Controls.RadialMenuItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\WinMenu.xaml",69)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents about As RadialMenu.Controls.RadialMenuItem
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/Hitokoto;component/winmenu.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\WinMenu.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.menu = CType(target,RadialMenu.Controls.RadialMenu)
            Return
        End If
        If (connectionId = 2) Then
            Me.close = CType(target,RadialMenu.Controls.RadialMenuCentralItem)
            Return
        End If
        If (connectionId = 3) Then
            Me.change = CType(target,RadialMenu.Controls.RadialMenuItem)
            Return
        End If
        If (connectionId = 4) Then
            Me.[exit] = CType(target,RadialMenu.Controls.RadialMenuItem)
            Return
        End If
        If (connectionId = 5) Then
            Me.[like] = CType(target,RadialMenu.Controls.RadialMenuItem)
            Return
        End If
        If (connectionId = 6) Then
            Me.about = CType(target,RadialMenu.Controls.RadialMenuItem)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class

