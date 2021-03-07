using System.Collections.Generic;
// aman

namespace OnlineTryout
{
  public static class Database
  {
    private static List<Tryout> tryouts = new List<Tryout>();
    private static List<Editorial> editorials = new List<Editorial>();

    public static void insertTryoutToDatabase(Tryout tryout)
    {
      tryouts.Add(tryout);
    }

    public static void insertEditorialToDatabase(Editorial editorial)
    {
      editorials.Add(editorial);
    }
  }
}