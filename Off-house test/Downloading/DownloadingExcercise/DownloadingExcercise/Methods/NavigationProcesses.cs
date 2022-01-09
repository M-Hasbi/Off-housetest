using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;

namespace DownloadingExercise
{

    public class NavigationProcesses
    {
        readonly ChromeDriver driver = new ChromeDriver();
        public void BringAddUserProfilePreference(string preferanceName, string preferanceValue)
        {

            ChromeOptions chromeOptions = new ChromeOptions();

            chromeOptions.AddUserProfilePreference(preferanceName, preferanceValue);
        }
        public void WebDriverNavigation(string goToUrl)
        {
            driver.Navigate().GoToUrl(goToUrl);

        }
        public void FindElement(string xPath)
        {
            driver.FindElement(By.XPath(xPath)).Click();
        }
        public void DownloadTheFile(string expectedFilePath)
        {
            bool fileExists = false;

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until<bool>(x => fileExists = File.Exists(expectedFilePath));
        }
        public void CloseDriver()
        {
            driver.Close();
        }
    }
}