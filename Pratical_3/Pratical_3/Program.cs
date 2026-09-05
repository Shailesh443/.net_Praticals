using System;

namespace Pratical_3
{
    class Expense
    {
        public int ExpenseId;
        public string ExpenseName;
        public string Category;
        public double Amount;
        public string Details;

        public void Display()
        {
            Console.WriteLine("\nExpense ID : " + ExpenseId);
            Console.WriteLine("Name       : " + ExpenseName);
            Console.WriteLine("Category   : " + Category);
            Console.WriteLine("Amount     : " + Amount);
            Console.WriteLine("Details    : " + Details);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Expense e = new Expense();

            try
            {
                Console.Write("Enter Expense ID: ");
                e.ExpenseId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Expense Name: ");
                e.ExpenseName = Console.ReadLine();

                Console.Write("Enter Category: ");
                e.Category = Console.ReadLine();

                Console.Write("Enter Amount: ");
                e.Amount = Convert.ToDouble(Console.ReadLine());

                if (e.Amount <= 0)
                    throw new Exception("Invalid Amount!");

                Console.Write("Enter Details: ");
                e.Details = Console.ReadLine();

                e.Display();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}