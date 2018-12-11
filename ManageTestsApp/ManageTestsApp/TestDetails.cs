using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageTestsApp
{
    public class TestDetails
    {
        public int testId { get; set; }
        public string testName { get; set; }
        public string given { get; set; }
        public string when { get; set; }
        public string then { get; set; }
        public string projectName { get; set; }
        public string tester { get; set; }
        public string solutionPath { get; set; }
        public string affectedBy { get; set; }
        public string additionalInfo { get; set; }
        public string testData { get; set; }
        public string testStatus { get; set; }

        string path = @"C:\dev\anginz\src\api\tests\tests.json";

        public List<TestDetails> LoadTestDetails()
        {
            List<TestDetails> testDetailsFromFile = JsonConvert.DeserializeObject<List<TestDetails>>(File.ReadAllText(path));
            return testDetailsFromFile;
        }

        public void ChangeTestStatus()
        {
            List<TestDetails> testDetails = LoadTestDetails();
            TestDetails testToChange = testDetails.Where(t => t.testId == TestResult.TestID).First();
            testToChange.testStatus = TestResult.TestOutcome;
            
            string json = JsonConvert.SerializeObject(testDetails);
            System.IO.File.WriteAllText(path, json);
        }
    }
}
