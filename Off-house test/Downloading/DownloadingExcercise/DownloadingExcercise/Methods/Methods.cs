using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using System.IO;

namespace DownloadingExercise
{
    public class Methods
    {
        private readonly Constructions constructions;
        private readonly ChromeDriver driver;

        public Methods()
        {
            constructions = new Constructions();
            driver = new ChromeDriver();
        }
        public void BringAddUserProfilePreference()
        {
            var preferanceName = "download.default_directory";
            var preferanceValue = @"C:\Users\CEM\Downloads"; //on my computer this is the default download path, you need to align this with your computer's default download path.

            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference(preferanceName, preferanceValue);
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
            driver.FindElement(By.XPath(constructions.statGovPlXPath)).Click();
            driver.FindElement(By.XPath(constructions.statGovPlXPathDownload)).Click();

        }

        public void DownloadTheFile()
        {
            var expectedFilePath = constructions.expectedFilePathForDonwloadMethod;
            bool fileExists = false;

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until<bool>(x => fileExists = File.Exists(expectedFilePath));
            CreateIfMissing(constructions.subPath);
            MoveTheFile(expectedFilePath);

            driver.Quit();
        }

        public void MoveTheFile(string expectedFilePath)
        {
            File.Move(expectedFilePath, constructions.subPath + constructions.fileTypePopulationyyyyMM);
        }
    }
}
