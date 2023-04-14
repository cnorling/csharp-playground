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
