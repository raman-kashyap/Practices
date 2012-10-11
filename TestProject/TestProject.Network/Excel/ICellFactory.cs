using DocumentFormat.OpenXml.Spreadsheet;

namespace TestProject.Network.Excel
{
    internal interface ICellFactory
    {
        Cell Create(object value);
    }
}