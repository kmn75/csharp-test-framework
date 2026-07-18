using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using MyTestFramework.Utils;

namespace MyTestFramework.Core
{
    public static class WebDriverFactory
    {
        private static IWebDriver? _driver;

        public static IWebDriver GetDriver()
        {
            if (_driver == null)
            {
                var browser = ConfigReader.GetValue<string>("Browser");
                
                _driver = browser?.ToLower() switch
                {
                    "firefox" => new FirefoxDriver(),
                    _ => new ChromeDriver() // Chrome по умолчанию
                };
                
                _driver.Manage().Window.Maximize();
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            }
            return _driver;
        }

        public static void QuitDriver()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver = null;
            }
        }
    }
}