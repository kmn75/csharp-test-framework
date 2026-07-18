using NUnit.Framework;
using MyTestFramework.Pages;

namespace MyTestFramework.Tests
{
    [TestFixture]
    public class InputsTests : BaseTest
    {
        private InputsPage _page;

        [SetUp]
        public void Init()
        {
            _page = new InputsPage();
            Page = _page;
        }

        [Test]
        public async Task EnterNumber_ShouldDisplayCorrectValue()
        {
            _page.OpenPage();
            await _page.EnterNumberWithDelay("42", 2000);
            
            var result = _page.GetValue();
            Assert.That(result, Is.EqualTo("42"), "Введенное значение не совпадает!");
        }
    }
}