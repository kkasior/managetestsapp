using System;
using System.Collections.Generic;
using ManageTestsApp;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using UITests.PageObjects;


namespace UITests
{
    [TestFixture]
    public class SinglePostPageUITest: BaseUITest
    {
        private IWebDriver driver;

        [SetUp]
        public void TestInitialize()
        {
            driver = InitializeRemoteChromeWebDriver();
        }

        [TearDown]
        public void TestClenup()
        {
            driver.Quit();
            TestResult.TestOutcome = TestContext.CurrentContext.Result.Outcome.ToString();
            UpdateTestResults();
        }

        [Test]
        [TestCaseID(1)]
        public void GIVENCreatedPostWHENCommentIsAddedBelowTHENCommentIsVisibleBelowPost()
        {
            PostList postList = new PostList(driver);

            Assert.IsTrue(postList.PageTitle.Displayed);

            string firstPostTitle = postList.FirstPostTitle.Text;

            SinglePostPage firstPostPage = postList.OpenFirstPostPage();

            Assert.AreEqual(firstPostTitle.ToString(), firstPostPage.PostTitle.Text); 
        }
        [Test]
        [TestCaseID(2)]
        public void GaIVENCreatedPostWHENCommentIsAddedBelowTHENCommentIsVisibleBelowPost()
        {

            Assert.AreEqual(1, 2);
            //PostList postList = new PostList(driver);

            ////Assert.IsTrue(postList.PageTitle.Displayed);

            //string firstPostTitle = postList.FirstPostTitle.Text;

            //SinglePostPage firstPostPage = postList.OpenFirstPostPage();

            ////Assert.AreEqual(firstPostTitle.ToString(), firstPostPage.PostTitle.Text);

        }
    }
}
