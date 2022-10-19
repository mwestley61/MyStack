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
        [Test]
        public void Too_much_Pop()
        {
            MyStack<int> s = new MyStack<int>(3);
            Assert.Throws<ExpenditureProhibitedException>(() => s.Pop());
        }

        [Test]
        public void Too_Much_Push()
        {
            MyStack<int> s = new MyStack<int>(3);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.Throws<ExceededSizeException>(() => s.Push(4));
        }
    }
}