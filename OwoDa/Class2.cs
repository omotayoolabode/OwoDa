using System;

namespace OwoDa
{



    internal class Class2
    {

        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine("Welcome to Owoda. \n Please enter your First name :");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome {0}, what type of vehicle do you drive? \n Bus: 1 \n Tricycle; 2 \n Minibus; 3 \n Bike; 4", name);
            int carType = Convert.ToInt32(Console.ReadLine());
            int x;
            if (carType == 1)
            {
                x = 1000;
            }
            else if (carType == 2)
            {
                x = 500;
            }
            else if (carType == 3)
            {
                x = 700;
            }
            else if (carType == 4)
            {
                x = 300;
            }
            else
            {
                x = 0;
            }
            Console.WriteLine("Please enter the number of trips");
            int numberofTrips = Convert.ToInt32(Console.ReadLine());

            int answer = class1.Amount(x, numberofTrips);
            Console.WriteLine(answer);
            Console.WriteLine("Are you a member of the association? (Yes/No)");
            string unionStatus = Console.ReadLine();
            string unionStatusLower = unionStatus.ToLower();
            if (unionStatusLower == "yes")
            {
                int answer2 = (int)class1.discount(answer);
                Console.WriteLine("Hello {0}, you made {1} trips and your toll is {2}. You have qualified for a discount, your new toll is {3}", name, numberofTrips, answer, answer2);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Hello {0}, you made {1} trips and your toll is {2}", name, numberofTrips, answer);
            }

        }
    }
}
