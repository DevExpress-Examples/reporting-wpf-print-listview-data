using System;
using System.Windows;
using DevExpress.Xpf.Printing;

namespace WPFPrintListView {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            listView1.DataContext = SimpleDataSet.CreateData().Tables[0];
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            SimpleLink link = new SimpleLink("ListViewDocument");
            DocumentPreviewWindow preview = new DocumentPreviewWindow();
            preview.PreviewControl.DocumentSource = link;

            link.PageHeaderTemplate = (DataTemplate)Resources["printHeaderTemplate"];
            link.DetailTemplate = (DataTemplate)Resources["printDataTemplate"];
            link.DetailCount = listView1.Items.Count;
            link.CreateDetail += new EventHandler<CreateAreaEventArgs>(link_CreateDetail);
            link.CreateDocument(true);
            preview.ShowDialog();
        }

        void link_CreateDetail(object sender, CreateAreaEventArgs e) {
            e.Data = listView1.Items[e.DetailIndex];
        }
    }
}
