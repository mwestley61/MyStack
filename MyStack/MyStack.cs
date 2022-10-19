namespace MyStack
{
    public class MyStack<T>
    {
        #region Members
        private T[] stackArray;
        private int maximumLength;
        #endregion

        #region Properties
        public int Size { get; private set; }
        #endregion

        #region Constructor
        public MyStack(int length)
        {
            maximumLength = length;
            stackArray = new T[length];
        }
        #endregion

        public void Push(T value)
        {
            stackArray[Size++] = value;
        }

        public T Pop()
        {
            return stackArray[--Size];
        }
    }
}