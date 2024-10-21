using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet
{
    public class Calculations
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the hourly rate");
                var hourlyRate = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the hours worked");
                var hoursWorked = int.Parse(Console.ReadLine());

                if (hourlyRate < 0 || hoursWorked < 0)
                {
                    throw new ArgumentOutOfRangeException("Value is non negative");
                }
                double regularPay = hourlyRate * 40;

                if (hoursWorked > 40)
                {
                    double overTimePay = 1.5 * regularPay;
                    Console.WriteLine("Gross overtime pay is: ${0}", overTimePay);
                    Console.WriteLine("Tax for overtime pay is: ${0}", overTimePay * .20);
                }
                else
                {
                    Console.WriteLine("Gross regular pay is: ${0}", regularPay);
                    Console.WriteLine("Tax for regular pay is: ${0}", regularPay * .20);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input is non-numeric", ex);
            }
        }
    }
}

