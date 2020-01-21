using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace jenkinsApp
{
    [TestFixture]
    class UnitTest1
    {

        IWebDriver driver;

        [SetUp]
        public void initDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.com/";
        }

        [TestCase("zapato")]
        [TestCase("junit")]
        public void search(String text)
        {
            driver.FindElement(By.Name("q")).SendKeys(text);
            Thread.Sleep(20000);
        }

        [TestCase("zapato")]
        [TestCase("junit")]
        public void searchWithClick(String text)
        {
            driver.FindElement(By.Name("q")).SendKeys(text);
            Thread.Sleep(20000);
        }

        [TearDown]
        public void quit()
        {
            driver.Quit();
        }
    }
}
