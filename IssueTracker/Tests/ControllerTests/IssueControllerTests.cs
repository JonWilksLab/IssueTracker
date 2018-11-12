using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ControllerTests
{
    [TestClass]
    public class IssueControllerTests
    {
        [TestMethod]
        public void CanGetAListOfAllIssues()
        {
            //Prepare
            var issuesService = new InMemoryIssuesImplementation.Issues();
            var loggerService = new InMemoryLoggerImplementation.Logger();
            var controller = new IssueTracker.Controllers.IssuesController(issuesService, loggerService);
            //Execure
            var results = controller.Get();
            //Test - The default in memory service will provide two Issues
            Assert.AreEqual(2, results.ToList().Count);
        }

        [TestMethod]
        public void CanGetAListOfSpecificUserIssues()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void CanGetAListOfOpenIssues()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void CanCreateANewIssue()
        {
            Assert.Fail();
        }
        [TestMethod]
        public void CanCloseAnIssue()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void CanUpdateAnIssue()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void CanAssignAnIssueToAUser()
        {
            Assert.Fail();
        }
    }
}
