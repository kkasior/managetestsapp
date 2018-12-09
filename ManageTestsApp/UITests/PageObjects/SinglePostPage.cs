using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UITests.PageObjects
{
    public class SinglePostPage : BaseBlogPage
    {
        [FindsBy(How = How.LinkText, Using = "")]
        IWebElement PostTitle;

        [FindsBy(How = How.Id, Using = "reply-title")]
        IWebElement LeaveAReplyTitle;

        [FindsBy(How = How.Id, Using = "comment")]
        IWebElement CommentTextInput;

        [FindsBy(How = How.Id, Using = "author")]
        IWebElement NameTextInput;

        [FindsBy(How = How.Id, Using = "email")]
        IWebElement EmailTextInput;

        [FindsBy(How = How.Id, Using = "submit")]
        IWebElement PostCommentButton;

        public void GoToLeaveAReplySection()
        {

        }
    }
}