using System;
// aman

namespace OnlineTryout
{
  public class User
  {
    private string userId;
    private string name;
    public User(string userId, string name)
    {
      this.userId = userId;
      this.name = name;
    }
    public void SeeScoresAndRanks()
    {
      Console.WriteLine("See Scores and Ranks");
      this.SearchTryout();
    }
    public void SearchTryout()
    {
      Console.WriteLine("--- Search and Select a Tryout from Database ---");
    }
  }
}