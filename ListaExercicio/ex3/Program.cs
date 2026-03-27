/*Receber dois números inteiros e informar qual valor lido é o menor e qual é o maior.*/



Console.WriteLine("Digite um numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um numero: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"Numero {num1} é maior e numero {num2} e menor");
}

else
{
    Console.WriteLine($"Numero {num2} e maior e numero {num1} e menor");
}


