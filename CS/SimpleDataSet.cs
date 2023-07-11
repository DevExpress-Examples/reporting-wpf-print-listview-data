using System;
using System.ComponentModel;
using System.Data;
using System.Windows;
using System.Windows.Data;

namespace WPFPrintListView
{
    public class SimpleDataSet : DataSet
    {
        public SimpleDataSet()
            : base()
        {
            DataTable table = new DataTable("table");

            DataSetName = "ManualDataSet";

            table.Columns.Add("ID", typeof(Int32));
            table.Columns.Add("MyDateTime", typeof(DateTime));
            table.Columns.Add("MyRow", typeof(string));
            table.Columns.Add("MyData", typeof(double));
            table.Constraints.Add("IDPK", table.Columns["ID"], true);

            Tables.AddRange(new DataTable[] { table });
        }

        public static SimpleDataSet CreateData()
        {
            SimpleDataSet ds = new SimpleDataSet();
            DataTable table = ds.Tables["table"];

            Random rnd = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < 100; i++)
                table.Rows.Add(new object[] { i, DateTime.Today.AddDays(1), (i % 2 == 0 ? "A" : "B"), Math.Round(rnd.NextDouble() * 100, 2) });

            return ds;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new DataTableCollection Tables
        {
            get { return base.Tables; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new DataRelationCollection Relations
        {
            get { return base.Relations; }
        }
    }

    [ValueConversion(typeof(DateTime), typeof(String))]
    public class DateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            DateTime date = (DateTime)value;
            return date.ToShortDateString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string strValue = value as string;
            DateTime resultDateTime;
            if (DateTime.TryParse(strValue, out resultDateTime))
            {
                return resultDateTime;
            }
            return DependencyProperty.UnsetValue;
        }
    }

}
