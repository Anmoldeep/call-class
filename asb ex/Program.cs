using System;

namespace asb_ex
{
    class Program
    {
        static void Main(string[] args)
        { 

            //q9

            bool check = false;
            do
            {

                Console.WriteLine("Please choose:1, 5, 6, 7, 8,");
                Console.WriteLine("press 1 for Q1.");
                string input = Console.ReadLine();
                

                if (input == "1")
                    Q1();
                if (input == "5")
                    Q5();
                if (input == "6")
                    Q6();
                if (input == "7")
                    Q7();
                if (input == "8")
                    Q8();
                else
                    check = true;

            } while (!check);



                 
          
            Console.ReadLine();

        }

        static string Q1()
        {
            int a, b, c, d, e, f;
            Console.WriteLine("give value for a=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("give value for b=");
            b = int.Parse(Console.ReadLine());
            //q2 
            c = a + b;
            d = a - b;
            //q4
            e = a * b;
            //q3
            f = a % b;
            Console.WriteLine("*Add= {0}", c);
            Console.WriteLine("*Sub= {0}", d);
            Console.WriteLine("*mulltiple= {0}", e);
            Console.WriteLine("*divide= {0}", f);
            return "hlo\n";
        }

        static string Q5()
        {
            Console.WriteLine("enter no. for loop");
           int g = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0} *{1}={2}\n", g, i, g * i);
            }
            return "hi\n";
        }
        static string Q6()
        {
            Double r, per, ar;

            Console.WriteLine("emter radius");
            r = Convert.ToDouble(Console.ReadLine());
            per = 2 * Math.PI * r;
            ar = Math.PI * r * r;
            Console.WriteLine($"per={per}");
            Console.WriteLine($"ar={ar}");
            return "hi\n";
        }
        static string Q7()
        {
            int A = 10;
            int B = 20;
            Console.WriteLine("A: {0}\n B: {1}", A, B);
            int C = A;
            A = B;
            B = C;
            Console.WriteLine($"A {A}\n B {B}");
            return "hl\n;";
        }
        static string Q8()
        {
            int[] arr = new int[100];
            Random rand = new Random();
            for (int j = 0; j < 100; j++)
            {
                arr[j] = rand.Next(1000, 9999);

            }
            for (int j = 1; j <= arr.Length; j++)
            {
                Console.Write(arr[j - 1] + "\t\t\t");
                if (j % 2 == 0)
                    Console.WriteLine();
                return "hk\n;";

            }
            return "hk\n;";
        }

    }
}
