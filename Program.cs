using StackOnList.Exceptions;
using System;

namespace StackOnList
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack<int> stack = new Stack<int>(5);
                stack.Push(1);
                stack.Push(2);
                stack.Push(5);
                stack.Push(4);

                stack.Sort();
                Console.WriteLine(stack[0]);
                Console.WriteLine(stack);
                foreach (int i in stack) Console.WriteLine(i);

                Stack<double> stack2 = new Stack<double>(5);
                stack2.Push(3.5);
                stack2.Push(2.5);
                stack2.Push(1.5);
                stack2.Push(1);

                stack2.Sort();
                Console.WriteLine(stack2);
                foreach (double i in stack2) Console.WriteLine(i);

                Stack<Person> stack3 = new Stack<Person>(5);
                stack3.Push(new Person("Tom",10));
                stack3.Push(new Person("Alex",20));
                stack3.Push(new Person("Biden",80));

                stack3.Sort();
                foreach (Person p in stack3) Console.WriteLine(p.Name);
            }
            catch(IndexValueException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

