using System;
// aman

namespace OnlineTryout
{
  public class User
  {
    private string userId;
    private string roleId;
    private string name;
    public User(string userId, string roleId, string name)
    {
      this.userId = userId;
      this.roleId = roleId;
      this.name = name;
    }
    public void SeeScoresAndRanks()
    {
      Console.WriteLine("See Scores and Ranks");
      this.SearchTryout();
    }
    public void SearchTryout()
    {
      Console.WriteLine("--- Search Tryout from Database ---");
      Console.WriteLine("You can search by input keyword or with manual scroll");
      Console.WriteLine("selecting...");
      Console.WriteLine("Tryout X-X selected");
    }
  }
}