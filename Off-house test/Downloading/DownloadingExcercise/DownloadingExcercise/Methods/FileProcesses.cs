using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using System.IO;
using System.Net;

namespace DownloadingExercise.Methods
{
    //constracter

    public class FileProcesses // change the name 
    { // add region 

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
        public void DownloadFileExample1() // it should takes parameter.
        {
            WebClient Client = new WebClient();

            var myUrl = ConfigurationSettings.AppSettings["urlForDownloadingExercise1"]; //url disardan gelmeli ki, disardan url degistiginde method patlamasin
            Client.DownloadFile(myUrl, Constants.subPath + Constants.fileTypeData);
        }
        public void DownloadTheFile(ChromeDriver driver)
        {
            bool fileExists = false;

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until<bool>(x => fileExists = File.Exists(Constants.expectedFilePath)); //file system class altinda file.exist // create  butun bu logic orda olsun 
            CheckIfFolderExists();

            driver.Close();
        }
    }
}
