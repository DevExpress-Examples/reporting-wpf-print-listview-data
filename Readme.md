# How to print a ListView data


<p>Basically, the DXPrinting Library is designed to print data that is organized according to the presentation defined via the data templates. At present, the print templates are built-in only for the DXGrid. Thus, to print data of any standard control, please create corresponding templates, and use them to print data via the SimpleLink class.</p><p>This example demonstrates how to print data from the ListView control. The data templates in this example are defined for the page header and detail areas of the document (the SimpleLink.PageHeader and SimpleLink.Detail properties). The DevExpress.Wpf.Editors.TextEdit controls are used for this purpose, because they have built-in export settings, unlike the regular TextBlock elements. </p><p>The basics of printing are demonstrated in the <a href="https://www.devexpress.com/Support/Center/p/E1673">E1673</a> example.</p>

<br/>


