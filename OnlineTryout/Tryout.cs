using System;
// aman

namespace OnlineTryout
{
  public class Tryout
  {
    string id;
    string date;
    int price;
    string questions; // satu set dengan jawabannya juga juga

    public Tryout(string id, string date, int price, string questions)
    {
      this.id = id;
      this.date = date;
      this.price = price;
      this.questions = questions;
    }
  }
}