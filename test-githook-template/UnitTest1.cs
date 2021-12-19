using NUnit.Framework;
using githook_template;

namespace test_githook_template
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCICD()
        {
            BusinessLogic bl = new BusinessLogic();
            Assert.IsTrue(bl.IsCICD());
        }
    }
}
