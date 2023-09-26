using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOnList
{

    public class List<T>
    {
        public Node<T>? Head { get; set; } 
        public int Count { get; set; }

        public void Add(T item)
        {
            Node<T> node = new Node<T>(item);

            if (Head == null) Head = node;
            else
            {
                node.Next = Head;
                Head = node;
            }
            Count++;
        }

        public T Remove()
        {
            if (Head == null) throw new InvalidOperationException("Стэк пуст");
            Count--;
            var current = Head;
            Head = Head.Next;
            return current.Data;
        }
    }
}
