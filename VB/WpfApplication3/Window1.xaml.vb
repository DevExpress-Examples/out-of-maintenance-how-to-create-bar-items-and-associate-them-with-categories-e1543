Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Bars

Namespace WpfApplication3

    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub checkBtnItalic_CheckChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        '...
        End Sub

        Private Sub checkBtnBold_CheckChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        '...
        End Sub
    End Class
End Namespace
