using System;
using System.Collections.Generic;


namespace school_assignments
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Enter package weight: ");

			try
			{
            	decimal packageWeight = Convert.ToDecimal(Console.ReadLine());  // Using decimal prevents floating point arithmetic wonkiness

				Console.WriteLine(CalculateCharge(packageWeight));  // Call CalculateCharge and print the results.
			}

			catch (FormatException)  // If they enter anything but a decimal or int, let them know and restart
			{
				Console.WriteLine("Format Exception: Please only enter integers or decimals.");
				Main(args);
			}
        }

        public static string CalculateCharge(decimal packageWeight)
        {
            var shippingRates = new Dictionary<decimal, decimal>    // shippingRates = {Weight, Cost}
            {
                {2.0m, 1.1m},  	  // >=2lbs, $1.10/lb
                {6.0m, 2.2m},	 //    6lbs, $2.20/lb
                {10.0m, 3.7m}	//    10lbs, $3.70/lb
            };				   //    <10lbs, $3.80/lb  |  Handled in elif statement

            if (packageWeight > 10) 
            {
                return ("Total: $" + (packageWeight * 3.80m));	// Max shipping rate.
            }

            else
            { 
                foreach (KeyValuePair<decimal, decimal> entry in shippingRates) // For each shippingRate        
                {
                    if (packageWeight <= entry.Key) // Check if packageWeight falls under that rate
                    {
                        return ("Total: $" + (packageWeight * entry.Value));  // entry.Value is the shipping cost
                    }
                }
            }
			return "false";
        }
    }
}
