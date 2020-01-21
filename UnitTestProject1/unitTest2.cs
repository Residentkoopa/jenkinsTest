﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace jenkinsApp
{
    [TestFixture]
    class UnitTest2
    {

        IWebDriver driver;

        [SetUp]
        public void initDriver()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.com/";
        }

        [TestCase("zapato")]
        [TestCase("junit")]
        public void searchGoogle(String text)
        {
            driver.FindElement(By.Name("q")).SendKeys(text);
        }

        [TestCase("zapato")]
        [TestCase("junit")]
        public void searchGoogleWithClick(String text)
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
