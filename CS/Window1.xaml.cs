using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using DevExpress.Xpf.Printing;
using DevExpress.Xpf.Printing.UI;
using System.Data;

namespace WPFPrintListView
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listView1.DataContext = SimpleDataSet.CreateData().Tables[0];
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            SimpleLink link = new SimpleLink("ListViewDocument");
            PrintPreviewWindow preview = new PrintPreviewWindow();

            link.PageHeader = (ControlTemplate)Resources["printHeaderTemplate"];
            link.Detail = (DataTemplate)Resources["printDataTemplate"];
            link.DetailCount = listView1.Items.Count;

            preview.PrintingSystem = link.PrintingSystem;
            link.CreateDetail += new EventHandler<CreateAreaEventArgs>(link_CreateDetail);
            link.CreateDocument(true);
            preview.ShowDialog();
        }

        void link_CreateDetail(object sender, CreateAreaEventArgs e)
        {
            e.Data = listView1.Items[e.DetailIndex];
        }
    }
}
