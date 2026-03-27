/*Criar um algoritmo que receba um valor positivo inteiro e imprima a sequência Fibonacci até o valor lido. Por exemplo: caso o usuário insira o número 15, o programa deve imprimir na tela os números 0, 1, 1, 2, 3, 5, 8, 13.*/
int anterior = 0;
int atual = 1;
int proximo = 0;

Console.Write("Digite um numero inteiro: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("Sequencia Fibonacci: ");

// Imprime o primeiro número manualmente para começar do zero
if (numero >= 0) Console.Write("0");

// Enquanto o próximo número for menor ou igual ao limite lido
while (atual <= numero)
{
    Console.Write($", {atual}");
   
    proximo = anterior + atual;
    anterior = atual;
    atual = proximo;
}
