using System;
using System.Collections.Generic;
using System.Text;

namespace TeamProjectArray
{
    class Project2
    {
        static void Main()
        {
            Console.WriteLine("Please enter the size of array: ");

            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            int[] ar = new int[a * a];

            for (int i = 0; i < a * a; i++)
            {
                ar[i] = 0;
            }
            ar[(a * a) - (a)] = 1;
            int t;
            t = 0;
            for (int i = 0; i < a * a; i++)
            {
                if (t == a)
                {
                    t = 0;
                    Console.WriteLine("");
                }
                t += 1;
                Console.Write(ar[i]);
            }

            int q = 1;
            int n;
            int r, c;

            Console.WriteLine("");
            while (q == 1)
            {
                Console.WriteLine("Enter the integer values as below: ");
                Console.Write(" =>2 for UP<= ");
                Console.Write(" => 4 for LEFT<= ");
                Console.Write(" =>6 for Right<= ");
                Console.Write(" =>8 for Down<= ");
                Console.Write(" =>0 for Exit<= ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 0)
                {
                    q = 0;
                }
                else
                {
                    r = 0;
                    c = 0;
                    for (int i = 0; i < a * a; i++)
                    {
                        if (ar[i] == 1)
                        {
                            r = i;
                        }
                    }
                    if (n == 2)
                    {
                        if ((r >= 0) && (r < a))
                        {
                            ar[r] = 1;
                        }
                        else
                        {
                            ar[r] = 0;
                            ar[r - a] = 1;
                        }
                    }
                    else if (n == 8)
                    {
                        if (r >= (a * a - a))
                        {
                            ar[r] = 1;
                        }
                        else
                        {
                            ar[r] = 0;
                            ar[r + a] = 1;
                        }
                    }
                    else if (n == 4)
                    {
                        if ((r == 0) || (r % a == 0))
                        {
                            ar[r] = 1;
                        }
                        else
                        {
                            ar[r] = 0;
                            ar[r - 1] = 1;
                        }
                    }
                    else if (n == 6)
                    {
                        if (r == 0)
                        {
                            ar[r] = 0;
                            ar[r + 1] = 1;
                        }
                        else if ((r == a - 1) || ((r + 1) % a == 0))
                        {
                            ar[r] = 1;
                        }
                        else
                        {
                            ar[r] = 0;
                            ar[r + 1] = 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have entered wrong key ");
                    }

                    for (int i = 0; i < a * a; i++)
                    {
                        if (t == a)
                        {
                            t = 0;
                            Console.WriteLine("");
                        }
                        t += 1;
                        Console.Write(ar[i]);
                    }

                }
            }
        }
    }

}


   
