using System;
using System.Collections.Generic;
// purcashed kurang srek, tapi dah bisa jalan

namespace OnlineTryout
{
  public class Participant : User
  {
    private List<purchasedTryoutInfo> purchasedTryoutInfos = new List<purchasedTryoutInfo>();

    public Participant(string userId, string name) : base(userId, name)
    {
      Console.WriteLine($"Participant created. ID: {userId}");
    }

    public void BuyTryout(string tID)
    {
      this.SearchTryout();
      purchasedTryoutInfo tryout = new purchasedTryoutInfo
      {
        tryoutId = tID,
        haveDone = false,
        score = 0
      };
      this.purchasedTryoutInfos.Add(tryout);
      Console.WriteLine($"Tryout purchased. Tryout ID: {tID}");
    }

    public void ReadEditorial()
    {
      this.SearchTryout();
      // hanya bisa membuka tryout dari tryout
      Console.WriteLine("Read the Editorial");
    }

    public void DoTryout()
    {
      this.SearchTryout();
      // hanya bisa membuka tryout dari purchasedTryoutIDs
      // dan jika belum pernah dikerjakan
      Console.WriteLine("Do the Tryout");
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