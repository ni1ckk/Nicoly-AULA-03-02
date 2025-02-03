namespace MeuSegundoApp;

class Program
{
    static void Main(string[] args)
    {
//EXERCÍCIO 2
        System.Console.WriteLine("Digite o valor do produto: ");
        double prod= double.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite a porcentagem do produto: ");
        double desc= double.Parse(Console.ReadLine());

        double valor= (desc/100) * prod;
        double valorf= prod - valor; 

        System.Console.WriteLine($"\nO valor do produto é de {valorf} reais");

    }
}