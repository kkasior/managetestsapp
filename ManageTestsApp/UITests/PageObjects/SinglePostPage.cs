using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UITests.PageObjects
{
    public class SinglePostPage : BaseBlogPage
    {
        IWebDriver driver;

        public SinglePostPage(IWebDriver _driver)
        {
            this.driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#post-48 > header > h1")]
        public IWebElement PostTitle { get; set; }

        [FindsBy(How = How.Id, Using = "respond")]
        public IWebElement LeaveAReplySection { get; set; }

        [FindsBy(How = How.Id, Using = "reply-title")]
        public IWebElement LeaveAReplyTitle { get; set; }

        [FindsBy(How = How.Id, Using = "comment")]
        public IWebElement CommentTextInput { get; set; }

        [FindsBy(How = How.Id, Using = "author")]
        public IWebElement NameTextInput { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailTextInput { get; set; }

        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement PostCommentButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#comments > ol >*:last-child")]
        public IWebElement LastComment { get; set; }

        public void CompareLastCommentWithGivenData(string username, string commentContent)
        {
            try
            {
                if (LastComment.Displayed)
                {
                    IWebElement usernameFromComment = LastComment.FindElement(By.ClassName("fn"));
                    Assert.AreEqual(usernameFromComment.Text, username);
                    IWebElement commentContentFromComment = LastComment.FindElement(By.CssSelector(".comment-content > p"));
                    Assert.AreEqual(commentContent, commentContentFromComment.Text);
                }
            }
            catch (AssertionException e)
            {
                System.Console.WriteLine(e);
            }
        }

        public void AddTextToComment(string commentContent, string username, string email)
        {
            CommentTextInput.SendKeys(commentContent);
            NameTextInput.SendKeys(username);
            EmailTextInput.SendKeys(email);
        }
    }
}