<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128596033/11.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1882)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [SimpleDataSet.cs](./CS/SimpleDataSet.cs) (VB: [SimpleDataSet.vb](./VB/SimpleDataSet.vb))
* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml](./VB/Window1.xaml))
* [Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))
<!-- default file list end -->
# How to print a ListView data


<p>Basically, the DXPrinting Library is designed to print data that is organized according to the presentation defined via the data templates. At present, the print templates are built-in only for the DXGrid. Thus, to print data of any standard control, please create corresponding templates, and use them to print data via the SimpleLink class.</p><p>This example demonstrates how to print data from the ListView control. The data templates in this example are defined for the page header and detail areas of the document (the SimpleLink.PageHeader and SimpleLink.Detail properties). The DevExpress.Wpf.Editors.TextEdit controls are used for this purpose, because they have built-in export settings, unlike the regular TextBlock elements. </p><p>The basics of printing are demonstrated in the <a href="https://www.devexpress.com/Support/Center/p/E1673">E1673</a> example.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-print-listview-data&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-print-listview-data&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
