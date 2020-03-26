using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Assessment
{
    class Program
    { 
        static void Main(string[] args)
        {
            method();
           
        }
        static void method()
        {
            string rejectMessage = "FINAL RESULT REJECT";
            string approveMessage = "FINAL RESULT APPROVE";
            int noCount = 1;
            int yescount = 0;

            //All the country voting
            // Each country with it population percentage
            // Using coutry class properties to creat coutry also it object
            Country country1 = new Country()
            {
                CountryName = "Austria",
                CountryPercentage = 1.98

            };
            Country country2 = new Country()
            {
                CountryName = "Belgium",
                CountryPercentage = 2.56
            };
            Country country3 = new Country()
            {
                CountryName = "Bulgaria",
                CountryPercentage = 1.56
            };
            Country country4 = new Country()
            {
                CountryName = "Croatia",
                CountryPercentage = 0.91
            };
            Country country5 = new Country()
            {
                CountryName = "Cyprus",
                CountryPercentage = 0.20
            };
            Country country6 = new Country()
            {
                CountryName = "Czech Republic",
                CountryPercentage = 2.35
            };
            Country country7 = new Country()
            {
                CountryName = "Denmark",
                CountryPercentage = 1.30
            };
            Country country8 = new Country()
            {
                CountryName = "Estonia",
                CountryPercentage = 0.30
            };
            Country country9 = new Country()
            {
                CountryName = "Finland",
                CountryPercentage = 1.23
            };
            Country country10 = new Country()
            {
                CountryName = "France",
                CountryPercentage = 14.98
            };
            Country country11 = new Country()
            {
                CountryName = "Germany",
                CountryPercentage = 18.54
            };
            Country country12 = new Country()
            {
                CountryName = "Greece",
                CountryPercentage = 2.40
            };
            Country country13 = new Country()
            {
                CountryName = "Hungary",
                CountryPercentage = 2.18
            };
            Country country14 = new Country()
            {
                CountryName = "Ireland",
                CountryPercentage = 1.10
            };
            Country country15 = new Country()
            {
                CountryName = "Italy",
                CountryPercentage = 13.65
            };
            Country country16 = new Country()
            {
                CountryName = "Latvia",
                CountryPercentage = 0.43
            };
            Country country17 = new Country()
            {
                CountryName = "Lithuania",
                CountryPercentage = 0.62
            };
            Country country18 = new Country()
            {
                CountryName = "Luxembourg",
                CountryPercentage = 0.14
            };
            Country country19 = new Country()
            {
                CountryName = "Malta",
                CountryPercentage = 0.11
            };
            Country country20 = new Country()
            {
                CountryName = "NetherLand",
                CountryPercentage = 3.89
            };
            Country country21 = new Country()
            {
                CountryName = "Poland",
                CountryPercentage = 8.49
            };
            Country country22 = new Country()
            {
                CountryName = "Portugal",
                CountryPercentage = 2.30
            };
            Country country23 = new Country()
            {
                CountryName = "Romania",
                CountryPercentage = 4.34
            };
            Country country24 = new Country()
            {
                CountryName = "Slovakia",
                CountryPercentage = 1.22
            };
            Country country25 = new Country()
            {
                CountryName = "Slovenia",
                CountryPercentage = 0.47
            };
            Country country26 = new Country()
            {
                CountryName = "Spain",
                CountryPercentage = 10.49
            };
            Country country27 = new Country()
            {
                CountryName = "Sweden",
                CountryPercentage = 2.29

            };

            List<Country> list = new List<Country>();

            foreach (Country o in list)
            {
                Console.WriteLine(o);
            }
            double total = Math.Round(country1.CountryPercentage + country2.CountryPercentage + country3.CountryPercentage + country4.CountryPercentage + country5.CountryPercentage + country6.CountryPercentage + country7.CountryPercentage + country8.CountryPercentage + country9.CountryPercentage + country10.CountryPercentage + country11.CountryPercentage + country12.CountryPercentage + country13.CountryPercentage + country14.CountryPercentage + country15.CountryPercentage + country16.CountryPercentage + country17.CountryPercentage + country18.CountryPercentage + country19.CountryPercentage + country20.CountryPercentage + country21.CountryPercentage + country22.CountryPercentage + country23.CountryPercentage + country24.CountryPercentage + country25.CountryPercentage + country26.CountryPercentage + country27.CountryPercentage, 2);
            //double totalRounded = Math.Round(total, 2);
            //  Console.WriteLine(total);

            country1.Output();
            string userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country1.CountryPercentage;
                noCount++;
            }

            country2.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country2.CountryPercentage;
                noCount++;
            }


            country3.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country3.CountryPercentage;
            }

            country4.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country4.CountryPercentage;
                noCount++;
            }
            country5.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country5.CountryPercentage;
                noCount++;
            }

            country6.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country6.CountryPercentage;
                noCount++;
            }

            country7.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country7.CountryPercentage;
                noCount++;
            }

            country8.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country8.CountryPercentage;
                noCount++;
            }

            country9.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country9.CountryPercentage;
                noCount++;
            }

            country10.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country10.CountryPercentage;
                noCount++;
            }

            country11.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country11.CountryPercentage;
                noCount++;
            }

            country12.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country12.CountryPercentage;
                noCount++;
            }

            country13.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country13.CountryPercentage;
            }

            country14.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country14.CountryPercentage;
                noCount++;
            }

            country15.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country15.CountryPercentage;
                noCount++;
            }

            country16.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country16.CountryPercentage;
            }

            country17.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country17.CountryPercentage;
                noCount++;
            }

            country18.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country18.CountryPercentage;
                noCount++;
            }

            country19.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country19.CountryPercentage;
                noCount++;
            }
            country20.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country20.CountryPercentage;
                noCount++;
            }

            country21.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country21.CountryPercentage;
                noCount++;
            }
            country22.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country22.CountryPercentage;
                noCount++;
            }

            country23.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country23.CountryPercentage;
                noCount++;
            }

            country24.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country24.CountryPercentage;
                noCount++;
            }

            country25.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country25.CountryPercentage;
                noCount++;
            }

            country26.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country26.CountryPercentage;
                noCount++;
            }

            country27.Output();
            userInput = Console.ReadLine();
            if (userInput == "no")
            {
                total = total - country27.CountryPercentage;
            }

            // The if statement to check if to approve the votes or reject them 
            if ((total > 65) && (noCount < 12))
            {
                Console.WriteLine($"{approveMessage} total:{total} No:{noCount} yes: {yescount}");
            }
            else if ((total < 65) && (noCount > 12))
            {
                Console.WriteLine($"{rejectMessage} total:{total} No:{noCount}");
            }
            else
            {
                Console.WriteLine($"{rejectMessage} total:{total} No:{noCount}");
            }
        }
    }
}
