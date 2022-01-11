using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LA25GenerateRandomPrimes
{
    class PrimeGenerator
    {
        public void GenPrimeNo() //Print 1 random prime
        {
            bool isPrime = false;
            int x;
            do
            {
                Random randA = new Random();
                x = randA.Next(0,10000);
                if (x <= 1)
                {
                    isPrime = false;
                }
                for (int i = 2; i*i < x; i++)
                {
                    if (x % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    for(int j =2; j*j<x; j++)
                    {
                        if (x % i != 0)
                        isPrime = true;
                    }
                }
                
            } while (isPrime == false);
            Console.Write(x + " ");
        }
        public void GenPrimeNo(int n) //Print n random primes
        {
            for (int k = 0; k < n; k++)
            {
                //Thread.Sleep(100);
                GenPrimeNo();
            }
        }
        public void GenPrimeNo(int a, int b) // a<=b
        {
            for (int i = a; i <= b; i++)
            {
                int divisor = 0;
                if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            divisor = 1;
                            break;
                        }
                    }
                    if (divisor == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
        public void GenPrimeNo(int c, int a, int b) // c>=1, a<=b, print 1st c primes in range (a,b)
        {
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                int divisor = 0;
                if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            divisor = 1;
                            break;
                        }
                    }
                    if (divisor == 0 && count < c)
                    {
                        Console.Write(i + " ");
                        count = count + 1;

                    }
                }
            }
            if (count < c)
            {
                Console.WriteLine("\n!!!There are only {0} primes in the range you have selected.!!! \nPlease select a bigger range", count);
            }

        }
    }
}
