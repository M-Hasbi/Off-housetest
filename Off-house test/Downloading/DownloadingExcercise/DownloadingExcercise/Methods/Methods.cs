using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using System.IO;
using System.Net;

namespace DownloadingExercise
{

    public class Methods
    {

        public void BringAddUserProfilePreference()
        {

            ChromeOptions chromeOptions = new ChromeOptions();

            chromeOptions.AddUserProfilePreference(Constants.preferanceName, Constants.preferanceValue);
        }
        public void CreateIfMissing()
        {
            bool exists = Directory.Exists(Constants.subPath);

            if (!exists)
                Directory.CreateDirectory(Constants.subPath);
        }
        public void WebDriverNavigation()
        {
            ChromeDriver driver = new ChromeDriver();
            var urlForDownloadingExercise2 = ConfigurationSettings.AppSettings["urlForDownloadingExercise2"];

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(urlForDownloadingExercise2);
            driver.FindElement(By.XPath(Constants.statGovPlXPath)).Click();
            driver.FindElement(By.XPath(Constants.statGovPlXPathDownload)).Click();
            DownloadTheFile(driver);
        }
        public void DownloadTheFile(ChromeDriver driver)
        {
            bool fileExists = false;

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until<bool>(x => fileExists = File.Exists(Constants.expectedFilePath)); //file system class altinda file.exist // create  butun bu logic orda olsun 
            CheckIfFolderExists();

            driver.Close();
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
            Client.DownloadFile(myUrl, Constants.subPath + Constants.fileTypeData);// WRITE TEST METHOD
        }
    }
}