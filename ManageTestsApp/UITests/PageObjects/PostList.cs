using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITests.PageObjects
{
    class PostList : BaseBlogPage
    {
        IWebDriver driver;

        public PostList(IWebDriver _driver)
        {
            this.driver = _driver;
            PageFactory.InitElements(driver, this);
            driver.Url = postListPageUrl;
        }

        string postListPageUrl = "http://localhost/blog/";

        [FindsBy(How = How.ClassName, Using = "site-title")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-48 > header > h2 > a")]
        public IWebElement FirstPostTitle { get; set; }

        public SinglePostPage OpenFirstPostPage()
        {
            try
            {
                FirstPostTitle.Click();
            }
            catch
            {
                if(FirstPostTitle.Displayed && FirstPostTitle.Enabled)
                    FirstPostTitle.Click();
            }


            SinglePostPage singlePostPage = new SinglePostPage(driver);

            return singlePostPage;
        }


    }
}
