using System;
using CatioroM;

namespace CatioroRe
{
  public class CachorroRe
  {
    static List<CatioroM.CachorroM> cachor= new List<CatioroM.CachorroM>();

    public static void addCachorro(CatioroM.CachorroM cachorrinho)
    {
      cachor.Add(cachorrinho);
    }

    public static List<CatioroM.CachorroM> ListCachorro(){
      return cachor;
    }

  }
}
