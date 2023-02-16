using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DotNetProject
{
    internal class Car
    {
        String Make = "";
        String Model = "";
        int Year = 0;
        decimal Price = 0;

        static Car(){}

        public Car(string v1, string v2, int v3, decimal v4)
        {
            this.make = v1;
            this.Model = v2;
            this.Year = v3;
            this.Price = v4;
        }

        public String make
        {
            get { return Make; }
            set { Make = value; }
        }
        public String model
        {
            get { return Model; }
            set { Model = value; }
        }
        public int year
        {
            get { return Year; }
            set { Year = value; }
        }
        public decimal price
        {
            get { return Price; }
            set { Price = value; }
        }
        public override string ToString()
        {
            return "[Make -> " + this.make + "] [Model -> " + this.model + "] [Year -> " + this.year + "] [Price -> " + this.price + "]";
        }
    }

    class CarDetails
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();
            int choice = 0;
            string[] input = new string[4];
            String modelNo = "";
            Car car;
            do
            {
                Console.Write("\nCount : ");
                Console.WriteLine(carList.Count);
                Console.WriteLine("Enter command:\n1. Add a new car\n2. Modify car\n3. Search car\n4. List all cars\n5. Delete car\n6. Quit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Make, Model, Year and Price separated by a space:");
                        input = Console.ReadLine().Split(",");
                        carList.Add(new Car(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3])));    
                        break;
                    case 2:
                        Console.WriteLine("Enter the Model of the car to be modified:");
                        modelNo = Console.ReadLine();
                        car = carList.FirstOrDefault(c => c.model == modelNo);
                        if (car != null)
                        {
                            Console.WriteLine("Enter new Make, Model, Year and Price separated by a space:");
                            input = Console.ReadLine().Split(",");
                            car.make = input[0];
                            car.model = input[1];
                            car.year = int.Parse(input[2]);
                            car.price = decimal.Parse(input[3]);
                            Console.WriteLine("Car Modified");
                        }
                        else
                        {
                            Console.WriteLine("Car not found!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the Model of the car to search:");
                        modelNo = Console.ReadLine();
                        car = carList.FirstOrDefault(c => c.model == modelNo);
                        if (car != null)
                        {
                            Console.WriteLine(car.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Car not found!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("The Car List contains:");
                        foreach (Car c in carList)
                        {
                            Console.WriteLine(c.ToString());
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter the Model of the car to delete:");
                        modelNo = Console.ReadLine();
                        car = carList.FirstOrDefault(c => c.model == modelNo);
                        if (car != null)
                        {
                            carList.Remove(car);
                            Console.WriteLine("Car deleted!");
                        }
                        else
                        {
                            Console.WriteLine("Car not found!");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Quit");
                        break;
                }

            } while (choice <= 6);
        }
    }
}
