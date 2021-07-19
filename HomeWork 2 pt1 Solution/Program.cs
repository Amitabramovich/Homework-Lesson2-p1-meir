using System;

namespace HomeWork_2_pt1_Solution_Meir
{
    class Program
    {
        static void Main(string[] args)
        {
            #region q1
            for (int i = 2; i < 22; i += 2)
                Console.WriteLine(i);
            #endregion
            #region q2
            int sum = 0;
            for (int i = 1; i < 6; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sum += a;
                if (i == 5)
                    Console.WriteLine("Avrage is: {0}", sum / 5);
            }
            #endregion
            #region q3
            int a;
            int b;
            do
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

                if (a == 0 || b == 0)
                {
                    continue;
                }
                else if (a < 0 || b < 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(a + b);
                    Console.WriteLine(a * b);
                }


            } while (true);
            #endregion
            #region q4
            for (int a = 9; a <= 9; a--)
            {
                for (int j = 0; j <= a; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
            #endregion
            #region q5
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write((i * j) + "\t");
                }
                Console.WriteLine(" ");
            }
            #endregion
            #region while q1
            int x = int.Parse(Console.ReadLine());
            int inerNum = 0;
            while (x < 20)
            {
                x++;
                inerNum++;
                Console.WriteLine(x);
            }
            Console.WriteLine(inerNum);
            #endregion
            #region break q1
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= (x * 2); i++)
            {
                if (i == 1)
                {
                    continue;
                }
                else if (i > 10)
                {
                    break;
                }
                else if (i == (x * 2))
                {
                    Console.WriteLine(i);
                    Console.WriteLine("END");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            #endregion
            #region break q2
            int num;
            int counter = 0;
            while (true)
            {
                num = int.Parse(Console.ReadLine());
                counter++;
                if (num == 23)
                {
                    break;
                }
            }
            Console.WriteLine("Looped {0} times", counter);
            #endregion
            #region break challenge
            int num;
            int counter = 0;
            while (true)
            {
                num = int.Parse(Console.ReadLine());
                counter++;
                if (num == 23)
                {
                    Console.WriteLine("Do you wanna exit the loop?");
                    string answer = Console.ReadLine();
                    if (answer == "Y" || answer == "y")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Loop continues");
                    }
                }
            }
            Console.WriteLine("Looped {0} times", counter);
            #endregion

        }
    }
}
