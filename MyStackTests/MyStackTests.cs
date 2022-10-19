using NUnit.Framework;
using MyStack;

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

        [Test]
        public void Push_Pop()
        {
            MyStack<int> s = new MyStack<int>(3);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            int value = s.Pop();

            Assert.AreEqual(3, value);
            Assert.AreEqual(2, s.Size);
        }
    } 
}