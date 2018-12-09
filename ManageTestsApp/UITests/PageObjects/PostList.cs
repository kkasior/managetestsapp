using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITests.PageObjects
{
    class PostList : BaseBlogPage
    {
        string postListPageUrl = "http://localhost/blog/";

        [FindsBy(How = How.ClassName, Using = "site-title")]
        private IWebElement PageTitle;

        [FindsBy(How = How.CssSelector, Using = "#post-48 > header > h2")]
        private IWebElement FirstPostTitle;

        public PostList(IWebDriver driver)
        {
            driver.Url = postListPageUrl;
        }

        public SinglePostPage OpenFirstPostPage()
        {
            FirstPostTitle.Click();
            return 0;

        }


    }
}
