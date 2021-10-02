using System;

namespace UsandoSwitchCase
{
  class Program
  {

    static void Main(string[] args)
    {

      string mes;
      Console.WriteLine("Digite o nome do mês que deseja saber quantos dias ele tem:");
      mes = Console.ReadLine();

      switch (mes)
      {
        case "janeiro":
        Console.Write("Esse mês tem 31 dias");
        break;

        case "fevereiro":
        Console.Write("Esse mês tem 28 ou 29 dias");
        break;

        case "março":
        Console.Write("Esse mês tem 31 dias");
        break;

        case "maio":
        Console.Write("Esse mês tem 31 dias");
        break;

        case "julho":
        Console.Write("Esse mês tem 31 dias");
        break;

        case "agosto":
        Console.Write("Esse mês tem 31 dias");
        break;

        case "outubro":
        Console.Write("Esse mês tem 31 dias");
        break;

        case "dezembro":
        Console.Write("Esse mês tem 31 dias");
        break;

        default:
        Console.Write("Esse mês tem 30 dias");
        break;
       

      }

    }

  }
}  
