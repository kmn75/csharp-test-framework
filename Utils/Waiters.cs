using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using MyTestFramework.Core;

namespace MyTestFramework.Utils
{
    public static class Waiters
    {
        public static void WaitForElement(By locator, int seconds = 10)
        {
            var driver = WebDriverFactory.GetDriver();
            if (driver == null) return;
            
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(drv => drv.FindElement(locator).Displayed);
        }

        public static void WaitForPageLoad(int seconds = 10)
        {
            var driver = WebDriverFactory.GetDriver();
            if (driver == null) return;
            
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(drv =>
            {
                var scriptResult = ((IJavaScriptExecutor)drv).ExecuteScript("return document.readyState");
                return scriptResult?.ToString() == "complete";
            });
        }
    }
}