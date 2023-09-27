using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спираль";
            Console.Write("Введите размер: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,] spiral = new int[n, n];
            int border = n;
            int border2 = -1;
            int j = 0;
            int h = 0;
            string direction = "right";
            for (int i = 0; i < n * n; i++)
            {
                switch (direction)
                {
                    case "right":
                        spiral[j, h] = i + 1;
                        h++;
                        if (h == border)
                        { 
                            direction = "down"; 
                            h = h - 1;
                            j = j + 1;
                        }
                        break;
                    case "down":
                        spiral[j, h] = i + 1;
                        j++;
                        if (j == border)
                        {
                            direction = "left";
                            j = j - 1;
                            h = h - 1;
                            border = border - 1;
                        }
                        break;
                    case "left":
                        spiral[j, h] = i + 1;
                        h--;
                        if (h == border2)
                        {
                            direction = "up";
                            h = h + 1;
                            j = j - 1;
                            border2 = border2 + 1;
                        }
                        break;
                    case "up":
                        spiral[j, h] = i + 1;
                        j--;
                        if (j == border2)
                        {
                            direction = "right";
                            j = j + 1;
                            h = h + 1;
                        }
                        break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int u = 0; u < n; u++)
                {
                    if (spiral[i, u] < 10)
                        Console.Write($"{spiral[i, u]}    ");
                    else if (spiral[i, u] < 100)
                        Console.Write($"{spiral[i, u]}   ");
                    else
                        Console.Write($"{spiral[i, u]}  ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
