public class Car
{
    public string? Type { get; set; }
    public int Seats { get; set; }
    public int Wheels { get; set; }
    public string? Color { get; set; }
}

public class CarBuilder
{
    private Car car = new Car();

    public CarBuilder SetType(string type)
    {
        car.Type = type;
        return this;
    }

    public CarBuilder SetSeats(int seats)
    {
        car.Seats = seats;
        return this;
    }

    public CarBuilder SetWheels(int wheels)
    {
        car.Wheels = wheels;
        return this;
    }

    public CarBuilder SetColor(string color)
    {
        car.Color = color;
        return this;
    }

    public Car Build()
    {
        return car;
    }
}

public class CarDirector
{
    private CarBuilder builder;

    public CarDirector(CarBuilder builder)
    {
        this.builder = builder;
    }

    public Car Construct()
    {
        return builder
            .SetType("Sports")
            .SetSeats(5)
            .SetWheels(4)
            .SetColor("Red")
            .Build();
    }

}

class Program
{
    static void Main(string[] args)
    {
        CarBuilder builder = new CarBuilder();
        CarDirector director = new CarDirector(builder);
        Car car = director.Construct();

        Console.WriteLine("Type: " + car.Type);
        Console.WriteLine("Seats: " + car.Seats);
        Console.WriteLine("Wheels: " + car.Wheels);
        Console.WriteLine("Color: " + car.Color);

    }
}
