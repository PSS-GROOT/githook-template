using NUnit.Framework;
using githook_template;

namespace nunittest_githook
{
    public class Tests
    {
        BusinessLogic bl = null;

        [SetUp]
        public void Setup()
        {
           bl = new BusinessLogic();
        }

        [Test]
        public void TestBL()
        {
            Assert.IsTrue(bl.IsCICD());
           
        }
    }
}
