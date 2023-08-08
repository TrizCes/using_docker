using System;
using System.IO;

public class Writer
{
  public static void Main()
  {
    string conteudo = "Este conteúdo pertence ao Docker";
    string caminho = "/app/data/escrita.txt";

    File.WriteAllText(caminho, conteudo);
    System.Console.WriteLine($"O {caminho} foi concluido!");
  }
}
