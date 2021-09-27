/*
 *project = CrossBrowserUsingFacebook
 * Author = Lavanya Gollapudi
 * Created Date = 19/09/2021
 */
using OpenQA.Selenium;

namespace CrossBrowser.Action
{
    public class ActionClass : Base.BaseClass
    {
        public static void LoginPage()
        {
            driver.Url = "https://www.facebook.com/";
            driver.FindElement(By.Name("email")).SendKeys("ucs17139@rmd.ac.in");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Id("pass")).SendKeys("123456789ABCD");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("login")).Click();
            System.Threading.Thread.Sleep(10000);
        }
    }
}