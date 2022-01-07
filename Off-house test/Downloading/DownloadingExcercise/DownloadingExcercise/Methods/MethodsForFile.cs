using System;
using System.Configuration;
using System.IO;
using System.Net;

namespace DownloadingExercise.Methods
{
    public class MethodsForFile 
    {
        public void CreateIfMissing()
        {
            bool exists = Directory.Exists(Constants.subPath);

            if (!exists)
                Directory.CreateDirectory(Constants.subPath);
        }
        public void MoveTheFile()
        {
            File.Move(Constants.expectedFilePath, Constants.subPath + Constants.fileTypePopulationyyyyMM);
        }

        public void CheckIfFolderExists()
        {
            if (!File.Exists(Constants.subPath + Constants.fileTypePopulationyyyyMM))
            {
                MoveTheFile();
            }
            else
            {
                Console.Write("\n\nYour file which you are trying to download is already exists in your {0}", Constants.subPath);
                Console.WriteLine(" that`s why I can not move your file from the {0}", Constants.preferanceValue);
            }

        }
        public void DownloadFileExample1()
        {
            WebClient Client = new WebClient();

            var myUrl = ConfigurationSettings.AppSettings["urlForDownloadingExercise1"];
            Client.DownloadFile(myUrl, Constants.subPath + Constants.fileTypeData);
        }
    }
}
