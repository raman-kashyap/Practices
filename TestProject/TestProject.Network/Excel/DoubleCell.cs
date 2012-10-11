using DocumentFormat.OpenXml.Spreadsheet;

namespace TestProject.Network.Excel
{
    internal class DoubleCell : Cell
    {
        // TODO: Need clean up. Decimal should not use DataType of String
        public DoubleCell(double value)
        {
            this.DataType = CellValues.String;
            this.CellValue = new CellValue(string.Format("{0} MB", value));
        }
    }
}