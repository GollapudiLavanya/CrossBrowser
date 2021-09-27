/*
 * project = CrossBrowserUsingFacebook
 * Author = Lavanya Gollapudi
 * Created Date = 19/09/2021
 */

using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CrossBrowser
{
    [TestFixture]
    [Parallelizable]
    public class Tests : Base.BaseClass
    {
        public static IEnumerable<String> BrowserToRun()
        {
            String[] browsers = { "chrome", "firefox" };
            foreach (string b in browsers)
            {
                yield return b;
            }
        }

        [Test]
        [TestCaseSource("BrowserToRun")]
        public void LoginIntoFacebook(string browsername)
        {
            CrossBrowserMethod(browsername);
            Action.ActionClass.LoginPage();
        }
    }
}