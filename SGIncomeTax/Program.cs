using System;

namespace SGIncomeTax
{
    class Program
    {
        /*
         Singpaore Income Tax Calculator can be found here:
         https://www.iras.gov.sg/irashome/Individuals/Locals/Working-Out-Your-Taxes/Income-Tax-Rates/
         */
        static void Main(string[] args)
        {
            string resident;
            bool needToPayTax = true;

            Console.WriteLine("Hello! Welcome to the Singapore Income Tax Calculator for employees!");
            while (needToPayTax == true)
            {
                Console.WriteLine("\nAre you a Singapore citizen, Singapore PR, or a foreigner employed in Singapore for at least 183 days? (yes/no)");
                resident = Console.ReadLine();
                resident.ToLower();
                if (resident == "yes" || resident == "y")
                {
                    ResidentTaxCalculation(); // run method for residents
                    needToPayTax = false; // break out of while loop
                }
                else if (resident == "no" || resident == "n")
                {
                    NonResidentTaxCalculation(); // run method for non-residents
                    needToPayTax = false; // break out of while loop 
                }
                else
                {
                    Console.WriteLine("Invalid input. Please input yes or no.");
                    needToPayTax = true;
                }
            }
        }
        // ** METHODS() **

        // A. create nonResidentTaxCalculation() method
        static void NonResidentTaxCalculation()
        {
            double grossIncome;
            double flatTaxRate = 0.15; // ** see how to make this a constant later; unchangeable
            double taxAmountDue;
            double netIncome;

            Console.WriteLine("Please input your gross income for the year.");
            bool parsedSuccessfully = double.TryParse(Console.ReadLine(), out grossIncome);

            if (parsedSuccessfully == true)
            {
                taxAmountDue = flatTaxRate * grossIncome;
                netIncome = grossIncome - taxAmountDue;
            }
            else
            {
                while (parsedSuccessfully == false)
                {
                    Console.WriteLine("Please input a number only.");
                    parsedSuccessfully = double.TryParse(Console.ReadLine(), out grossIncome);
                }
                taxAmountDue = flatTaxRate * grossIncome;
                netIncome = grossIncome - taxAmountDue;
            }
            Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
        }
        // B. create ResidentTaxCalculation() method
        static void ResidentTaxCalculation()
        {
            double grossIncome;
            double taxAmountDue;
            double netIncome;

            Console.WriteLine("Please input your gross income for the year.");
            bool parsedSuccessfully = double.TryParse(Console.ReadLine(), out grossIncome);

            if (parsedSuccessfully == true)
            {
                if (grossIncome <= 20000)
                {
                    taxAmountDue = 20000 * 0;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome <= 30000)
                {
                    taxAmountDue = 20000 * 0 + (grossIncome - 20000) * 0.02;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome <= 40000)
                {
                    taxAmountDue = 200 + (grossIncome - 30000) * 0.035;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome <= 80000)
                {
                    taxAmountDue = 550 + (grossIncome - 40000) * 0.07;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome <= 120000)
                {
                    taxAmountDue = 3350 + (grossIncome - 80000) * 0.115;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome <= 160000)
                {
                    taxAmountDue = 7950 + (grossIncome - 120000) * 0.15;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome <= 200000)
                {
                    taxAmountDue = 13950 + (grossIncome - 160000) * 0.18;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome <= 240000)
                {
                    taxAmountDue = 21150 + (grossIncome - 200000) * 0.19;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome <= 280000)
                {
                    taxAmountDue = 28750 + (grossIncome - 240000) * 0.195;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome <= 320000)
                {
                    taxAmountDue = 36550 + (grossIncome - 280000) * 0.2;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome >= 320000)
                {
                    taxAmountDue = 44550 + (grossIncome - 320000) * 0.22;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
            }
            else // I.e., user did not input a number for his annual salary. parsedSuccessfully == false.
            {
                while (parsedSuccessfully == false)
                {
                    Console.WriteLine("Please input a number only.");
                    parsedSuccessfully = double.TryParse(Console.ReadLine(), out grossIncome);
                }
                if (grossIncome <= 20000)
                {
                    taxAmountDue = 20000 * 0;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome <= 30000)
                {
                    taxAmountDue = 20000 * 0 + (grossIncome - 20000) * 0.02;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome <= 40000)
                {
                    taxAmountDue = 200 + (grossIncome - 30000) * 0.035;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome <= 80000)
                {
                    taxAmountDue = 550 + (grossIncome - 40000) * 0.07;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome <= 120000)
                {
                    taxAmountDue = 3350 + (grossIncome - 80000) * 0.115;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome <= 160000)
                {
                    taxAmountDue = 7950 + (grossIncome - 120000) * 0.15;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome <= 200000)
                {
                    taxAmountDue = 13950 + (grossIncome - 160000) * 0.18;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome <= 240000)
                {
                    taxAmountDue = 21150 + (grossIncome - 200000) * 0.19;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome <= 280000)
                {
                    taxAmountDue = 28750 + (grossIncome - 240000) * 0.195;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome <= 320000)
                {
                    taxAmountDue = 36550 + (grossIncome - 280000) * 0.2;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
                else if (grossIncome >= 320000)
                {
                    taxAmountDue = 44550 + (grossIncome - 320000) * 0.22;
                    netIncome = grossIncome - taxAmountDue;
                    Console.WriteLine("\nYour tax amount due is {0} and your net income is {1}", taxAmountDue, netIncome);
                }
            }
        }
    }
}
