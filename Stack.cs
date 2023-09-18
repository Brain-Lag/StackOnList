using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOnList
{
    class Stack
    {
        private int _size;
        private List<int> _list;
        private int _count;
        private int _currentSum;
        public double AvgValue { get; private set; }
        public Stack(int size)
        {
            if (size <= 0)
            {
                throw new InvalidOperationException("Не допускается отрицательное значение size");
            }
            _size = size;
            _list = new List<int>();
        }

        public Stack(Stack current)
        {
            _list = new List<int>();
            _size = current._size;

            var temp = new Stack(_size);
            while (current._count > 0)
            {
                int item = current.Pop();
                temp.Push(item);
            }

            while (temp._count > 0)
            {
                int item = temp.Pop();
                Push(item);
            }
        }

        public void Push(int item)
        {
            if (_list.Count == _size)
            {
                throw new InvalidOperationException("Стэк полон");
            }
            _count++;
            _list.Add(item);
            IncreaseAvgValue(item);
        }

        public int Pop()
        {
            DecreaseAvgValue(Peek());
            _count--;
            return _list.Remove();
        }

        public int Peek()
        {
            if (_count == 0) throw new InvalidOperationException("Стэк пуст");
            var cache = _list.Remove();
            _list.Add(cache);
            return cache;
        }

        private void IncreaseAvgValue(int item)
        {
            _currentSum += item;
            AvgValue = _currentSum;
            AvgValue /= _count;
        }

        private void DecreaseAvgValue(int item)
        {
            _currentSum -= item;
            AvgValue = _currentSum;
            if (_count == 0)
            {
                AvgValue = 0;
                return;
            }
            AvgValue /= _count;
        }

        public override string ToString()
        {
            var current = _list.Head;
            var output = string.Empty;
            for (int i = 0; i < _list.Count; i++)
            {
                output += current.Data + " ";
                current = current.Next;
            }
            return output;
        }
    }
}   
