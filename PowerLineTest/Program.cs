// See https://aka.ms/new-console-template for more information

using PowerLineTest;

SportCar sportCar = new SportCar(10,35,150);
Console.WriteLine(sportCar.CalculateCarCanPass());
Console.WriteLine(sportCar.CalculateDistanceTime(350));
Console.WriteLine();
Console.WriteLine();
PassengerCar passengerCar = new PassengerCar(7, 40, 100, 4);
Console.WriteLine(passengerCar.CalculateCarCanPass());
Console.WriteLine(passengerCar.CalculateDistanceTime(350));
Console.WriteLine(passengerCar.PowerReserveStatus(2));
Console.WriteLine();
Console.WriteLine();
TruckСar truck = new TruckСar(12, 60, 80, 2000);
Console.WriteLine(truck.CalculateCarCanPass());
Console.WriteLine(truck.CalculateDistanceTime(350));
Console.WriteLine(truck.PowerReserveStatus(1200));

