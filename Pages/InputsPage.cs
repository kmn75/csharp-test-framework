using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using MyTestFramework.Utils;

namespace MyTestFramework.Pages
{
    public class InputsPage : BasePage
    {
        private By InputField => By.CssSelector("input[type='number']");

        public void OpenPage()
        {
            Open("/inputs");
            Waiters.WaitForElement(InputField);
        }

        public void EnterNumber(string value)
        {
            var input = Driver.FindElement(InputField);
            input.Clear();
            input.SendKeys(value);
        }

        public async Task EnterNumberWithDelay(string value, int delayMs = 500)
        {
            var input = Driver.FindElement(InputField);
            input.Clear();
            input.SendKeys(value);
            await Task.Delay(delayMs);
        }

        public string GetValue()
        {
            var input = Driver.FindElement(InputField);
            return input.GetAttribute("value") ?? string.Empty;
        }

        public void WaitForValue(string expectedValue, int seconds = 10)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
            wait.Until(drv =>
            {
                var input = drv.FindElement(InputField);
                return input.GetAttribute("value") == expectedValue;
            });
        }
    }
}