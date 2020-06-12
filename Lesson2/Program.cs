using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("What is your name?");

            string input = Console.ReadLine();

            Console.WriteLine("Hello, " + input);

            object objVar = 2;

            object objVar2 = "Hello";

            object objVar3 = 0.2;

            bool isAlive = true;

            Boolean isDead = false;

            isAlive = false;

            int x = 256;

            Console.WriteLine(int.MinValue);

            double y = 0.3;

            double z = 0.1 + 0.2;
            Console.WriteLine(y == z);

            char ch = 'a';
            char t = '\r';

            string str = "Hello World!\r\nThats my first program!";
            Console.WriteLine(str);

            string name = "John";

            string name2 = "john";

            int a = 300;

            sbyte b = -6;

            byte c = (byte)b;

            a = b;

            input = Console.ReadLine();

            //a = int.Parse(input);

            //a = Convert.ToInt32(input);

            // 1, 012.25 $

            //double test = double.Parse(input.Replace(".", ","));

            a = Convert.ToInt32('6'.ToString());

            bool test2 = Convert.ToBoolean(2);

            Console.WriteLine(test2);

            object obj = (object)name;

            string unboxed = (string)obj;
        }
    }
}
