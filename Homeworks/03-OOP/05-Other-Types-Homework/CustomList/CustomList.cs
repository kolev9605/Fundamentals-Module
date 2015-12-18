using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace CustomList
{
    public class CustomList<T>
        where T : IComparable
    {
        private const int DefaultCapacity = 16;
        private int currentIndex;

        private int capacity;

        private T[] array;

        public CustomList()
        {
            this.Capacity = DefaultCapacity;
            this.array = new T[this.Capacity];
        }

        public CustomList(int capacity = DefaultCapacity)
        {
            this.Capacity = capacity;
            this.array = new T[this.Capacity];
        }

        public int Capacity //done
        {
            get { return this.capacity; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Capacity cannot be negative");
                }
                this.capacity = value;
            }
        }

        public int Count //done
        {
            get { return this.currentIndex; }
            private set { this.currentIndex = value; }
        }

        public T this[int i] //done
        {
            get { return this.array[i]; }
            set { this.array[i] = value; }
        }

        private void CheckIfEmpty()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty");
            }
        }

        private void CheckCapacity(int currIndex) //reference?
        {
            if (this.Capacity <= currIndex)
            {
                this.Capacity *= 2;
                var newArr = new T[this.Capacity];
                for (int i = 0; i < this.array.Length; i++)
                {
                    newArr[i] = this.array[i];
                }
                this.array = new T[this.Capacity];
                this.array = newArr;
            }
        }

        public void Add(T element) //done
        {
            CheckCapacity(this.Count);
            this.array[this.Count] = element;
            this.Count++;
        }

        public void RemoveAt(int indexToRemove) //should work
        {
            if (indexToRemove < 0 || indexToRemove > this.Capacity)
            {
                throw new ArgumentOutOfRangeException("Index is out of range");
            }

            bool hasRemoved = false;
            var newArray = new T[this.Capacity];
            int count = 0;

            for (int i = 0; i < this.currentIndex; i++)
            {
                if (count == indexToRemove && hasRemoved == false)
                {
                    count--;
                    hasRemoved = true;
                    continue;
                }
                newArray[count] = this.array[i];
                count++;
            }
            this.array = newArray;
        }

        public T IndexOf(T element) //should work
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i].CompareTo(element) == 0)
                {
                    return this.array[i];
                }
            }
            throw new InvalidOperationException("Not such element found");
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > this.Capacity)
            {
                throw new ArgumentOutOfRangeException("Index is out of range");
            }
            CheckCapacity(this.Count);
            var newArray = new T[this.Capacity];
            bool hasInserted = false;
            int counter = 0;

            for (int i = 0; i < this.Count; i++)
            {
                if (counter == index && hasInserted == false)
                {
                    newArray[counter] = item;
                    hasInserted = true;
                    this.Count++;
                    continue;
                }
                newArray[i] = this.array[counter];
                counter++;
            }
            this.array = newArray;
        }

        public void Clear()
        {
            this.Count = 0;
        }

        public bool Contains(T value)
        {
            bool hasFound = false;

            for (int i = 0; i < this.Count; i++)
            {
                if (this.array[i].Equals(value))
                {
                    hasFound = true;
                }
            }
            return hasFound;
        }

        public T Min()
        {
            T currentMin = this.array[0];
            for (int i = 1; i < this.Count; i++)
            {
                if (this.array[i].CompareTo(currentMin) == -1)
                {
                    currentMin = this.array[i];
                }
            }
            return currentMin;
        }

        public T Max()
        {
            T currentMax = this.array[0];
            for (int i = 1; i < this.Count; i++)
            {
                if (this.array[i].CompareTo(currentMax) == 1)
                {
                    currentMax = this.array[i];
                }
            }
            return currentMax;
        }

        public int Find(T value)
        {
            CheckIfEmpty();
            for (int i = 0; i < Count; i++)
            {
                if (this.array[i].Equals(value))
                {
                    return i;
                }
            }
            throw new ArgumentException("Not such element found");
        }

        public override string ToString()
        {
            if (this.Count == 0)
            {
                return "[Empty]";
            }
            var builder = new StringBuilder();
            builder.Append("[");
            for (int i = 0; i < this.Count; i++)
            {
                builder.Append(this.array[i]);
                builder.Append(", ");
            }
            builder.Remove(builder.Length - 2, 2);
            builder.Append("]");

            return builder.ToString();
        }
    }
}