// using diperlukan untuk berkomunikasi dengan program lain
using System;

namespace OOPFundamental
{
  class Program
  {
    static void Main(string[] args)
    {
      Vehicle tesla = new Vehicle("Tesla", "Mini 4", 500, true);
      tesla.GetVelocity();
    }
  }
}
