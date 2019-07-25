using System;
using System.Collections.Generic;

namespace IsPolindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isPolindrom(11211));
        }

//with string
        static bool IsPolindrom(int i)
        {
            string str = "";
            while (i % 10 != 0)
            {
                str += i % 10;
                i /= 10;
            }

            int index = str.Length - 1;

            for (int j = 0; j < str.Length / 2; ++j)
            {

                if (str[j] != str[index])
                    return false;
                index--;
            }
            
            return true;
        }
 // with single loop
 static bool isPolindrom(int num)
 {
     int originalNum = num;
     int i = 0;
     while (num % 10 != 0)
     {
         i = i * 10 + num % 10;
         num /= 10;
     }
     if (i == originalNum)
         return true;
     return false;

 }

    }

}