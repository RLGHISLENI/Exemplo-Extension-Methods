using System;

namespace ExtensionMethods{
  public class Pessoa
  {
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public int Idade { get; set; }
    public string FormatarNome()
    {
      return Nome + " " + Sobrenome; 
    }
  }

  public static class ExtendPessoa
  {
    public static int NomeLength(this Pessoa pessoa)
    {
      return pessoa.FormatarNome().Length;
    }
  }
 
  class Program
  {
    static void Main(string[] args)
    {
      var pessoa = new Pessoa()
      {
        Nome = "Robertinho",
        Sobrenome = "Ghisleni",
        Idade = 35
      };
      Console.WriteLine(pessoa.FormatarNome() + " possui " + pessoa.NomeLength() + " letras!");
      Console.ReadKey();      
    }
  }
}
