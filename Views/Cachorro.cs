using System;


namespace CatioroV
{
  public class CachorroV
  {

    public static void AddCachorro()
    {
      string raca,nome;
      int idade;
      Console.Write("Informe o raca: ");
      raca = Console.ReadLine();
      Console.Write("Informe o nome: ");
      nome = Console.ReadLine();
      Console.Write("Informe a idade: ");
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

    public static void UpCachorro(){
      string raca,nome;
      int idade,indice;

      Console.Write("Informe o raca: ");
      raca = Console.ReadLine();
      Console.Write("Informe o nome: ");
      nome = Console.ReadLine();
      Console.Write("Informe a idade: ");
      idade = Convert.ToInt32(Console.ReadLine());
      Console.Write("Digite o valor do indice que deseja alterar:");
      indice = Convert.ToInt32(Console.ReadLine());
      CatioroC.CachorroC.UpCachorroC(raca,nome,idade,indice);

    }

    public static void DelCachorro(){
      int del;
      Console.Write("Digite o indice que deseja excluir:");
      del = Convert.ToInt32(Console.ReadLine());
      CatioroC.CachorroC.DelCachorro(del);
    }

  }
}
