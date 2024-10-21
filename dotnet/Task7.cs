using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet
{
    public class Task7
    {
        public int Divide(int a, int b)
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Arguments cannot be zero");
                }
                return a / b;
            }
            catch (Exception)
            {
                throw new Exception("Cannot be divided");
            }

        }

        public void ProcessNumbers(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty or null");
            }
            for (int i = 0; i <= numbers.Length; i++)
            {
                var result = Divide(numbers[i], 2);
                Console.WriteLine("Result: " + result);
            }
        }
    }
}
