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
        BaseBlogPage bbp = new BaseBlogPage();
        //public TestContext TestContext { get; set; }

        [SetUp]
        public void TestInitialize()
        {
            //driver = new RemoteWebDriver(DesiredCapabilities.Chrome());
        }

        [TearDown]
        public void TestClenup()
        {
            TestResult.TestOutcome = TestContext.CurrentContext.Result.Outcome.ToString();
            UpdateTestResults();
        }

        [Test]
        [TestCaseID(1)]
        public void GIVENCreatedPostWHENCommentIsAddedBelowTHENCommentIsVisibleBelowPost()
        {

            Assert.AreEqual(1, 2);
            //PostList postList = new PostList(driver);

            ////Assert.IsTrue(postList.PageTitle.Displayed);

            //string firstPostTitle = postList.FirstPostTitle.Text;

            //SinglePostPage firstPostPage = postList.OpenFirstPostPage();

            ////Assert.AreEqual(firstPostTitle.ToString(), firstPostPage.PostTitle.Text);
            
        }
        [Test]
        [TestCaseID(2)]
        public void GaIVENCreatedPostWHENCommentIsAddedBelowTHENCommentIsVisibleBelowPost()
        {

            Assert.AreEqual(1, 1);
            //PostList postList = new PostList(driver);

            ////Assert.IsTrue(postList.PageTitle.Displayed);

            //string firstPostTitle = postList.FirstPostTitle.Text;

            //SinglePostPage firstPostPage = postList.OpenFirstPostPage();

            ////Assert.AreEqual(firstPostTitle.ToString(), firstPostPage.PostTitle.Text);

        }
    }
}
