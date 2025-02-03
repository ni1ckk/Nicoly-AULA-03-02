namespace MeuSegundoApp;

class Program
{
    static void Main(string[] args)
    {
        //EXERCÍCIO 1
        System.Console.WriteLine("Digite um número: ");
        var num1= int.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite outro número: ");
        var num2= int.Parse(Console.ReadLine());

        var soma = num1 + num2;
        var sub = num1 - num2;
        var mult = num1 * num2;
        double div = (double)num1 / num2;

        System.Console.WriteLine($"\nA soma é: {soma}");
        System.Console.WriteLine($"A subtração é: {sub}");
        System.Console.WriteLine($"A multiplicação é: {mult}");
        System.Console.WriteLine($"A divisão é: {div}"); 
    
        }
}