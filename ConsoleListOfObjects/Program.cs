using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleListOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            bool validResponse = false;
            bool continueAdding = true;

            string userResponse;
            int year;
            double engine;
            PersonCar.MakeName carMake;

            PersonCar newPersonCar = new PersonCar();

            List<PersonCar> ListOfCars = new List<PersonCar>();

            do
            {
                do
                {
                    Console.Write("Please enter car make. ");
                    Enum.TryParse(Console.ReadLine().ToUpper(), out carMake);
                    switch (carMake)
                    {
                        case PersonCar.MakeName.DODGE:
                        case PersonCar.MakeName.FORD:
                        case PersonCar.MakeName.CHEVY:
                            validResponse = true;
                            break;
                        case PersonCar.MakeName.NONE:
                            validResponse = false;
                            break;
                    }
                } while (!validResponse);
                newPersonCar.Make = carMake;

                Console.Write("Please enter car model. ");
                newPersonCar.Model = Console.ReadLine();

                //
                // Enter and validate car year
                //

                Console.WriteLine();
                Console.Write("Please enter car year. ");
                validResponse = int.TryParse(Console.ReadLine(), out year);
                while (!validResponse)
                {
                    Console.Write("Please enter a correct year. ");
                    validResponse = int.TryParse(Console.ReadLine(), out year);
                }
                newPersonCar.Year = year;

                //
                // Enter and validate engine size
                //

                Console.WriteLine();
                Console.Write("Please enter engine size. ");
                validResponse = double.TryParse(Console.ReadLine(), out engine);
                while (!validResponse)
                {
                    Console.Write("Please enter a correct engine size. ");
                    validResponse = double.TryParse(Console.ReadLine(), out engine);
                }
                newPersonCar.Engine = engine;

                //
                // Enter and Validate body top
                //

                Console.WriteLine();
                do
                {
                    Console.Write("Is the body style a hard top? ");
                    userResponse = Console.ReadLine().ToUpper();
                    if (userResponse == "YES")
                    {
                        newPersonCar.IsHardTop = true;
                        validResponse = true;
                    }
                    else if (userResponse == "NO")
                    {
                        newPersonCar.IsHardTop = false;
                        validResponse = true;
                    }
                    else
                    {
                        validResponse = false;
                    }

                } while (!validResponse);

                Console.WriteLine();
                Console.Write("Press any key to add car to List. ");
                Console.ReadKey();
                ListOfCars.Add(newPersonCar);

                //
                // Enter and validate continue adding
                //
                do
                {
                    Console.Write("Would you like to add another car? ");
                    userResponse = Console.ReadLine().ToUpper();
                    if (userResponse == "YES")
                    {
                        continueAdding = true;
                        validResponse = true;
                    }
                    else if (userResponse == "NO")
                    {
                        continueAdding = false;
                        validResponse = true;
                    }
                    else
                    {
                        validResponse = false;
                    }
                } while (!validResponse);

            } while (continueAdding);

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Press any Key to Display the List of Cars. ");
            Console.ReadKey();
            foreach (PersonCar car in ListOfCars)
            {
                Console.WriteLine();
                Console.WriteLine($"Make of Car: {car.Make}");
                Console.WriteLine($"Model of Car: {car.Model}");
                Console.WriteLine($"Year of Car: {car.Year}");

                Console.WriteLine($"Size of Engine: {car.Engine}");
                Console.WriteLine($"Is Body Style Hard Top: {car.IsHardTop}");
                Console.WriteLine();
            }


            Console.WriteLine("Press any Key to exit the application. ");
            Console.ReadKey();
        }
    }
}
