Imports Microsoft.VisualBasic
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
Imports DevExpress.Wpf.Bars

Namespace WpfApplication3
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()

'			#Region "#1"

			' Create a bar check item.
			Dim imItalic As New BitmapImage(New Uri("pack://application:,,/Images/italic16x16.png"))
			Dim imItalicLarge As New BitmapImage(New Uri("pack://application:,,/Images/italic32x32.png"))
			Dim checkBtnItalic As New BarCheckItem() With {.Content = "Italic", .Glyph = imItalic, .LargeGlyph = imItalicLarge}
			checkBtnItalic.GlyphSize = GlyphSize.Small
			AddHandler checkBtnItalic.CheckedChanged, AddressOf checkBtnItalic_CheckChanged
			barManager1.Items.Add(checkBtnItalic)
			' Add the item to a bar
			barManager1.Bars("Format").ItemLinks.Add(checkBtnItalic.CreateLink())
			' Create a category and add the bar item to the category.
			Dim category1 As New BarManagerCategory() With {.Name = "My category"}
			barManager1.Categories.Add(category1)
			checkBtnItalic.Category = category1

'			#End Region ' #1
		End Sub

		Private Sub checkBtnItalic_CheckChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			'...
		End Sub

		Private Sub checkBtnBold_CheckChanged(ByVal sender As Object, ByVal e As DevExpress.Wpf.Bars.ItemClickEventArgs)
			'...
		End Sub
	End Class
End Namespace
