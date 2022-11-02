using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimas_Damar_Buana_20210140135_Exe2
{
    class Program
    {
        int[] dimas = new int[28];

        int n, temp;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 28)
                    break;
                else
                    Console.WriteLine("\nArray can only have a maximum of 28 elements \n");
            }
            Console.WriteLine("\n===================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n===================");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                dimas[i] = Int32.Parse(s1);
            }

        }

        public void InsertionSort()
        {
            for (int i = 0; i < n; i++)
            {
                temp = dimas[i];
                int pass = 0;
                for (int DB = i - 1; DB >= 0 && pass != 1;)
                {
                    if (temp < dimas[DB])
                    {
                        dimas[DB + 1] = dimas[DB];
                        DB--;
                        dimas[DB + 1] = temp;
                    }
                    else pass = 1;
                }
            }
        }
        
        

        static void Main(string[] args)
        {
            
        }
    }
}
