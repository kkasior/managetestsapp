using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace UITests.PageObjects
{
    public class BaseBlogPage
    {
        public void HighlightElement(IWebElement elementFromPage, IWebDriver driver)
        {
            var js = (IJavaScriptExecutor)driver;
            const string script = @"arguments[0].style.cssText = ""border-width: 2px; border-style: solid; border-color: red"";";
            js.ExecuteScript(script, elementFromPage);
        }

        public void WaitUntilIsClickable(IWebDriver driver, IWebElement element)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(ExpectedConditions.ElementToBeClickable(element));        
        }
    }
}