using System;
using System.IO;
using System.Net;

namespace DownloadingExercise.Methods
{
    public class FileProcesses : NavigationProcesses
    {

        public void CreateIfMissing(string subPath)
        {
            bool exists = Directory.Exists(subPath);

            if (!exists)
                Directory.CreateDirectory(subPath);
        }
        public void MoveTheFile(string expectedFilePath, string actualFilePath)
        {
            File.Move(expectedFilePath, actualFilePath);
        }
        public void CheckIfFolderExists(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MoveTheFile(Constants.expectedFilePath, Constants.subPath + Constants.fileTypePopulationyyyyMM);
            }
            else
            {
                Console.WriteLine("\n\n\nYour file which you are trying to download is already exists in your {0}", Constants.subPath);
                Console.WriteLine("\n\n\n");
            }
        }
        public void DownloadFileExample1(string address, string fileName)
        {
            WebClient Client = new WebClient();

            Client.DownloadFile(address, fileName);
        }

    }
}
