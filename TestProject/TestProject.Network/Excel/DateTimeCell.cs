using System;
using DocumentFormat.OpenXml.Spreadsheet;

namespace TestProject.Network.Excel
{
    internal class DateTimeCell : Cell
    {
        public DateTimeCell(DateTime value)
        {
            if (value == DateTime.MinValue) return;

            this.DataType = CellValues.InlineString;
            this.InlineString = new InlineString
                                    {
                                        Text = new Text(value.ToString("MM/dd/yyyy hh:mm tt"))
                                    };
        }
    }
}
