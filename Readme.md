<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128596033/23.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1882)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Reporting for WPF - Print a ListView data

This example shows how to print data from the [ListView](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.listview) control. The DXPrinting Library is designed to print data that is organized according to the presentation defined in the data templates. The print templates are built-in only for the DXGrid. To print data of any standard control, create a template and use it to print data. For this, use the [SimpleLink](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.SimpleLink) class.

The data templates in this example are defined for the page header and detail areas of the document (the `SimpleLink.PageHeader` and` SimpleLink.Detail` properties). The [TextEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.TextEdit) controls are used for this purpose, because they have built-in export settings, unlike the regular `TextBlock` elements.

## Files to Review

* [SimpleDataSet.cs](./CS/SimpleDataSet.cs) (VB: [SimpleDataSet.vb](./VB/SimpleDataSet.vb))
* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml](./VB/Window1.xaml))
* [Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))

## Documentation

- [Printing Custom Reports](https://docs.devexpress.com/WPF/7412/common-concepts/printing-and-exporting/printing-custom-reports)

## More Examples 

- [Reporting for WPF - How to use the CollectionView Link to Print Data](https://github.com/DevExpress-Examples/reporting-wpf-use-collectionview-link)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-print-listview-data&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-print-listview-data&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
