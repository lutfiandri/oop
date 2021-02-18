using System;

namespace OOPFundamental
{
  public class Vehicle
  {
    // attribut/field/variabel
    string brand;
    string model;
    double horsePower;
    bool turboIsOn;
    double optimumVelocity;

    // constructor method -> dipanggil pertama kali saat instansiasi
    // constructor berfungsi -> inisiasi variabel
    // instansiasi -> membuat instance dari class

    public Vehicle(string brand, string model, double horsePower)
    {
      this.brand = brand;
      this.model = model;
      this.horsePower = horsePower;
      this.turboIsOn = false;
      this.SetOptimumVelocity();
    }

    // function/method/procedure
    public void ShowVehicleInformation()
    {
      Console.WriteLine($"{brand} - {model} has {horsePower} horse power");
    }

    public void ShowOptimumVelocity()
    {
      string turboText = turboIsOn ? "(turbo mode)" : "\b";
      Console.WriteLine($"{this.brand} - {this.model} {turboText} optimum velocity: {this.optimumVelocity} km/h");
    }

    void SetOptimumVelocity()
    {
      double velocity = (this.horsePower / 4) * 1.5 + 100;
      this.optimumVelocity = turboIsOn ? 1.1 * velocity : velocity;
    }

    public void TurnTurbo(byte option)
    {
      switch (option)
      {
        case 0:
          this.turboIsOn = false;
          break;
        case 1:
          this.turboIsOn = true;
          break;
      }
      SetOptimumVelocity();
    }
  }
}