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
Imports System.Collections
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Printing.UI
Imports System.Data

Namespace WPFPrintListView
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			listView1.DataContext = SimpleDataSet.CreateData().Tables(0)
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim link As New SimpleLink("ListViewDocument")
			Dim preview As New PrintPreviewWindow()

			link.PageHeader = CType(Resources("printHeaderTemplate"), ControlTemplate)
			link.Detail = CType(Resources("printDataTemplate"), DataTemplate)
			link.DetailCount = listView1.Items.Count

			preview.PrintingSystem = link.PrintingSystem
			AddHandler link.CreateDetail, AddressOf link_CreateDetail
			link.CreateDocument(True)
			preview.ShowDialog()
		End Sub

		Private Sub link_CreateDetail(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
			e.Data = listView1.Items(e.DetailIndex)
		End Sub
	End Class
End Namespace
