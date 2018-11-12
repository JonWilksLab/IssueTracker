using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ControllerTests
{
    [TestClass]
    public class ValuesControllerTests
    {
        [TestMethod]
        public void SimpleValueControlerTest()
        {
            var controller = new IssueTracker.Controllers.ValuesController();
            var results = controller.Get();
            Assert.AreEqual(2, ((string[])results.Value).Length);
        }
    }
}
