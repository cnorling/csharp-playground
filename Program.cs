// See https://aka.ms/new-console-template for more information

Automobiles.Car vehicle = new Automobiles.Car("Toyota", "Corolla", 1998, new Automobiles.Specs.Stats
{
  Engine = new Automobiles.Specs.Engine
  {
    Type = "Inline 4",
    CrankHorsepower = "150",
    Torque = "140lb-ft"
  },
  Transmission = new Automobiles.Specs.Transmission
  {
    Type = "Manual",
    Gears = "5"
  },
  Horsepower = "120",
  Topspeed = "120mph"
});
vehicle.PrintInfo();

namespace Automobiles
{
  public class Car
  {
    // properties
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public Automobiles.Specs.Stats Specs { get; set; }

    // constructors
    public Car(string make, string model, int year, Specs.Stats stats)
    {
      Make = make;
      Model = model;
      Year = year;
      Specs = new Specs.Stats
      {
        Engine = new Automobiles.Specs.Engine
        {
          Type = "Inline 4",
          CrankHorsepower = "150",
          Torque = "140lb-ft"
        },
        Transmission = new Automobiles.Specs.Transmission
        {
          Type = "Manual",
          Gears = "5"
        },
        Horsepower = "120",
        Topspeed = "120mph"
      };
    }

    // methods
    public void PrintInfo()
    {
      Console.WriteLine($"{this.Year} {this.Make} {this.Model}");
    }
  }

  namespace Specs
  {
    public class Stats
    {
      public string? Horsepower { get; set; }
      public string? Topspeed { get; set; }
      public Engine? Engine { get; set; }
      public Transmission? Transmission { get; set; }
    }
    public class Engine
    {
      public string? Type { get; set; }
      public string? CrankHorsepower { get; set; }
      public string? Torque { get; set; }
    }
    public class Transmission
    {
      public string? Type { get; set; }
      public string? Gears { get; set; }
    }
  }
}