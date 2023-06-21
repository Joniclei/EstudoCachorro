using System;
using System.Text;
using CatioroRe;

namespace CatioroM
{
  public class CachorroM
  {
    static Random randDormir = new Random();
    public string Raca { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Dormindo { get; set; }
    public string Brincar { get; set; }

    public bool Dormir = Convert.ToBoolean(randDormir.Next(2));

    public void AtualizarStatus(bool Dormir)

    {
      this.Dormindo = Dormir ? "O Catioro esta Dormindo" : "O Catioro esta acordado";
      this.Brincar = Dormir ? "sem brincadeiras" : "Auauauauuuuuuu,vamos brincar";
    }

    public CachorroM(string raca, string nome, int idade)
    {

      this.Raca = raca;
      this.Nome = nome;
      this.Idade = idade;
      AtualizarStatus(Dormir);
      CatioroRe.CachorroRe.addCachorro(this);

    }
    public static List<CatioroM.CachorroM> ListCachorro()
    {
      return CatioroRe.CachorroRe.ListCachorro();


    }

    public static CachorroM CachorUp(int indice)
    {
      return CatioroRe.CachorroRe.UpCachorroR(indice);

    }
    public static void  CachorroUp(string raca,string nome,int idade,int indice)
    {
      CachorroM cachor = CachorroM.CachorUp(indice);
      cachor.Raca = raca;
      cachor.Nome=nome;
      cachor.Idade = idade;

      CatioroRe.CachorroRe.UpCachorroRe(indice,cachor);

    }

    public static void DelCachorrinho(int del){
      CatioroRe.CachorroRe.RemoveCachorro(del);
    }


    public override string ToString()
    {

      StringBuilder sb = new StringBuilder();
      sb.Append("Raca:");
      sb.AppendLine(Raca);
      sb.Append("Nome:");
      sb.AppendLine(Nome);
      sb.Append("Idade:");
      sb.AppendLine(Convert.ToString(Idade));
      sb.Append(Dormindo);
      sb.Append(" entao ");
      sb.Append(Brincar);

      return sb.ToString();
    }

  }
}
