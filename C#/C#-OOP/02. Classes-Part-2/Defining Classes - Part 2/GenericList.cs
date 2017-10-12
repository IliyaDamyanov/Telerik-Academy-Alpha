using System;

namespace Defining_Classes___Part_2
{
    public class GenericList<T>
        where T : IComparable<T>
    {
        private T[] array;
        private int arrSize;
        private int lastElementIndex = 0;

        public GenericList(int capacity)
        {
            if (capacity < 1) 
            {
                throw new ArgumentOutOfRangeException("The size must be larger than zero!");
            }
            this.arrSize = capacity;
            this.ClearList();
        }

        public int Lenght
        {
            get
            {
                return this.lastElementIndex;
            }
        }
        public T this[int index]
        {
            get
            {
                if (index<0 || index > this.lastElementIndex-1)
                {
                    throw new ArgumentOutOfRangeException($"Index must be between 0 and {this.lastElementIndex}");
                }
                return this.array[index];
            }
        }

        public void AddElement(T element)
        {
            this.Grow();
            this.array[lastElementIndex] = element;
            this.lastElementIndex++;
        }

        public T AccessElementByIndex(int index)
        {
            if (index<0 || index>this.lastElementIndex-1)
            {
                throw new ArgumentOutOfRangeException($"Index must be between 0 and {this.lastElementIndex}");
            }
            return this.array[index];
        }

        public void RemoveElement(int index)
        {
            if (index < 0 || index > this.lastElementIndex - 1)
            {
                throw new ArgumentOutOfRangeException($"Index must be between 0 and {this.lastElementIndex}");
            }

            T[] newArr = new T[this.arrSize];
            for (int i = 0; i < index; i++)
            {
                newArr[i] = this.array[i];
            }
            for (int i = index; i < this.lastElementIndex; i++)
            {
                newArr[i] = this.array[index + 1];
            }
            this.array = newArr;
            this.lastElementIndex--;
        }       

        public void InsertElement(T element ,int index)
        {
            if (this.lastElementIndex==index)
            {
                this.AddElement(element);
                return;
            }

            if (index < 0 || index > this.lastElementIndex - 1)
            {
                throw new ArgumentOutOfRangeException($"Index must be between 0 and {this.lastElementIndex}");
            }

            T[] newArr = new T[this.arrSize];
            for (int i = 0; i < index; i++)
            {
                newArr[i] = this.array[i];
            }
            newArr[index] = element;
            for (int i = index+1; i < this.lastElementIndex; i++)
            {
                newArr[i] = this.array[i - 1];
            }
            this.array = newArr;
            this.lastElementIndex++;
        }

        public void ClearList()
        {
            this.array = new T[this.arrSize];
            this.lastElementIndex = 0;
        }

        public int FindElementByValue(T element)
        {
            int result = -1;
            for (int i = 0; i < this.lastElementIndex; i++)
            {
                if (this.array[i].Equals(element))
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        private void Grow()
        {
            if (this.lastElementIndex!=this.arrSize)
            {
                return;
            }
            T[] newArr = new T[this.arrSize * 2];
            for (int i = 0; i < this.lastElementIndex; i++)
            {
                newArr[i] = this.array[i];
            }
            this.array = newArr;
            this.arrSize *= 2;
        }

        public T Min()
        {
            if (this.lastElementIndex==0)
            {
                return default(T);
            }

            T result = this.array[0];
            for (int i = 0; i < lastElementIndex; i++)
            {
                if (this.array[i].CompareTo(result)<0)
                {
                    result = this.array[i];
                }
            }
            return result;
        }

        public T Max()
        {
            if (this.lastElementIndex == 0)
            {
                return default(T);
            }

            T result = this.array[0];
            for (int i = 0; i < lastElementIndex; i++)
            {
                if (this.array[i].CompareTo(result) > 0)
                {
                    result = this.array[i];
                }
            }
            return result;
        }
    }
}
