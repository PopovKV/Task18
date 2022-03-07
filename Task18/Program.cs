using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Stack<char> a = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    a.Push(')');
                }
                if (s[i] == '{')
                {
                    a.Push('}');
                }
                if (s[i] == '[')
                {
                    a.Push(']');
                }
                if ((s[i] == ')') && (s[i].Equals(a.Peek()) == true))
                {
                    a.Pop();
                }
                if ((s[i] == ']') && (s[i].Equals(a.Peek()) == true))
                {
                    a.Pop();
                }
                if ((s[i] == '}') && (s[i].Equals(a.Peek()) == true))
                {
                    a.Pop();
                }
            }
            if (a.Count==0)
            {
                Console.WriteLine("Скобки расставлены корректно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены некорректно");
            }            
            Console.ReadKey();
        }
    }
}
