// Simple c# program to demonstrate the concept of costum exceptation
using System;
using System.Collections.Generic;
namespace Ncit_Nishan
{
    public class balanceIsZeroException : Exception
    {
        public balanceIsZeroException(string message) : base(message) { }
    }
    public class balance
    {
        public void showBalance(long amount)
        {
            if (amount < 0)
            {
                throw (new balanceIsZeroException("Balance cannot be less than zero or negative"));
            }
            else
            {
                Console.WriteLine("The balance in your account is ::" + amount);
            }
        }
    }
    internal class CostumException
    {
        static void Main(string[] args)
        {
            balance b1 = new balance();
            try
            {
                Console.WriteLine("Enter the Balance :: ");
                long a = Convert.ToInt32(Console.ReadLine());
                b1.showBalance(a);
            }
            catch (balanceIsZeroException e)
            {
                Console.WriteLine("Balance is Zero or less {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Finally we are out of exceptation");
            }
        }
    }
}