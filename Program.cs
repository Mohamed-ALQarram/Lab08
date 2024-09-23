using System.ComponentModel.Design;
using System.Transactions;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter Stack size: ");
            int.TryParse(Console.ReadLine() ?? "0", out int size);
            Stack<int> stack = new Stack<int>(size);
            char ch;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1.Push");
                Console.WriteLine("2.Pop");
                Console.WriteLine("3.Get Element");
                Console.WriteLine("4.Exit");
                Console.Write("\nEnter Your Choice: ");
                char.TryParse(Console.ReadLine() ?? "0", out ch);
                Console.Clear();
                switch (ch)
                {
                    case '1':
                        if (stack.TopOfStack == stack.Size - 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Your stack is Over Flow.");
                            break;
                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Enter Pushed Number: ");
                        int.TryParse(Console.ReadLine() ?? "", out int val);
                        stack.Push(val);
                        break;
                    case '2':
                        if (stack.TopOfStack == -1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Your stack is Empty");
                            break;
                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\nPoped number is:{stack.Pop()} \n");
                        break;
                    case '3':
                        if (stack.TopOfStack == -1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Your stack is Empty");
                            break;
                        }
                        Console.ForegroundColor= ConsoleColor.Cyan;
                        Console.Write("Enter Index of Element: ");
                        int.TryParse(Console.ReadLine(), out int index);
                        Console.WriteLine(stack.GetByIndex(index));
                        break;
                    case '4':
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter a Valied Number (1 to 3)");
                        break;
                }
            }
            while (ch != '4');


        } 
    }
}
