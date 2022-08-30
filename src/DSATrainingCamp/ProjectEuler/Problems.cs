﻿

using System;
using System.Net.Http.Headers;

namespace ProjectEuler
{
    public class Problems
    {
        /* Multiples of 3 or 5
           If we list all the natural numbers below 10 that are multiples of 3 or 5, 
           we get 3, 5, 6 and 9. The sum of these multiples is 23.
           Find the sum of all the multiples of 3 or 5 below 1000. */
        public static int MultiplesOf3And5(int ceiling)
        {
            var result = 0;

            for (var i = ceiling - 1; i > 0; i--)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }

            return result;
        }

        /* Even Fibonacci numbers
           Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
           1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
           By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms. */
        public static int EvenFibonacciNumbers(int ceiling)
        {
            var previousTerm = 1;
            var nextTerm = 2;
            var result = 0;

            while (nextTerm <= ceiling)
            {
                if (nextTerm % 2 == 0)
                {
                    result += nextTerm;
                }

                int tempTerm = nextTerm;
                nextTerm += previousTerm;
                previousTerm = tempTerm;
            }

            return result;
        }

        /* Largest prime factor
        The prime factors of 13195 are 5, 7, 13 and 29.
        What is the largest prime factor of the number 600851475143 ? */
        public static long LargestPrimeFactor(long n)
        {
            /*  The simplest algorithm to find the prime factors of a number is to keep on dividing the original
            number by prime factors until we get the remainder equal to 1. */

            var factors = new List<long>();

            for (var f = 2; n > 1; f++)  // 2 is the first prime factor so start there
            {
                if (n % f == 0)
                {
                    factors.Add(f);
                    n /= f;
                }
            }

            return factors.Max();
        }

        /* Largest palindrome product
        A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        Find the largest palindrome made from the product of two 3-digit numbers.*/
        public static int LargestPalindromeProduct()
        {
            int firstDigit = 999, secondDigit = 999, product = 0;


            for (var i = firstDigit; i > 99; i--)
            {
                product = i * secondDigit;

                if (IsPalindrome(product))
                {
                    return product;
                }

                for (var j = secondDigit; j > 99; j--)
                {
                    product = i * j;

                    if (IsPalindrome(product))
                    {
                        return product;
                    }
                }
            }

            return 0;
        }

        private static bool IsPalindrome(int num)
        {
            int tempValue = num;
            int reverse = 0;
            while (tempValue > 0)
            {
                reverse = reverse * 10 + tempValue % 10;
                tempValue = tempValue / 10;
            }

            return reverse == num;
        }
    }
}