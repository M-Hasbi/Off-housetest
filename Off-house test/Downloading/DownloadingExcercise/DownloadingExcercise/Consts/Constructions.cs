namespace DownloadingExercise
{
    public class Constructions
    {
        private const string _subPath = @"c:\temp\";
        public string subPath { get { return _subPath; } }

        private const string _fileTypeData = "data.xls";
        public string fileTypeData { get { return _fileTypeData; } }

        private const string _fileTypePopulationyyyyMM = "population_202111.xls";
        public string fileTypePopulationyyyyMM { get { return _fileTypePopulationyyyyMM; } }

        private const string _statGovPlXPath = "/html/body/section[2]/div[1]/div/div[2]/div[1]/section/div/div/ul[2]/li[1]/figure/h2/a/span/strong";
        public string statGovPlXPath { get { return _statGovPlXPath; } }


        private const string _statGovPlXPathDownload = "/html/body/section[2]/div[1]/div/article/section/div[2]/div[2]/div[1]/div[3]/div[2]/a";
    public string statGovPlXPathDownload { get { return _statGovPlXPathDownload; } }


       private const string _expectedFilePathForDonwloadMethod = @"C:\Users\CEM\Downloads\gus_biuletyn_2021_11_2.xlsx"; //on my computer this is the default download path, you need to align this with your computer's default download path.
     public string expectedFilePathForDonwloadMethod { get { return _expectedFilePathForDonwloadMethod; } }
    }
}
