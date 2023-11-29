
Console.WriteLine("Digite um número para gerar a tabuada: ");
string numero = Console.ReadLine();

int num1 = int.Parse(numero);
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("*****************");
for (int i = 1; i < 11; i++)
{
    int res = num1 * i;

    Console.WriteLine(num1  + " X " + i +" = " + res);
    
};
Console.WriteLine("*****************");
Console.WriteLine("");
Console.WriteLine("//////////////////");
Console.WriteLine("//FIM DA TABUADA//");
Console.WriteLine("//////////////////");