namespace MeuSegundoApp;

class Program
{
    static void Main(string[] args)
    {
    //EXERCÍCIO 2
        int num = 1;

       for (int i = 1; i < 21; i++)
       {
        if (num%2==0)
        {
           System.Console.WriteLine($"{i}"); 
        }
        num++;
       }

    }
}