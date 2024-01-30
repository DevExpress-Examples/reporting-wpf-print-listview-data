Imports System
Imports System.Windows
Imports DevExpress.Xpf.Printing

Namespace WPFPrintListView

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.listView1.DataContext = SimpleDataSet.CreateData().Tables(0)
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim link As SimpleLink = New SimpleLink("ListViewDocument")
            Dim preview As DocumentPreviewWindow = New DocumentPreviewWindow()
            link.PageHeaderTemplate = CType(Resources("printHeaderTemplate"), DataTemplate)
            link.DetailTemplate = CType(Resources("printDataTemplate"), DataTemplate)
            link.DetailCount = Me.listView1.Items.Count
            preview.Model = New LinkPreviewModel(link)
            AddHandler link.CreateDetail, New EventHandler(Of CreateAreaEventArgs)(AddressOf link_CreateDetail)
            link.CreateDocument(True)
            preview.ShowDialog()
        End Sub

        Private Sub link_CreateDetail(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
            e.Data = Me.listView1.Items(e.DetailIndex)
        End Sub
    End Class
End Namespace
