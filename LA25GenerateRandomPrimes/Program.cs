using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace LA25GenerateRandomPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== LA 25 Generate Random Primes (Method overrides)====\n");
            PrimeGenerator primeAB1 = new PrimeGenerator();

            Console.Write("Overloaded Method 1: No parameter. \nA generated random prime: ");
            primeAB1.GenPrimeNo();
            Console.WriteLine("\n=======================================");

            Console.Write("\nOverloaded Method 2: 1 parameter. " +
                "\nInput how many random primes do you want to display?: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("The {0} generated random primes: ", n);
            primeAB1.GenPrimeNo(n);
            Console.WriteLine("\n=======================================");

            Console.Write("\nOverloaded Method 3: 2 parameters. \nInput a lower range for random primes: ");
            int lowerR = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input an upper range: ");
            int upperR = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("All primes in the range: {0} to {1}:", lowerR, upperR);
            primeAB1.GenPrimeNo(lowerR, upperR);
            Console.WriteLine("\n=============================================");

            Console.Write("\nOverloaded Method 4: 3 parameters. \nHow many primes do you want to display?: ");
            int noOfPrime = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a lower range: ");
            int lowerR1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input an upper range: ");
            int upperR1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first {0} primes in the range: {1} to {2}:",noOfPrime, lowerR1, upperR1);
            primeAB1.GenPrimeNo(noOfPrime,lowerR1,upperR1);

            //int a = primeAB1.// override object.Equals
    

            Console.WriteLine("\n\n=================== Press Any Key to Exit ===================");
            
            
            Console.ReadLine();
        }
        /*Create a classes with overloaded methods to represent a Prime Generator.
        1. Create a method to determine if a number is a prime, and four overloaded methods to generate primes.
        2. Method without a parameter should generate and display a random prime, method with one integer parameter n will generate and display n random primes, method with two integer parameters (a, b; a<=b) will generate all primes in the range(a, b), and method with three integer parameters(c, a, b; c>=1, a<=b) will generate and display the first c primes(if exists) in the range(a, b).
        3. Complete all the incomplete methods from the class. And do not alter the Program class.
        Sample Input/Output:
        prime

        Random Prime: 61
        prime 5 5

        Random Primes: 787 863 659 277 739
        prime 10  20

        All primes in the range 10 to 20: 11 13 17 19
        prime 5 100 200 First 5 Primes in range 100 to 200: 101 103 107 109 113*/
    }
}
