public class Human
{
    public float Speed { get; set; }
    public string TypeMoving { get; set; }
}

public class TransportNetwork
{
    public readonly List<Vehicle> Vehicles = new();
}

public class Route
{
}