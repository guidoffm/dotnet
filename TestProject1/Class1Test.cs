using vbinterfaces;

namespace TestProject1
{
    [TestClass]
    public class Class1Test
    {
        private readonly IClass1 iClass1Impl;

        public Class1Test()
        {
            iClass1Impl = Helper.GetRequiredService<IClass1>();
        }

        [TestMethod]
        public void TestSayHello()
        {
            iClass1Impl.SayHello();
        }

        [TestMethod]
        public void TestGetHello()
        {
            var res = iClass1Impl.GetHello();
            Assert.AreEqual("Hello", res);
        }
    }
}