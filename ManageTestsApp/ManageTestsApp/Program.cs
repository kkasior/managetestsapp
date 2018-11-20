using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;

namespace ManageTestsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost/blog";

            IWebElement helloWorld = driver.FindElement(By.LinkText("Hello world!"));
            helloWorld.Click();
            IWebElement image = driver.FindElement(By.ClassName("overlay"));
            if (image.Displayed)
            {
                TestDetails testdetails = new TestDetails();
                Perform(testdetails, "passed");
            }
            else
            {
                TestDetails testdetails = new TestDetails();
                Perform(testdetails, "failed");
            }
            
        }

        static void Perform(TestDetails _testdetails, string status)
        {
            _testdetails.ChangeTestStatus(_testdetails.LoadTestDetails(), 1, status);
        }
    }
}
