using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇipTasarım_1 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isDivisible(int num)
            {
                for (int i = 1; i <= 20; i++)
                {
                    if (num % i != 0)
                    {
                        return false; 
                    }
                }
                return true; 
            }

            int findSmallestMultiple()
            {
                int num = 20; 
                while (true)
                {
                    if (isDivisible(num))
                    {
                        return num; 
                    }
                    num += 20; 
                }
            }


            {
                int result = findSmallestMultiple();
                Console.WriteLine("1 ile 20 arasındaki tüm sayılara tam bölünebilen en küçük sayı: "+ result);
                Console.Read();
            }
        }
    }
}

