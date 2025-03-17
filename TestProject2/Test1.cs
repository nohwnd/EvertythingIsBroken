using BrokenLid;

namespace TestProject2
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            new BrokenClass().SomeChildCodeIsBroken();

        }
    }
}
