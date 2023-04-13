// See https://aka.ms/new-console-template for more information

using System;

Automobiles.Car vehicle = new Automobiles.Car("Toyota", "Corolla", 1998);
vehicle.PrintInfo();

namespace Automobiles
{
  public class Car
  {
    // properties
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // constructor
    public Car(string make, string model, int year)
    {
      Make = make;
      Model = model;
      Year = year;
    }

    // methods
    public void PrintInfo()
    {
      Console.WriteLine(this.Make);
      Console.WriteLine(this.Model);
      Console.WriteLine(this.Year);
    }
  }
}