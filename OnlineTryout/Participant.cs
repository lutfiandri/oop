using System;
using System.Collections.Generic;
// purcashed kurang srek

namespace OnlineTryout
{
  public class Participant : User
  {
    private List<purchasedTryoutInfo> purchasedTryoutInfos = new List<purchasedTryoutInfo>();

    public Participant(string userId, string roleId, string name) : base(userId, roleId, name)
    { }

    public void BuyTryout()
    {
      this.SearchTryout();
      Console.WriteLine("--- Buying Tryout ---");
      purchasedTryoutInfo tryout = new purchasedTryoutInfo
      {
        tryoutId = "tryout_001",
        haveDone = false,
        score = 0
      };
      this.purchasedTryoutInfos.Add(tryout);
    }

    public void ReadEditorial()
    {
      this.SearchTryout();
      // hanya bisa membuka tryout dari tryout
      Console.WriteLine("--- Read Editorial ---");
    }

    public void DoTryout()
    {
      this.SearchTryout();
      // hanya bisa membuka tryout dari purchasedTryoutIDs
      // dan jika belum pernah dikerjakan
      Console.WriteLine("--- Do the Tryout ---");
      // Console.
    }

  }

  public struct purchasedTryoutInfo
  {
    // enkapsulasi
    public string tryoutId;
    public bool haveDone;
    public int score;
  }
}