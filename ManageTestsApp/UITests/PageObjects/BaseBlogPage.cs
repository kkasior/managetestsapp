using OpenQA.Selenium;

namespace UITests.PageObjects
{
    public class BaseBlogPage
    {
        private IWebDriver driver;

        public void VerifyRedirection(IWebElement elementFromPage)
        {
            if (elementFromPage.Displayed)
            {
                System.Console.WriteLine("ok");
            }
        }

        public void VerifyRecirection(IWebElement elementFromPreviousPage, IWebElement elementFromCurrentPage )
        {
            if (elementFromCurrentPage.Displayed && elementFromCurrentPage.Text == elementFromPreviousPage.Text)
            {

            }
        }

        public void HighlightElement(IWebElement elementFromPage)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("");
        }
    }
}