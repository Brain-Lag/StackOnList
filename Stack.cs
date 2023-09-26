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
            _count = current._count;
            _list.Count = current._list.Count;
            if (current._count == 0)
            {
                return;
            }
            Node<int> originalHead = current._list.Head;
            Node<int> newNode = new Node<int>(originalHead.Data);
            _list.Head = newNode;
            Node<int> tempHead = _list.Head;
            originalHead = originalHead.Next;
            while (originalHead != null)
            {
                newNode = new Node<int>(originalHead.Data);
                tempHead.Next = newNode;
                originalHead = originalHead.Next;
                tempHead = tempHead.Next;
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
            if (_count == 0) throw new InvalidOperationException("Стэк пуст");
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
