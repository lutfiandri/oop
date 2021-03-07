using System;
// aman

namespace OnlineTryout
{
  public class Admin : User
  {
    public Admin(string userId, string roleId, string name) : base(userId, roleId, name)
    { }

    public void CreateTryout(string id, string date, int price, string questions)
    {
      Tryout tryout = new Tryout(id, date, price, questions);
      Database.insertTryoutToDatabase(tryout);
    }

    public void CreateEditorial(string id, string tryoutId, string text)
    {
      Editorial editorial = new Editorial(id, tryoutId, text);
      Database.insertEditorialToDatabase(editorial);
    }
  }
}