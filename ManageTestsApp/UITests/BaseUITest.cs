using ManageTestsApp;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
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

        public void UpdateTestResults()
        {
            TestDetails td = new TestDetails();
            td.ChangeTestStatus();
        }

    }
}
