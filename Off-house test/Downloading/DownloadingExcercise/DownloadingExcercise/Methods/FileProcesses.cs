using System;
using System.IO;
using System.Net;

namespace DownloadingExercise.Methods
{

    public static class FileProcesses
    {

        public static void CreateIfMissing(string subPath)
        {
            bool exists = Directory.Exists(subPath);

            if (!exists)
                Directory.CreateDirectory(subPath);
        }
        public static void MoveTheFile(string expectedFilePath, string actualFilePath)
        {
            File.Move(expectedFilePath, actualFilePath);
        }
        public static void CheckIfFolderExists(string filePath)
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
        public static void DownloadTheFile(string address, string fileName)
        {
            WebClient Client = new WebClient();

            Client.DownloadFile(address, fileName);
        }

    }
}
