using System;

namespace ProblemSolving
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(0)); 




        }

        public static bool IsPalindrome(int x)
        {
            var copy = x;
            int remainder;
            long reverse = 0;

            if (x <= 0)
            {
                return false;
            }
            else
            {
                 while (x > 0)
                    {
                        remainder = x % 10;
                        reverse = reverse * 10 + remainder;
                        x /= 10;
                    }

                 if(reverse == copy)
                {
                    return true;
                }
                else
                {
                    return false;

                }
                
            }
        }

    }
}
