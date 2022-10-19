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
            if (Size == maximumLength)
            {
                throw new ExceededSizeException();
            }

            stackArray[Size++] = value;
        }

        public T Pop()
        {
            if (Size == 0)
            {
                throw new ExpenditureProhibitedException();
            }

            return stackArray[--Size];
        }
    }
}