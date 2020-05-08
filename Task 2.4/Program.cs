using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int f=3;
            int n = 5;
            for(int i =0;i<10; i++)
            {
                int k = f;
                for(int j = 0; j < n; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("2" + " ");
                    }
                    else Console.Write((k++) + " ");
                }
                if (i % 2 != 0)
                {
                    f --;  n--;
                }
              
                Console.WriteLine();

            }
            Console.ReadKey();
            
        }
    }
}
