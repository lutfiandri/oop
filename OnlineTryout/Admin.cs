using System;
// aman

namespace OnlineTryout
{
  public class Admin : User
  {
    public Admin(string userId, string name) : base(userId, name)
    {
      Console.WriteLine($"Admin created. ID: {userId}");
    }

    public void CreateTryout(string id, string date, int price, string questions)
    {
      Tryout tryout = new Tryout(id, date, price, questions);
      Console.WriteLine($"Tryout created. ID: {id}");
      Database.insertTryoutToDatabase(tryout);
    }

    public void CreateEditorial(string id, string tryoutId, string text)
    {
      Editorial editorial = new Editorial(id, tryoutId, text);
      Console.WriteLine($"Editorial created. ID: {id}. Linked to tryout ID: {tryoutId}");
      Database.insertEditorialToDatabase(editorial);

    }
  }
}