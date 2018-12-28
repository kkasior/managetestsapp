using ManageTestsApp;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITests
{
    public class BaseUITest
    {
        private IWebDriver driver { get; set; }

        public IWebDriver InitializeRemoteChromeWebDriver()
        {
            this.driver = new RemoteWebDriver(DesiredCapabilities.Chrome());
            return this.driver;
        }

        public void GetTestResult()
        {
            string testResultWithDescription = TestContext.CurrentContext.Result.Outcome.ToString();
            if (testResultWithDescription.StartsWith("Failed"))
            {
                TestResult.TestOutcome = "Failed";
            }
            else if (testResultWithDescription.StartsWith("Passed"))
            {
                TestResult.TestOutcome = "Passed";
            }
        }

        public void UpdateTestResults()
        {
            TestDetails testDetails = new TestDetails();
            testDetails.ChangeTestStatus();
        }

        public void ScrollToSelectedElement(IWebElement element)
        {
            var js = (IJavaScriptExecutor)driver;
            const string script = @"arguments[0].scrollIntoView(true);";
            js.ExecuteScript(script, element);
        }

        public void HighlightElement(IWebElement elementFromPage)
        {
            var js = (IJavaScriptExecutor)driver;
            const string script = @"arguments[0].style.cssText = ""border-width: 2px; border-style: solid; border-color: red"";";
            js.ExecuteScript(script, elementFromPage);
        }

    }
}
