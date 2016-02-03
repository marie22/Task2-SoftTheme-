using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_SoftTheme_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input a number");
                int num = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.Write(" " + i);

                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
