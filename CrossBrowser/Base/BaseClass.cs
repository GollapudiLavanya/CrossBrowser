/*
 *project = CrossBrowserUsingFacebook
 * Author = Lavanya Gollapudi
 * Created Date = 19/09/2021
 */

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace CrossBrowser.Base
{
    public class BaseClass
    {
        public static IWebDriver driver;

        public void CrossBrowserMethod(string browsername)
        {
            if (browsername.Equals("firefox"))
                driver = new FirefoxDriver();
            else
                driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}