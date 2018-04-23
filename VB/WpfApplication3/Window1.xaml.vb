Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Bars

Namespace WpfApplication3
    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Partial Public Class Window1
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub checkBtnItalic_CheckChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            '...
        End Sub

        Private Sub checkBtnBold_CheckChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            '...
        End Sub
    End Class
End Namespace
