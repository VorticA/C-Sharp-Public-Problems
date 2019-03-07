using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueens
{
    class Program
    {
        static int[,] Board = new int[8, 8];
        static void Solve(int row)
        {
            if (row>=8)
            {
                PrintMatrix();
                return;
            }
            else
            {
                for (int col=0; col<8; col++)
                {
                    if (Board[row, col] == 0)
                    {
                        Attack(row, col);
                        Solve(row + 1);
                        UnAttack(row, col);
                    }
                }
            }
        }

        private static void PrintMatrix()
        {
            for (int row = 0; row<8; row++)
            {
                for (int col=0; col<8; col++)
                {
                    if (Board[row, col] < 8) Console.Write("- ");
                    else Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void UnAttack(int qRow, int qCol)
        {
            Board[qRow, qCol] -= 3;
            int i, j;
            for (i = 0; i < 8; i++)
                Board[qRow, i]--;
            for (i = 0; i < 8; i++)
                Board[i, qCol]--;

            i = qRow;
            j = qCol;
            while (i < 8 && j < 8)
            {
                Board[i, j]--;
                i++;
                j++;
            }

            i = qRow;
            j = qCol;
            while (i < 8 && j >= 0)
            {
                Board[i, j]--;
                i++;
                j--;
            }

            i = qRow;
            j = qCol;
            while (i >= 0 && j < 8)
            {
                Board[i, j]--;
                i--;
                j++;
            }

            i = qRow;
            j = qCol;
            while (i >= 0 && j >= 0)
            {
                Board[i, j]--;
                i--;
                j--;
            }
        }

        private static void Attack(int qRow, int qCol)
        {
            Board[qRow, qCol] += 3;
            int i, j;
            for (i = 0; i < 8; i++)
                Board[qRow, i]++;
            for (i = 0; i < 8; i++)
                Board[i, qCol]++;

            i = qRow;
            j = qCol;
            while(i<8 && j<8)
            {
                Board[i, j]++;
                i++;
                j++;
            }

            i = qRow;
            j = qCol;
            while (i < 8 && j >= 0)
            {
                Board[i, j]++;
                i++;
                j--;
            }

            i = qRow;
            j = qCol;
            while (i >= 0 && j < 8)
            {
                Board[i, j]++;
                i--;
                j++;
            }

            i = qRow;
            j = qCol;
            while (i >= 0 && j >= 0)
            {
                Board[i, j]++;
                i--;
                j--;
            }
        }

        static void Main(string[] args)
        {
            Solve(0);
            Console.ReadKey();
        }
    }
}
