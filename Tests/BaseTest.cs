using NUnit.Framework;
using MyTestFramework.Core;
using MyTestFramework.Pages;

namespace MyTestFramework.Tests
{
    public abstract class BaseTest
    {
        protected BasePage? Page { get; set; }

        [SetUp]
        public void Setup()
        {
            WebDriverFactory.GetDriver();
        }

        [TearDown]
        public void Teardown()
        {
            // Делаем скриншот, если тест упал
            if (TestContext.CurrentContext.Result.Outcome.Status.ToString() == "Failed" && Page != null)
            {
                Page.TakeScreenshot(TestContext.CurrentContext.Test.Name);
            }

            WebDriverFactory.QuitDriver();
        }
    }
}