using System;


namespace CatioroV
{
  public class CachorroV
  {

    public static void AddCachorro()
    {
      string raca,nome;
      int idade;
      Console.WriteLine("Informe o raca: ");
      raca = Console.ReadLine();
      Console.WriteLine("Informe o nome: ");
      nome = Console.ReadLine();
      Console.WriteLine("Informe a idade: ");
      idade = Convert.ToInt32(Console.ReadLine());

      CatioroC.CachorroC.AddCachorroM(raca,nome,idade);

    }

    public static void ListCachorro()
    {
      List <CatioroM.CachorroM> listcach =
      CatioroC.CachorroC.ListCachorro();
      Console.WriteLine("============= AUUUUUU =============");
      foreach (var au in listcach)
      {
        Console.WriteLine(au);
        Console.WriteLine();
      }


    }
  }
}
