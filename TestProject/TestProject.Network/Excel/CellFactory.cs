using System;
using DocumentFormat.OpenXml.Spreadsheet;

namespace TestProject.Network.Excel
{
    internal class CellFactory : ICellFactory
    {
        #region Implementation of ICellFactory

        public Cell Create(object value)
        {
            if (value is int)
                return new IntegerCell((int)value);
            if (value is DateTime)
                return new DateTimeCell((DateTime)value);
            if (value is Double)
                return new DoubleCell((double)value);

            return new StringCell((string) value);
        }

        #endregion
    }
}