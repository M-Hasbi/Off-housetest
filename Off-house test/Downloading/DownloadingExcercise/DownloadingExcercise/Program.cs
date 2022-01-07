using System;

namespace DownloadingExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is the downloading excercise program.");


            /* Downloading exercise
               
            GOALS:
            This is the downloading exercise. Your goal is to download a file from a specified webpage and store it under a specific name and location on your computer.
            There are 2 different examples. Please try to do both but if you will be able only to solve one of those examples that would also be fine.
            Try to keep the code clean, readable and maintainable to the best of your knowledge.
            */

            /* Example 1:
            1. We have a direct link to the file we want to download: http://www.bcra.gov.ar/Pdfs/PublicacionesEstadisticas/IPMPSerie.xls
            2. We want to save the downloaded file to the location: c:\temp\
            3. We want to save the downloaded file with the name: 'data.xls'
            4. Below you will find a method that is a starting point of your implementation (DownloadExample1)
            */

            Console.WriteLine("Example number 1 started.");
            DownloadExample1();
            Console.WriteLine("Example number 1 finished!");

            /* Example 2:
            1. Here we need to make a couple of steps to download the file that we want.
            2. We need to go to this webpage: https://stat.gov.pl/podstawowe-dane/
            3. Go into the 'Ludność w tys.' section on the webpage (the first tile in the upper left corner of the main page section. The number of people is actually a click-able thing here)
            4. Download the 'xls' file that should be available a the bottom in the 'Pliki do pobrania' section.
            5. Keep in mind that all the links after the one given in point 2 ('https://stat.gov.pl/podstawowe-dane/') are not stable in time so we cannot use them directly. We have to build them in the code.
            6. We want to save the downloaded file in location: c:\temp\
            7. We want to save the downloaded file with the name: 'population_yyyyMM.xls' (where 'yyyyMM' should be the current year and month in this format, i.e. 201910).
            8. Below you will find a method that is a starting point of your implementation (DownloadExample2)
            */

            Console.WriteLine("Example number 2 started.");
            DownloadExample2();
            Console.WriteLine("Example number 2 finished!");
        }
        public static void DownloadExample1()
        {
            Methods methods = new Methods();

            methods.CreateIfMissing();
            methods.DownloadFileExample1();
        }
        public static void DownloadExample2()
        {
            Methods methods = new Methods();

            methods.CreateIfMissing();
            methods.WebDriverNavigation();
            methods.BringAddUserProfilePreference();

        }
    }
}