using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace FirstTest
{
    [TestFixture]
    public class Tests
    { 
        [Test]
        public void FirtTestQA()
        {
            // Создать и открыть Google Chrome браузер
            IWebDriver driver = new ChromeDriver();
            // Развернуть окно на весь экран
            driver.Manage().Window.Maximize();
            // Перейти по ссылке
            driver.Navigate().GoToUrl("http://www.yesk.com.ua/webdriver-csharp/");
            // Открыть статью: Поиск элементов на странице
            IWebElement FindArticle = driver.FindElement(By.LinkText("Поиск элементов на странице"));
            FindArticle.Click();
            // Нажать на ссылку: CONTROLS PAGE
            IWebElement LinkControlsPage = driver.FindElement(By.LinkText("CONTROLS PAGE"));
            LinkControlsPage.Click();
            // Выбрать checkbox: QA Engineer
            IWebElement ChekboxQA = driver.FindElement(By.XPath("//*[@id='PositionsForm']/input[1]"));
            ChekboxQA.Click();
            // Выбрать checkbox: Business analyst
            IWebElement ChekboxBA = driver.FindElement(By.XPath("//*[@id='PositionsForm']/input[3]"));
            ChekboxBA.Click();
            // Выбрать radiobutton: Less than 1
            IWebElement RadioButtonLessThan1 = driver.FindElement(By.XPath("//*[@id='lessone']"));
            RadioButtonLessThan1.Click();
            // Выбрать radiobutton: More than 5
            IWebElement RadioButtonMoreThan5 = driver.FindElement(By.XPath("//*[@id='morefive']"));
            RadioButtonMoreThan5.Click();
            // Проверить состояние контролов:
            // QA Engineer checkbox выбран
            Assert.IsTrue(System.Convert.ToBoolean(ChekboxQA.Selected), "QA Engineer checkbox не выбран");
            // .NET Developer checkbox не выбран
            Assert.IsFalse(driver.FindElement(By.XPath("//*[@id='PositionsForm']/input[2]")).Selected, ".NET Developer checkbox выбран");
            // Business analyst checkbox выбран
            Assert.IsTrue(System.Convert.ToBoolean(ChekboxBA.Selected), "Business analyst checkbox не выбран");
            // Project Manager checkbox не выбран
            Assert.IsFalse(driver.FindElement(By.XPath("//*[@id='PositionsForm']/input[4]")).Selected, "Project Manager checkbox выбран");
            // Check Radio Buttons
            // Less than 1 radiobutton не выбран
            Assert.IsFalse(System.Convert.ToBoolean(RadioButtonLessThan1.Selected), "Less than 1 radiobutton выбран");
            // From 1 to 3 radiobutton не выбран
            Assert.IsFalse(driver.FindElement(By.XPath("//*[@id='onethree']")).Selected, "From 1 to 3 radiobutton выбран");
            // From 3 to 5 radiobutton не выбран
            Assert.IsFalse(driver.FindElement(By.XPath("//*[@id='threefive']")).Selected, "From 3 to 5 radiobutton выбран");
            // More than 5 radiobutton выбран
            Assert.IsTrue(System.Convert.ToBoolean(RadioButtonMoreThan5.Selected), "More than 5 radiobutton не выбран");
            driver.Quit();
       }
    }
}
