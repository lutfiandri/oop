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
    double velocity;

    // constructor method -> dipanggil pertama kali saat instansiasi
    // constructor berfungsi -> inisiasi variabel
    // instansiasi -> membuat instance dari class

    public Vehicle(string brand, string model, double horsePower, bool turboIsOn)
    {
      this.brand = brand;
      this.model = model;
      this.horsePower = horsePower;
      this.turboIsOn = turboIsOn;
    }

    // function/method/procedure
    void ShowVehicleInformation()
    {
      Console.WriteLine($"{brand} - {model} has {horsePower} horse power");
    }
    void CalculateOptimumVelocity()
    {
      this.velocity = (this.horsePower / 4) * 1.5 + 100;
    }
    double CalculateTurboVelocity(double velocity)
    {
      double turboVelocity = 1.1 * velocity;
      return turboVelocity;
    }

    double CalculateVelocity()
    {
      this.CalculateOptimumVelocity();
      if (!turboIsOn) return velocity;
      return CalculateTurboVelocity(velocity);
    }

    public void GetVelocity()
    {
      Console.WriteLine($"{this.brand} - {this.model} velocity: {this.CalculateVelocity()}");
    }
  }
}