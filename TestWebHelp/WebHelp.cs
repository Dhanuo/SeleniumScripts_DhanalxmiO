using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestScriptsJoinAssembly.TestWebHelp
{
    public static class WebHelp
    {
        public static IWebDriver WebDriver = null;

        public static void StartWebDriver(string browserName)
        {
            Console.WriteLine("Starting webdriver" + browserName + " from " + TestSetUp.SetUp.driverPath);

            switch (browserName)
            {
                case "Chrome":
                    {
                        ChromeOptions chromeoptions = new ChromeOptions();
                        chromeoptions.AddArgument("--ignore-certificate-errors");
                        WebDriver = new ChromeDriver(TestSetUp.SetUp.driverPath);
                        break;
                    }
                default:
                    Console.WriteLine(browserName + "driver does not implemented in the startbrowser");
                    break;

            }
            WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            WebDriver.Manage().Window.Maximize();
        }
        public static void StopWebDriver()
        {
            Console.WriteLine("Stopping webdriver");

            //WebDriver.Close();
            WebDriver.Quit();
        }
        public static void NavigateTo(string URL)
        {
            try
            {
                WebDriver.Navigate().GoToUrl(URL);
                Console.WriteLine("Navigated to " + URL + "page");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static bool isDisplayed(string ElementXpath)
        {
            try
            {
                IWebElement WebElement = WebDriver.FindElement(By.XPath(ElementXpath));
                return WebElement.Displayed || WebElement.Enabled;
            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
            catch (InvalidElementStateException ex)
            {
                return false;
            }
            catch (StaleElementReferenceException ex)
            {
                return false;
            }

        }
        public static bool WaitToAppear(string ElementXpath)
        {
            int startTime = 0;
            int waitTime = 200;
            int maxTime = 20000;
            while (startTime < maxTime)
            {
                if (isDisplayed(ElementXpath))
                    return true;
                Thread.Sleep(waitTime);
                startTime = startTime + waitTime;
            }
            Console.WriteLine("Element with locator " + ElementXpath + "did not Appear in " + maxTime / 1000 + "secs");
            return false;
        }

        public static void SafeSelectWebelement(string ElementXpath, string Action)
        {
            try
            {
                WaitToAppear(ElementXpath);
                IWebElement WebElement = WebDriver.FindElement(By.XPath(ElementXpath));
                if (Action == "click")
                    WebElement.Click();
                else
                {
                    if (Action == "safeClick")
                        WebElement.Click();
                    if (Action == "Enter")
                        WebElement.SendKeys(Keys.Enter);
                    if (Action == "return")
                        WebElement.SendKeys(Keys.Return);
                }
                Console.WriteLine("Selected the element with locator" + WebElement + " with " + Action);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void SelectWebelementsFromList(string ElementXpath, string textToPrint1, string textToPrint2)
        {
            try
            {
                IList<IWebElement> links = WebDriver.FindElements(By.XPath(ElementXpath));
                WaitToAppear(ElementXpath);
                Console.WriteLine("textToPrint" + links.Count());
                foreach (var link in links)
                  {
                        Console.WriteLine(textToPrint2 + link.Text);
                  }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static void SelectWebElement(string ElementName)
        {
            try
            {
                SafeSelectWebelement(ElementName, "click");
                Console.WriteLine("Selected the element with name " + ElementName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static void ITakesScreenshot()
        {
            var ScreensshotDriver = WebDriver as ITakesScreenshot;
            var ScreenShot = ScreensshotDriver.GetScreenshot();
            ScreenShot.SaveAsFile(TestSetUp.SetUp.resultsPath + TestSetUp.SetUp.resultName + DateTime.Now.ToString("yyyy-MM-ddHHmmss") + "." + ScreenshotImageFormat.Jpeg);
        }

    }
}

