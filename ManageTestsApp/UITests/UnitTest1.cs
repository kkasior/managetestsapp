using System;
using System.Collections.Generic;
using ManageTestsApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using System.Linq;

namespace UITests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestCleanup]
        public void TestClenup()
        {
            TestDetails td = new TestDetails();
            td.ChangeTestStatus(TestContext.TestName, TestContext.CurrentTestOutcome.ToString());
        }
        [TestMethod]
        [TestMethodId(1)]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost/blog";

            IWebElement helloWorld = driver.FindElement(By.LinkText("Hello world!"));
            //helloWorld.Click();
            //IWebElement image = driver.FindElement(By.ClassName("overlay"));
        }
        [TestMethod]
        [TestMethodId(2)]
        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost/blog";

            IWebElement helloWorld = driver.FindElement(By.LinkText("Hello world!"));
            //helloWorld.Click();
            //IWebElement image = driver.FindElement(By.ClassName("overlay"));
        }

    }
}
