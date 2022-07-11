using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_designPatterns.SOLID
{
    class InterfaceSegregationPrinciple
    {
        public void Execute()
        {
            CarVehicle car = new CarVehicle("rosa", 2023, 5, 4);
            MotorcycleVehicle motorcycle = new MotorcycleVehicle("cinza", 2021, 2);
        }
    }

    //Correct
    interface IVehicle
    {
        void StartVehicle();
    }

    interface IVehicleCar : IVehicle
    {
        void ConfigureCar(string color, int year, int seats, int doors);
    }

    interface IVehicleMotorcycle : IVehicle
    {
        void ConfigureMotorcycle(string color, int year, int seats);
    }

    class CarVehicle : IVehicleCar
    {
        private string? _color;
        private int _year;
        private int _seats;
        private int _doors;

        public CarVehicle(string color, int year, int seats, int doors) //construtor
        {
            ConfigureCar(color, year, seats, doors);
        }

        public void ConfigureCar(string color, int year, int seats, int doors) //método interface IVehicleCar
        {
            _color = color;
            _year = year;
            _seats = seats;
            _doors = doors;

            Console.WriteLine($"Criando carro {_color} do ano {_year} com {_seats} bancos e {_doors} portas");

            StartVehicle();
        }

        public void StartVehicle() //método interface IVehicle
        {
            Console.WriteLine("Iniciando carro!!");
        }
    }

    class MotorcycleVehicle : IVehicleMotorcycle
    {
        private string? _color;
        private int _year;
        private int _seats;

        public MotorcycleVehicle(string color, int year, int seats)
        {
            ConfigureMotorcycle(color, year, seats);
        }

        public void ConfigureMotorcycle(string color, int year, int seats)
        {
            _color = color;
            _year = year;
            _seats = seats;

            Console.WriteLine($"Criando moto {_color} do ano {_year} com {_seats} bancos");

            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Iniciando moto!! Vrumm");
        }
    }


    //Incorrect - essa maneira está incorreta, pois vai obrigar o programador a usar métodos desnecessários, por exemplo, quando for usar moto não tem necessidade de ter um método sobre carro
    interface IVehicleIncorrect
    {
        void StartVehicle();

        void ConfigureCar(string color, int year, int seats, int doors);

        void ConfigureMotorcycle(string color, int year, int seats);
    }

    class MotorcycleVehicleIncorrect : IVehicleIncorrect
    {
        private string? _color;
        private int _year;
        private int _seats;

        public MotorcycleVehicleIncorrect(string color, int year, int seats)
        {
            ConfigureMotorcycle(color, year, seats);
        }

        public void ConfigureCar(string color, int year, int seats, int doors) //Cria método desnecessário
        {
        }

        public void ConfigureMotorcycle(string color, int year, int seats)
        {
            _color = color;
            _year = year;
            _seats = seats;

            Console.WriteLine($"Criando moto {_color} do ano {_year} com {_seats} bancos");

            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Iniciando moto!! Vrumm");
        }
    }
}


