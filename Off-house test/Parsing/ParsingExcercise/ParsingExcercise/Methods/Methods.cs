using Microsoft.Office.Interop.Excel;
using System;

namespace ParsingExercise.Methods
{
    public class Methods
    {
        public void GetCountsAndRows()
        {
            Application xlApp = new Application();
            Workbook xlWb = xlApp.Workbooks.Open(Constants.Consts.PathOfData1);
            _Worksheet xlws = xlWb.Sheets[1];
            Range r = xlws.UsedRange;

            int rows = r.Rows.Count;
            int cols = r.Columns.Count;

            CountOfEuroCurrency(xlws);
        }

        public void CountOfEuroCurrency(_Worksheet xlws)
        {

            ShowCells(xlws);
            Console.WriteLine("TOTAL = {0}", xlws.Cells[2, 3].Value2 + xlws.Cells[4, 3].Value2 + xlws.Cells[6, 3].Value2);


            Console.ReadLine();
        }

        public void  ShowCells(_Worksheet xlws)
        {
            Console.WriteLine("Currency type is: {0}", xlws.Cells[2, 2].Value2);

            Console.WriteLine("Cell C2: {0}", xlws.Cells[2, 3].Value2); //30,22
            Console.WriteLine("Cell C4: {0}", xlws.Cells[4, 3].Value2);//31,12
            Console.WriteLine("Cell C6: {0}", xlws.Cells[6, 3].Value2); //32,67
        }
    }
}
