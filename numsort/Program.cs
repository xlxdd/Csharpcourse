using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numSort
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入一串带有分隔符#的数字（输入 q 退出）：");
                string input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                input = input.Replace(" ", "");
                string[] inputArray = input.Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries);
                double[] numbers = new double[inputArray.Length];
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (!double.TryParse(inputArray[i], out numbers[i]))
                    {
                        Console.WriteLine("输入不符合规范，请重新输入。");
                        break;
                    }
                }
                Array.Sort(numbers);
                Console.WriteLine("排序后的数字为：");
                foreach (double number in numbers)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine("程序已退出。");
            Console.ReadKey();
        }
    }
}

