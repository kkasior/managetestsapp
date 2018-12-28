using ManageTestsApp;
using NUnit.Framework;
using OpenQA.Selenium;
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
            GetTestResult();
            UpdateTestResults();
        }

        [Test]
        [TestCaseID(1)]
        public void GIVENCreatedPostWHENCommentIsAddedBelowTHENCommentIsVisibleBelowPost()
        {
            PostList postListPage = new PostList(driver);
            Assert.IsTrue(postListPage.PageTitle.Displayed);
            string firstPostTitle = postListPage.FirstPostTitle.Text;

            SinglePostPage firstPostPage = postListPage.OpenFirstPostPage();
            Assert.AreEqual(firstPostTitle.ToString(), firstPostPage.PostTitle.Text);

            Assert.IsTrue(firstPostPage.LeaveAReplySection.Displayed && firstPostPage.LeaveAReplySection.Enabled);
            string comment = "this is very good comment20000";
            string username = "superuser";
            string email = "super@user.com";

            firstPostPage.AddTextToComment(comment, username, email);
            firstPostPage.PostCommentButton.Click();

            firstPostPage.CompareLastCommentWithGivenData(username, comment);
        }
        [Test]
        [TestCaseID(2)]
        public void GaIVENCreatedPostWHENCommentIsAddedBelowTHENCommentIsVisibleBelowPost()
        {

        }
    }
}
