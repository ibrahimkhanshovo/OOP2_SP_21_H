﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array02
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] arr1 = new int[100];
                int[] arr2 = new int[100];
                int[] arr3 = new int[100];
                int s1, s2, mm = 1, ctr = 0;
                int i, j;
                Console.Write("Count total number \n");
                Console.Write("-\n");

                Console.Write("Input :");
                s1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input \n", s1);
                for (i = 0; i < s1; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }
                
                for (i = 0; i < s1; i++)
                {
                    arr2[i] = arr1[i];
                    arr3[i] = 0;
                }
               
                for (i = 0; i < s1; i++)
                {
                    for (j = 0; j < s1; j++)
                    {
                        if (arr1[i] == arr2[j])
                        {
                            arr3[j] = mm;
                            mm++;
                        }
                    }
                    mm = 1;
                }
                
                for (i = 0; i < s1; i++)
                {
                    if (arr3[i] == 2) { ctr++; }
                }
                Console.Write(" : {0} \n", ctr);

                Console.Write("\n\n");
            }
        }
    }
    }
}
