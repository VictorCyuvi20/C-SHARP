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
        {
            Random numAleatorio = new Random();
            int anos = numAleatorio.Next(1,100);
            Console.WriteLine("VOCÊ VAI SER PRESO!!" + " Você vai apodrecer na cadeia por " + anos + " anos");              
            
        }
        else 
        {
            int faltam = 18 - idade;
            Console.WriteLine("VOCÊ VAI PRA FEBEM, faltam " + faltam + " anos para vc ir pro inferno 2.0");
        }
    }
}
