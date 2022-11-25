using Autopark;

class Program
{
    public static void Main()
    {
        PassengerCar passengerCar1 = new PassengerCar("Toyota", 120, 2006, 5);
        PassengerCar passengerCar2 = new PassengerCar("Nisssan", 150, 2008, 5);

        Truck truck1 = new Truck("Kamaz", 100, 2010, 5000, "Sergey Sergeevich");
        Truck truck2 = new Truck("Belaz", 100, 2016, 900000, "Alexander Alexeevich");

        Autopark.Autopark autopark = new Autopark.Autopark("Ivan's autopark", new Car[] { truck1, passengerCar1, truck2, passengerCar2 });

        Console.WriteLine(autopark.ToString());
    }
}