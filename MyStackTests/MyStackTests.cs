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
        { ;
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
            Assert.Throws<ExpenditureProhibitedException>(() => _s.Pop());
        }

        [Test]
        public void Too_Much_Push()
        {
            _s.Push(1);
            _s.Push(2);
            _s.Push(3);
            Assert.Throws<ExceededSizeException>(() => _s.Push(4));
        }

        [Test]
        public void Peek_Exception()
        {
            Assert.Throws<ExpenditureProhibitedException>(() => _s.Peek());
        }

        [Test]
        public void Peek_Element()
        {
            _s.Push(1);
            _s.Push(2);
            int value = _s.Peek();

            Assert.AreEqual(2, value);
            Assert.AreEqual(2, _s.Size);
        }

    }
}