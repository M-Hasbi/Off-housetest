using Microsoft.Office.Interop.Excel;
using System;

namespace ParsingExercise.Methods
{
    public static class Methods
    {
        private static readonly Application xlApp = new Application();
        public static void GetCountsAndRows(string fileName, int quantityOfSheetPage)
        {
            Workbook xlWb = xlApp.Workbooks.Open(fileName);

            _Worksheet xlws = xlWb.Sheets[quantityOfSheetPage];

            CountOfCurrency(xlws, xlws.Cells[2, 3], xlws.Cells[4, 3], xlws.Cells[6, 3]); //if you want to change the cell for counting currency
                                                                                         //, just change here the cell's numbers
        }

        public static void CountOfCurrency(_Worksheet xlws, Range cell1, Range cell2, Range cell3)
        {

            ShowCells(xlws.Cells[2, 2], xlws.Cells[2, 3], xlws.Cells[4, 3], xlws.Cells[6, 3]); // if you want to change the cell in order to show
                                                                                               // in the console, just change the cell's numbers


            Console.WriteLine("TOTAL = {0}", cell1.Value2 + cell2.Value2 + cell3.Value2);

            Console.ReadLine();
        }

        public static void ShowCells( Range currencyTypeCell, Range cell1, Range cell2, Range cell3)
        {
            Console.WriteLine("Currency type is: {0}", currencyTypeCell.Value2);

            Console.WriteLine("Cell C2: {0}", cell1.Value2);
            Console.WriteLine("Cell C4: {0}", cell2.Value2);
            Console.WriteLine("Cell C6: {0}", cell3.Value2);
        }
    }
}
