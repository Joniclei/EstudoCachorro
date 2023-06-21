using System;


namespace CatioroC
{
  public class CachorroC
  {

    public static void AddCachorroM (string raca, string nome, int idade)
    {
      new CatioroM.CachorroM(
          raca,
          nome,
          idade
      );
    }
    public static List <CatioroM.CachorroM> ListCachorro()
    {
      return CatioroM.CachorroM.ListCachorro();
    }

    public static void UpCachorroC(string raca,string nome,int idade,int indice){
      CatioroM.CachorroM.CachorroUp(raca,nome,idade,indice);

    }

  }
}
