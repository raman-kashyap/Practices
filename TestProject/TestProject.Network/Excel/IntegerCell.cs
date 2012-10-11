using System.Globalization;
using DocumentFormat.OpenXml.Spreadsheet;

namespace TestProject.Network.Excel
{
    internal class IntegerCell : Cell
    {
        public IntegerCell(int value)
        {
            this.DataType = CellValues.Number;
            this.CellValue = new CellValue(value.ToString(CultureInfo.InvariantCulture));
        }
    }
}