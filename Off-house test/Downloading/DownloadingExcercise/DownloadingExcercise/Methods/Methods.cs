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

        private readonly ChromeDriver driver;

        public Methods()
        {

            driver = new ChromeDriver();
        }
        public void BringAddUserProfilePreference()
        {

            ChromeOptions chromeOptions = new ChromeOptions();

            chromeOptions.AddUserProfilePreference(Constants.preferanceName, Constants.preferanceValue);
        }

        public void CreateIfMissing(string subPath)
        {
            bool exists = Directory.Exists(subPath);

            if (!exists)
                Directory.CreateDirectory(subPath);
        }


        public void WebDriverNavigation()
        {
            var urlForDownloadingExercise2 = ConfigurationSettings.AppSettings["urlForDownloadingExercise2"];



            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(urlForDownloadingExercise2);
            driver.FindElement(By.XPath(Constants.statGovPlXPath)).Click();
            driver.FindElement(By.XPath(Constants.statGovPlXPathDownload)).Click();

        }

        public void DownloadTheFile()
        {


            var expectedFilePath = Constants.expectedFilePath;
            bool fileExists = false;

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until<bool>(x => fileExists = File.Exists(expectedFilePath)); //file system class altinda file.exist // create  butun bu logic orda olsun 
            MoveTheFile(expectedFilePath);

            driver.Close();
        }

        public void MoveTheFile(string expectedFilePath)
        {
            File.Move(expectedFilePath, Constants.subPath + Constants.fileTypePopulationyyyyMM); // direct hedef klasore indir.
        }
    }
}
