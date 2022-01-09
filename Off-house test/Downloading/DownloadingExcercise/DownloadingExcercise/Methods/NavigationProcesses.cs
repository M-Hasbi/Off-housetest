using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;

namespace DownloadingExercise.Methods
{
    public static class NavigationProcesses
    {
       private static readonly ChromeDriver driver = new ChromeDriver();
        public static void BringAddUserProfilePreference(string preferanceName, string preferanceValue)
        {

            ChromeOptions chromeOptions = new ChromeOptions();

            chromeOptions.AddUserProfilePreference(preferanceName, preferanceValue);
        }
        public static void WebDriverNavigation(string goToUrl)
        {
            driver.Navigate().GoToUrl(goToUrl);

        }
        public static void FindElement(string xPath)
        {
            driver.FindElement(By.XPath(xPath)).Click();
        }
        public static void CheckIfFileExistsWebDriverWait(string expectedFilePath)
        {
            bool fileExists = false;

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until<bool>(x => fileExists = File.Exists(expectedFilePath));
        }
        public static void CloseDriver()
        {
            driver.Close();
        }
    }
}