using DocumentFormat.OpenXml.Spreadsheet;

namespace TestProject.Network.Excel
{
    internal class StringCell : Cell
    {
        public StringCell(string value)
        {
            this.DataType = CellValues.InlineString;
            this.InlineString = new InlineString
                                    {
                                        Text = new Text(value)
                                    };
        }
    }
}