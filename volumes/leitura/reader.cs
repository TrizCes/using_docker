using System;
using System.IO;

public class Reader
{
  public static void Main()
  {
    string estrutura = "________________________________________________________________________________";
    string caminho = "/app/data/escrita.txt";
    string conteudo = File.ReadAllText(caminho);
    System.Console.WriteLine($"O conteúdo é:\n {estrutura} \n {conteudo} \n {estrutura}");
  }
}
