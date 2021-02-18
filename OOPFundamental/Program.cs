// using diperlukan untuk berkomunikasi dengan program lain
using System;

namespace OOPFundamental
{
  class Program
  {
    static void Main(string[] args)
    {
      Vehicle myCar = new Vehicle("Tesla", "model 3", 500);
      myCar.ShowVehicleInformation();
      myCar.ShowOptimumVelocity();
      myCar.TurnTurbo(1);
      myCar.ShowOptimumVelocity();
    }
  }
}
