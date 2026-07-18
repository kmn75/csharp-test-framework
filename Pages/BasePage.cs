using OpenQA.Selenium;
using MyTestFramework.Core;
using MyTestFramework.Utils;

namespace MyTestFramework.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver Driver => WebDriverFactory.GetDriver();
        private static readonly string ScreenshotDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Screenshots");

        static BasePage()
        {
            if (!Directory.Exists(ScreenshotDir))
            {
                Directory.CreateDirectory(ScreenshotDir);
            }
        }

        public void Open(string relativeUrl)
        {
            var baseUrl = ConfigReader.GetValue<string>("BaseUrl");
            Driver.Navigate().GoToUrl($"{baseUrl}{relativeUrl}");
            Waiters.WaitForPageLoad();
        }

        public void TakeScreenshot(string name)
        {
            try
            {
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                var fileName = $"{name}_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.png";
                var filePath = Path.Combine(ScreenshotDir, fileName);
                screenshot.SaveAsFile(filePath);
                Console.WriteLine($"📸 Screenshot saved: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Screenshot failed: {ex.Message}");
            }
        }
    }
}