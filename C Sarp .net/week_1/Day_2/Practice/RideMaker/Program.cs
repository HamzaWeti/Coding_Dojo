Vehicle BMW = new Vehicle("Bmw", 3, "Red", true);
Vehicle Brabus = new Vehicle("Brabus", "Black");
Vehicle Golf7 = new Vehicle("Golf7", 4, "Red", false);
Vehicle Tmax = new Vehicle("Tmax", "Red");

List<Vehicle> vehicles = new List<Vehicle>
        {
            BMW,
            Brabus,
            Golf7,
            Tmax
        };

foreach (var vehicle in vehicles)
{
    vehicle.ShowInfo();
    System.Console.WriteLine();
}
BMW.Travel(100);
BMW.ShowInfo();
