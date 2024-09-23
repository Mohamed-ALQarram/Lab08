using System;

namespace Lab5
{
    internal class Stack<T>:GetByIndex<T>
    {
        T[] StackArr;
        public int Size { get; init; }
        public int TopOfStack {  get; private set; }
        public Stack() : this(0) { }
        public Stack(int size)
        {
            Size = size;
            StackArr = new T[Size];
            TopOfStack = -1;
        }

        public void Push(T value) 
        {
            TopOfStack++;
            StackArr[TopOfStack] = value;
            //if (TopOfStack == StackArr.Length-1)
                //resize();
        }
        public T Pop() 
        {
        return StackArr[TopOfStack--];
        }

        public T GetByIndex(int index)
        {
            return StackArr[index];
        }

        public static Stack<T> operator+ (Stack<T> a, Stack<T> b) 
        {
            T[] arr = new T[a.Size+b.Size];
            int top_a = a.TopOfStack;
            int top_b = b.TopOfStack;
            while (a.TopOfStack >=0) 
            {
                arr[a.TopOfStack] = a.Pop();
            }
            while (b.TopOfStack >= 0)
            {
                arr[top_a+1+ b.TopOfStack] = b.Pop();
            }
            return new Stack<T> { StackArr = arr ,TopOfStack =top_a+top_b+1 , Size = arr.Length};
        }
        public T? this[int index]
        {
            get 
            {
            if(index <StackArr.Length && index >=0) 
                return StackArr[index];
            return default;
            }
        }
        public static explicit operator Stack<T>(T[] arr) 
        {
            return new Stack<T> { StackArr = arr, TopOfStack = arr.Length-1 };
        }
        public static implicit operator T[] (Stack<T> s1)
        {
            T[] arr = new T[s1.Size];
            while (s1.TopOfStack >= 0)
            {
                arr[s1 .TopOfStack] = s1.Pop();
            }
            return arr;
        }

    }
}
