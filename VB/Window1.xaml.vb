Imports System
Imports System.Windows
Imports DevExpress.Xpf.Printing

Namespace WPFPrintListView
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
			Dim preview As New DocumentPreviewWindow()
			preview.PreviewControl.DocumentSource = link

			link.PageHeaderTemplate = DirectCast(Resources("printHeaderTemplate"), DataTemplate)
			link.DetailTemplate = DirectCast(Resources("printDataTemplate"), DataTemplate)
			link.DetailCount = listView1.Items.Count
			AddHandler link.CreateDetail, AddressOf link_CreateDetail
			link.CreateDocument(True)
			preview.ShowDialog()
		End Sub

		Private Sub link_CreateDetail(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
			e.Data = listView1.Items(e.DetailIndex)
		End Sub
	End Class
End Namespace
