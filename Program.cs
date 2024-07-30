using System.Diagnostics.CodeAnalysis;

namespace C_SHARP;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("******************************");
        Console.WriteLine("MEU PRIMEIRO PROGRAMA EM C#");
        Console.WriteLine("******************************");
        Console.WriteLine("Qual o seu nome? ");
        string nome = Console.ReadLine()!;
        Console.WriteLine("bom dia "+ nome + ", seja bem-vindo!!");
        Console.WriteLine("Quantos anos você tem?");
        int idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Você tem " + idade + " anos");                             
        if (idade > 17)
            Console.WriteLine("VOCÊ PODE SER PRESO!!");                   
        else 
            Console.WriteLine("VOCÊ VAI PRA FEBEM");
    }
}
