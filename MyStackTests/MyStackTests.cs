using NUnit.Framework;

namespace MyStackTests
{
    [TestFixture]
    public class MyStackTests
    {
        [Test]
        public void Creation()
        {
            MyStack<int> s = new MyStack<int>(3);
            Assert.AreEqual(0, s.Size);
        }
    }
}