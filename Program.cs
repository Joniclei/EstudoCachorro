using System;

namespace catioro
{
  class Program
  {
    static void Main(string[] args)
    {
      int op;

      do{
      Console.WriteLine("1-Crie um cachorro");
      Console.WriteLine("2-Liste o item");
      Console.WriteLine("3-Update");
      Console.WriteLine("4-Delete ");
      Console.WriteLine("5-Sair");
      op = Convert.ToInt32(Console.ReadLine());
      switch(op){
        case 1:{
          CatioroV.CachorroV.AddCachorro();
          break;
        }
        case 2:{
          CatioroV.CachorroV.ListCachorro();
          break;
        }
        case 3:{
          CatioroV.CachorroV.UpCachorro();

          break;
        }
        case 4:{
          break;
        }
      }

      }while(op!= 5);

    }
  }
}
