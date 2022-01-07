using DownloadingExercise.Methods;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using System.IO;
namespace DownloadingExercise
{

    public class OtherMethods : MethodsForFile
    {
        public void BringAddUserProfilePreference()
        {

            ChromeOptions chromeOptions = new ChromeOptions();

            chromeOptions.AddUserProfilePreference(Constants.preferanceName, Constants.preferanceValue);
        }

        public void WebDriverNavigation()
        {
            ChromeDriver driver = new ChromeDriver();
            var urlForDownloadingExercise2 = ConfigurationSettings.AppSettings["urlForDownloadingExercise2"];

            driver.Navigate().GoToUrl(urlForDownloadingExercise2);
            driver.FindElement(By.XPath(Constants.statGovPlXPath)).Click();
            driver.FindElement(By.XPath(Constants.statGovPlXPathDownload)).Click();
            DownloadTheFile(driver);
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