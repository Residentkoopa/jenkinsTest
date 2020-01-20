using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

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
        }

        [TestCase("zapato")]
        [TestCase("junit")]
        public void searchWithClick(String text)
        {
            driver.FindElement(By.Name("q")).SendKeys(text);
            //driver.FindElement(By.Name("btnK")).Click();
        }

        [TearDown]
        public void quit()
        {
            driver.Quit();
        }
    }
}
