using System.Configuration;

namespace DownloadingExercise
{
    public static class Constants
    {
        public  const string subPath = @"c:\temp\";

        public const string fileTypeData = "data.xls";

        public const string fileTypePopulationyyyyMM = "population_202111.xls";

        public const string statGovPlXPath = "/html/body/section[2]/div[1]/div/div[2]/div[1]/section/div/div/ul[2]/li[1]/figure/h2/a/span/strong";

        public const string statGovPlXPathDownload = "/html/body/section[2]/div[1]/div/article/section/div[2]/div[2]/div[1]/div[3]/div[2]/a";

        public const string expectedFilePath = @"C:\Users\CEM\Downloads\gus_biuletyn_2021_11_2.xlsx"; //on my computer this is the default download path, you need to align this with your computer's default download path.

        public const string preferanceName = "download.default_directory";

        public const string preferanceValue = @"C:\Users\CEM\Downloads"; //on my computer this is the default download path, you need to align this with your computer's default download path.

        public static string downloadLinkForExercise2 = ConfigurationSettings.AppSettings["urlForDownloadingExercise2"];

        public static string downloadLinkForExercise1 = ConfigurationSettings.AppSettings["urlForDownloadingExercise1"];
    }
}