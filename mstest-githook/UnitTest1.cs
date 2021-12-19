using Microsoft.VisualStudio.TestTools.UnitTesting;
using githook_template;


namespace mstest_githook
{
    [TestClass]
    public class UnitTestCICD
    {
        BusinessLogic bl = new BusinessLogic();

        [TestMethod]
        public void TestCICD()
        {
            
            Assert.IsTrue(bl.IsCICD());
        }
    }
}
