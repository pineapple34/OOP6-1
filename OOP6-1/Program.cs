using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 0-2 числа (через пробел)");
            string input = Console.ReadLine();

            if (input.Length == 0)
            {
                Numbers num0 = new Numbers();
                Console.WriteLine("a = {0}, b = {1}", num0.a, num0.b);
            }
            else
            {
                string[] inputParsed = input.Split(' ');
                int[] nums = new int[inputParsed.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    if (int.TryParse(inputParsed[i], out nums[i]) == false)
                    {
                        Console.WriteLine("Ошибка: не число.");
                        goto End;
                    }
                }
                switch (nums.Length)
                {
                    case 1:
                        Numbers num1 = new Numbers(nums[0]);
                        Console.WriteLine("a = {0}, b = {1}", num1.a, num1.b);
                        break;
                    case 2:
                        Numbers num2 = new Numbers(nums[0], nums[1]);
                        Console.WriteLine("a = {0}, b = {1}", num2.a, num2.b);
                        break;
                    default:
                        break;
                }
            }

            End:
            Console.ReadKey();
        }
    }

    class Numbers
    {
        public int a, b;
        Random rnd = new Random();

        public Numbers()
        {
            a = rnd.Next(1, 10); b = rnd.Next(1, 10);
        }
        public Numbers(int input)
        {
            a = input; b = rnd.Next(1, 10);
        }
        public Numbers(int input1, int input2)
        {
            a = input1; b = input2;
        }
    }
}
