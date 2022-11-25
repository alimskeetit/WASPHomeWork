using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    public class Car
    {
        private string mark;
        private int maxSpeed;
        private int year;

        public Car(string mark, int maxSpeed, int year)
        {
            this.mark = mark;
            this.maxSpeed = maxSpeed;
            this.year = year;
        }

        public Car(){}

        public override string ToString()
        {
            return $"Марка: {mark} Максимальная скорость: {maxSpeed} Год выпуска: {year}";
        }
    }

    public class PassengerCar: Car
    {
        private int countOfPassengers;
        Dictionary<string, int> spareParts = new Dictionary<string, int>();
        //todo: словарь запчасть год замены

        public PassengerCar(string mark, int maxSpeed, int year, int countOfPassengers): base(mark, maxSpeed, year)
        {
            this.countOfPassengers = countOfPassengers;
        }

        //добавление запчасти
        public void addSparePart(string part, int year)
        {
            spareParts.Add(part, year);
        }
        
        //метод получение года замены по названию
        public int getYearOfRepair(string part)
        {
            return spareParts[part];
        }

        //вывод ремонтной книжки
        public void printSpareParts()
        {
            foreach(var part in spareParts)
            {
                Console.WriteLine("Запчасть: " + part.Key + " Год замены: " + part.Value);
            }
        }


        public override string ToString()
        {
            return base.ToString() + $" Кол-во пассажиров {countOfPassengers}";
        }
        public PassengerCar(){}
    }

    public class Truck: Car
    {
        int maxWeight;
        string nameOfDriver;
        Dictionary<string, int> cargo = new Dictionary<string, int>();
        //todo: словарь груз вес

        public Truck()
        {

        }

        public Truck(string mark, int maxSpeed, int year, int maxWeight, string nameOfDriver): base(mark, maxSpeed, year)
        {
            this.maxWeight = maxWeight;
            this.nameOfDriver = nameOfDriver;
        }

        public void ChangeDriver(string newName)
        {
            nameOfDriver = newName;
        }

        //добавление груза
        public void addCargo(string name, int weight)
        {
            cargo.Add(name, weight);
        }

        //удаление груза
        public void deleteCargo(string name)
        {
            cargo.Remove(name);
        }

        //todo: вывод словаря
        public void printCargos()
        {
            foreach (var item in cargo)
            {
                Console.WriteLine($"Груз: {item.Key} Вес:{item.Value}");
            }
        }


        public override string ToString()
        {
            return base.ToString() + $" Макс. грузоподъемность {maxWeight} ФИ водителя: {nameOfDriver}";
        }
    }
}
