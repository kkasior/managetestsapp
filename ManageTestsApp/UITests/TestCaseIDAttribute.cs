using ManageTestsApp;
using System;

namespace UITests
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class TestCaseIDAttribute : Attribute
    {
        public TestCaseIDAttribute(int id)
        {
            TestResult.TestID = id;
        }
    }
}