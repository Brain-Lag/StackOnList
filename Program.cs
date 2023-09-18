using System;

namespace StackOnList
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack stack = new Stack(5);
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Push(4);
                Console.WriteLine(stack);
                Stack stack2 = new Stack(stack);
                stack2.Push(3);
                stack2.Pop();
                stack2.Pop();
                stack2.Push(4);
                Console.WriteLine(stack2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

