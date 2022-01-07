using System;

namespace ParsingExercise
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("This is the parsing excercise program.");

            /* Parsing exercise
               
            GOALS:
            This is the parsing exercise. Your goal here is to open, read, create a specific object in memory with data found in the source file and print something on the console.
            There are 2 different examples. Please try to do both but if you will be able only to solve one of those examples that would also be fine.
            Try to keep the code clean, readable and maintainable to the best of your knowledge.
            */

            /* Example 1:
            1. There is an CSV file attached to the project - data1.csv
            2. Please open it in any way you know and read the data out of it.
            3. That file contains 3 comma separated columns and 7 rows (1 with headers and 6 with actual data)
            4. The file contains data for 3 different dates and 2 different currencies (EUR and SEK). We have 3 observations for each currency.
            7. Please gather all those data, count the average value for each currency and print in on the console.
            8. Keep in mind that the 'data1.csv' can be updated in the future. Try to make your method in a way that would still work in case of new dates and / or currencies appearing.
            9. Provide your implementation in the 'ParsingExercise1' method which is prepared below.
            */

            Console.WriteLine("Example number 1 started.");
            ParsingExercise1();
            Console.WriteLine("Example number 1 finished!");

            /* Example 2:
            1. There is an excel file attached to the project - data2.xls
            2. Please open it in any way you know and read the data out of it.
            3. That file contains only 1 sheet and that sheet holds a table with 5 columns and many rows.
            4. Please create an object with 5 fields, each representing one of the columns from the 'data2.xls' file (Periodo, IPMP, Agropecurio, etc.)
            5. Create an instance of that object for each row with data in the table in file 'data2.xls' (we don't want to have a separate instance of this object for the 1st row which contain column headers).
            6. Add all those instances to a List object (or something similar).
            7. Write the Count of the objects stored in the list to the console.
            8. Provide your implementation in the 'ParsingExercise2' method which is prepared below.
            */

            Console.WriteLine("Example number 2 started.");
            ParsingExercise2();
            Console.WriteLine("Example number 2 finished!");


        }

        private static void ParsingExercise1()
        {
            // your example 1 implementation should go here
            Methods.Methods methods = new Methods.Methods();

            methods.GetCountsAndRows();
        }

        private static void ParsingExercise2()
        {
            // your example 2 implementation should go here
        }
    }
}
