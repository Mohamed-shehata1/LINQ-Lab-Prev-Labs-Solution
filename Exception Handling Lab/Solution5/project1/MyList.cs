using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class MyList<T> where T : IComparable
    {
        T[] items;
        int size;
        int top;
        public MyList(int _size = 3)
        {
            size = _size;
            items = new T[size];
            top = -1;
        }
        public void Add(T item)
        {
            if (top >= size - 1)
            {
                T[] newArray = new T[size * 2];
                Array.Copy(items, newArray, items.Length);
                items = newArray;
                size *= 2;
            }
            items[++top] = item;
        }
        public void Print()
        {
            foreach (T item in items)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public T this[int index]
        {
            get
            {
                if ((index >= 0) && (index < size))
                {
                    return items[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if ((index >= 0) && (index < size))
                {
                    items[index] = value;
                }
                throw new IndexOutOfRangeException();
            }
        }
        public void Remove(T item)
        {
            int indexToRemove = IndexOf(item);
            if (indexToRemove != -1)
            {
                T[] newArray = new T[items.Length - 1];
                for (int i = 0, j = 0; i < items.Length; i++)
                {
                    if (i == indexToRemove) continue;
                    newArray[j++] = items[i];
                }
                items = newArray;
                size--;
            }
            else
                Console.WriteLine("item not found");
        }
        public int IndexOf(T item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(items[i], item))
                    return i;
            }
            return -1;
        }
        public List<T> filter(Predicate<T> pred)
        {
            List<T> list = new List<T>();
            foreach (T item in items)
            {
                if (pred(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
