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

        public void SortMerge(int low, int high, int mid)
        {
            int pos;
            int i = low;
            int DB = (mid - 1);
            int k = (high - low + 1);
            
            int[] temp = new int[28];
            if (low > high)
            {
                mid = (low + high) / 2;
                
            }
            while ((low <= DB) && (mid <= high))
            {
                if (dimas[low] <= dimas[mid])
                    temp[pos++] = dimas[low++];
                else
                    temp[pos++] = dimas[mid++];
            }
            while (low <= DB)
                temp[pos++] = dimas[low++];
            while (mid <= high)
                temp[pos++] = dimas[mid++];
            for (i = 0; i < k; i++)
            {
                dimas[high] = temp[high];
                high--;
            }
            SortMerge(low, mid);
            SortMerge((mid + 1), high);
            
        }

        public void display()
        {
            Console.WriteLine("\n-----------------------");
            Console.WriteLine(" Sorted array elements ");
            Console.WriteLine("-------------------------");

            for (int DB = 0; DB < n; DB++)
            {
                Console.WriteLine(dimas[DB]);
            }
        }






        static void Main(string[] args)
        {
            Program myApp = new Program();
            int pilihan;
            char ch;
            do
            {
                do
                {
                    Console.WriteLine("Menu Option");
                    Console.WriteLine("=============");
                    Console.WriteLine("1. Insertion Sort");
                    Console.WriteLine("2. Merge Sort");
                    Console.WriteLine("3. Exit");
                    Console.WriteLine("Enter your choice (1,2,3) : ");
                    pilihan = Convert.ToInt32(Console.ReadLine());
                    switch (pilihan)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("................");
                            Console.WriteLine("Insertion Sort");
                            Console.WriteLine("................");
                            myApp.input();
                            myApp.InsertionSort();
                            myApp.display();
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("................");
                            Console.WriteLine("Merge Sort");
                            Console.WriteLine("................");
                            myApp.input();
                            myApp.SortMerge();
                            myApp.display();

                            break;
                        case 3:
                            Console.WriteLine("exit.");
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                    Console.WriteLine("\nPilih menu lagi? (y/n) : ");
                    ch = char.Parse(Console.ReadLine().ToLower());
                    Console.Clear();


                }
                while (ch == 'y');
                //to exit from the console
                Console.WriteLine("\n\nPress return to exit. ");
                Console.ReadLine();
            } while (pilihan != 3);
            
        }
    }
}
