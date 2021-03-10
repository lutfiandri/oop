using System.Collections.Generic;
using System;
// aman

namespace OnlineTryout
{
  class Program
  {
    static void Main(string[] args)
    {
      // inisialisasi user
      Admin admin1 = new Admin("admin_001", "Admin Name 1");
      Participant participant1 = new Participant("participant_001", "Participant Name 1");
      Console.WriteLine();

      // admin membuat tryout dan editorial
      admin1.CreateTryout("tryout_001", "20/12/20", 50000, "40 question goes here");
      admin1.CreateEditorial("editorial_001", "tryout_001", "editorial goes here");
      Console.WriteLine();

      // participamt membeli tryout, mengerjakan tryout, membaca editorial
      participant1.BuyTryout("tryout_001");
      participant1.DoTryout();
      participant1.ReadEditorial();

    }
  }
}
