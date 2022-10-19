using NUnit.Framework;
using MyStack;

namespace MyStackTests
{
    [TestFixture]
    public class MyStackTests
    {
        private MyStack<int>? _s;

        [SetUp]
        public void Init()
        {
            _s = new MyStack<int>(3);
        }

        [Test]
        public void Creation()
        {
            Assert.AreEqual(0, _s.Size);
        }

        [Test]
        public void Push_Pop()
        {
            _s = new MyStack<int>(3);
            _s.Push(1);
            _s.Push(2);
            _s.Push(3);
            int value = _s.Pop();

            Assert.AreEqual(3, value);
            Assert.AreEqual(2, _s.Size);
        }
    } 
}