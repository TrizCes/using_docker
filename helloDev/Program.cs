using System;

public class Program
{
  public static void Main()
  {
    string envVarName = "AMBIENTE_ESTUDOS";
    string envVarValue = Environment.GetEnvironmentVariable(envVarName);
    Console.WriteLine($"Hello my dear, {envVarValue}");
  }
}
