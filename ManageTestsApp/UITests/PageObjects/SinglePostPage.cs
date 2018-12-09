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
        public IWebElement PostTitle;

        [FindsBy(How = How.Id, Using = "reply-title")]
        public IWebElement LeaveAReplyTitle;

        [FindsBy(How = How.Id, Using = "comment")]
        public IWebElement CommentTextInput;

        [FindsBy(How = How.Id, Using = "author")]
        public IWebElement NameTextInput;

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailTextInput;

        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement PostCommentButton;

        public void GoToLeaveAReplySection()
        {

        }
    }
}