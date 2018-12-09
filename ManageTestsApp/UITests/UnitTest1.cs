using System;
using System.Collections.Generic;
using ManageTestsApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using UITests.PageObjects;

namespace UITests
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;
        BaseBlogPage bbp = new BaseBlogPage();
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            driver = new RemoteWebDriver(DesiredCapabilities.Chrome());
        }

        [TestCleanup]
        public void TestClenup()
        {
            driver.Close();
            TestDetails td = new TestDetails();
            td.ChangeTestStatus(TestContext.TestName, TestContext.CurrentTestOutcome.ToString());
        }

        [TestMethod]
        [TestMethodId(1)]
        public void TestMethod1()
        {
            PostList postList = new PostList(driver);

            Assert.IsTrue(postList.PageTitle.Displayed);

            SinglePostPage firstPostPage = postList.OpenFirstPostPage();

            Assert.AreEqual(postList.FirstPostTitle.Text, firstPostPage.PostTitle.Text);
        }
    }
}
