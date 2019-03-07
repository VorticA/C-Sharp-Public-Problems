using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///*Да се състави програма на C++, чрез която се въвежда естествено число N от интервала [12..1234567].
//Програмата да извежда число, чиито цифри са написани в ред обратен на въведеното число.
//Да не се въвеждат числа кратни на 10. Да се извежда съобщение дали въведеното число е палиндром.
//Пример: 12321 Изход: 12321 да.
//Използвайте рекурсия*/
//namespace Never_Gonna
//{
//    class give_you_up
//    {
//        static void F(string K)
//        {

//        }

//        static void Main()
//        {
//            string N = Console.ReadLine();
//            Console.WriteLine(N.Reverse().ToString());
//        }
//    }
//}



namespace AscendingHours
{
    class Program
    {
        static void Reverse(char[] A , int start, int end)
        {
            if (start < end)
            {
                char swap;
                swap = A[start];
                A[start] = A[end];
                A[end] = swap;
                Reverse(A, start + 1, end - 1);
            }
            else
            {
                Console.WriteLine(string.Join("" , A));
                return;
            }
        }
        static void Main()
        {
            string N = Console.ReadLine();
            Reverse(N.ToCharArray(), 0, N.Length - 1);
        }
    }
}
