using System;
namespace Assessment
{
    public class Country
    {
   
        public string CountryName { get; set; }
        public double CountryPercentage { get; set; }

        public void Output()
        {
            Console.WriteLine($"{CountryName}, {CountryPercentage} Yes, No, Abstain");
        }
    }
}
