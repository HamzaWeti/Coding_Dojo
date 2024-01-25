public class Vehicle
{
    public string Name { get; set; }
    public int Passengers { get; set; }
    public string Color { get; set; }
    public bool Engine { get; set; }
    public double DistanceTraveled { get; set; } = 0;

    public Vehicle(string name, int passengers, string color, bool engine)
    {
        Name = name;
        Passengers = passengers;
        Color = color;
        Engine = engine;
    }

    public Vehicle(string name, string color)
    {
        Name = name;
        Passengers = 5;
        Color = color;
        Engine = true;
        DistanceTraveled = 3.20;
    }

    public virtual void ShowInfo()
    {
        System.Console.WriteLine($"Vehicle Name: {Name}\nPassengers: {Passengers}\nColor: {Color}\nEngine: {Engine}\nDistanceTraveled: {DistanceTraveled}");
    }

    public virtual void Travel(double distance)
    {
        DistanceTraveled += distance;
        System.Console.WriteLine($"Vehicle has traveled {DistanceTraveled} units.");
    }
}
