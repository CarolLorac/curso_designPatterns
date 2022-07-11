using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_designPatterns.SOLID
{
    class OpenClosedPrinciple
    {
        public void Execute()
        {
            TypeVehicle type = TypeVehicle.Motorcycle;

            if (type == TypeVehicle.Car)
            {
                //Correct
                Car car = new Car("Rosa", 2000, 2, 2);

                //Incorrect
                VehicleIncorrect vehicle = new VehicleIncorrect("Branco", 2020, 5);
                vehicle.Car();
            }
            else
            {
                //Correct
                Motorcycle motorcycle = new Motorcycle("Preta", 2022, 2);

                //Incorrect
                VehicleIncorrect vehicle = new VehicleIncorrect("Azul", 2018, 2);
                vehicle.Motorcycle();
            }
        }
    }

    enum TypeVehicle
    {
        Car,
        Motorcycle
    }

    //Correct
    //Aqui você define uma classe com os atributos e métodos principais, herda ela e adiciona os elementos própios
    class Vehicle
    {
        public string Color;
        public int Year;
        public int Seats;

        public Vehicle(string color, int year, int seats)
        {
            Color = color;
            Year = year;
            Seats = seats;
        }

        public void StartVehicle()
        {
            Console.WriteLine("Iniciando o veiculo!!");
        }
    }

    class Car : Vehicle //herança
    {
        public int Doors;

        public Car(string color, int year, int seats, int doors) : base(color, year, seats) //herança
        {
            Doors = doors;

            ConfigureCar();
        }

        public void ConfigureCar()
        {
            Console.WriteLine($"\nO carro do ano {Year} é {Color} e possui {Seats} assentos e {Doors} portas");
            StartVehicle();
        }
    }

    class Motorcycle : Vehicle //herança
    {
        public Motorcycle(string color, int year, int seats) : base(color, year, seats) //herança
        {
            ConfigureMotorcycle();
        }

        public void ConfigureMotorcycle()
        {
            Console.WriteLine($"\nA moto do ano {Year} é {Color} e possui {Seats} assentos");
            StartVehicle();
        }
    }



    //Incorrect
    class VehicleIncorrect
    {
        private string _color;
        private int _year;
        private int _seats;

        public VehicleIncorrect(string color, int year, int seats)
        {
            _color = color;
            _year = year;
            _seats = seats;
        }

        public void Car()
        {
            Console.WriteLine($"\nO carro do ano {_year} é {_color.ToLower()} e possui {_seats} assentos");
            StartVehicle();
        }

        public void Motorcycle()
        {
            Console.WriteLine($"\nA moto do ano {_year} é {_color.ToUpper()} e possui {_seats} assentos");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Iniciando o veículo!!");
        }
    }
}
