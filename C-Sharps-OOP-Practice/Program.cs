using System;



namespace C_Sharps_OOP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack stack = new Stack();
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Clear();
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Push(new StopWatch());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
