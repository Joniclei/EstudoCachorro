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

    public static CachorroM UpCachorroR(int indice)
    {
      return cachor[indice];
    }
    public static void UpCachorroRe(int indice,CachorroM cachoor)
    {
      cachor [indice] = cachoor;
    }

    public static void RemoveCachorro(int indice)
    {
      cachor.RemoveAt(indice);
    }

  }
}
