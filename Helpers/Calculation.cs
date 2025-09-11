using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp
{
    class Calculation
    {
        string message;
        int count;

        public Calculation()
        {
            Object number1 = 2;
            Object number2 = "two";
            Add(number1, number2);

            Object number3 = 2;
            Object number4 = null;
            Divide(number3, number4);
        }


        /// <summary>
        /// Adds two numeric objects after converting them to integers and outputs the result to the console.
        /// </summary>
        /// <param name="number1">The first number to be added, expected to be convertible to an integer.</param>
        /// <param name="number2">The second number to be added, expected to be convertible to an integer.</param>
        /// <example>
        /// Add(2, "3"); // Console output: Add(2, 'three') result = 5
        /// </example
        public void Add(object number1, object number2)
        {
            try
            {
                //var result = Convert.ToInt32(number1) + Convert.ToInt32(number2);

                var result = Convert.ToInt32(number1);
                result += Convert.ToInt32(number2);

                Console.WriteLine("Add(2, 'two') result = " + result);
                Console.ReadLine();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void Divide(object number1, object number2)
        {
            var result = Convert.ToInt32(number1) / 0;
            Console.WriteLine("Divide(2, 0) result = Convert.ToInt32(" + result);
            Console.ReadLine();
        }

        public void TestAdd()
        {
            int x = 4;
            string y = "12";

            Console.WriteLine(string.Format("{0}", x + y)); // 412
            Console.ReadKey();
        }


        /// <summary>
        /// Calculates the total tax for customers from Florida based on their balance.
        /// </summary>
        /// <remarks>
        /// This method iterates through a list of customers and adds up the balance of those located in Florida to calculate the total tax.
        /// </remarks>
        /// <example>
        /// TaxCalc();
        /// </example>
        private void TaxCalc()
        {
            List<CustomerModel> CustomerList = new List<CustomerModel>();
            double tax = 0;

            //tax += CustomerList[0].Balance;
            //tax += CustomerList[1].Balance;
            //tax += CustomerList[2].Balance;

            foreach (CustomerModel customer in CustomerList)
            {
                if (customer.State == "FL")
                {
                    tax += customer.Balance;
                }
            }
        }

    }

    public class CustomerModel
    {
        public string State;
        public double Balance;
    }


}
