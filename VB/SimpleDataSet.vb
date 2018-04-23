Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Windows
Imports System.Windows.Data

Namespace WPFPrintListView
    Public Class SimpleDataSet
        Inherits DataSet

        Public Sub New()
            MyBase.New()
            Dim table As New DataTable("table")

            DataSetName = "ManualDataSet"

            table.Columns.Add("ID", GetType(Int32))
            table.Columns.Add("MyDateTime", GetType(Date))
            table.Columns.Add("MyRow", GetType(String))
            table.Columns.Add("MyData", GetType(Double))
            table.Constraints.Add("IDPK", table.Columns("ID"), True)

            Tables.AddRange(New DataTable() { table })
        End Sub

        Public Shared Function CreateData() As SimpleDataSet
            Dim ds As New SimpleDataSet()
            Dim table As DataTable = ds.Tables("table")

            Dim rnd As New Random(Date.Now.Millisecond)

            For i As Integer = 0 To 99
                table.Rows.Add(New Object() { i, Date.Today.AddDays(1), (If(i Mod 2 = 0, "A", "B")), Math.Round(rnd.NextDouble() * 100, 2) })
            Next i

            Return ds
        End Function

        #Region "Disable Serialization for Tables and Relations"
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
        Public Shadows ReadOnly Property Tables() As DataTableCollection
            Get
                Return MyBase.Tables
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
        Public Shadows ReadOnly Property Relations() As DataRelationCollection
            Get
                Return MyBase.Relations
            End Get
        End Property
        #End Region ' Disable Serialization for Tables and Relations
    End Class

    <ValueConversion(GetType(Date), GetType(String))> _
    Public Class DateConverter
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Dim [date] As Date = DirectCast(value, Date)
            Return [date].ToShortDateString()
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Dim strValue As String = TryCast(value, String)
            Dim resultDateTime As Date = Nothing
            If Date.TryParse(strValue, resultDateTime) Then
                Return resultDateTime
            End If
            Return DependencyProperty.UnsetValue
        End Function
    End Class

End Namespace