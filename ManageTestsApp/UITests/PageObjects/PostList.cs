﻿using OpenQA.Selenium;
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
        public IWebElement PageTitle;

        [FindsBy(How = How.CssSelector, Using = "#post-48 > header > h2")]
        public IWebElement FirstPostTitle;

        public SinglePostPage OpenFirstPostPage()
        {
            HighlightElement(FirstPostTitle, driver);
            WaitUntilIsClickable(driver, FirstPostTitle);
            FirstPostTitle.Click();

            SinglePostPage singlePostPage = new SinglePostPage(driver);

            return singlePostPage;
        }


    }
}
