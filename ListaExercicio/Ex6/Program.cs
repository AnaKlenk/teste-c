/*Desenvolver um algoritmo para receber 1000 valores automaticamente dentro de um vetor e ordenar do menor para o maior.
1. Desenvolver o algoritmo de ordenação (Bubble Sort);
2. Utilizar uma função em C# para ordenação;*/

/*Passo a passo para resolver o exercicio 06
1 - Criar um vetor de valores inteiros com N posições
2 - Criar um laço de repetição para percorrer um vetor
3 - Atribuir um valor aleatorio para cada posição
4 - Imprimir o vetor sem ordenação
*/

//1 - Criar um vetor de valores inteiros com N posições
int tamanho = 100;
int[] vetor = new int[tamanho];

//2 - Criar um laço de repetição para percorrer um vetor
for (int i = 0; i < vetor.Length; i++)
{
    //3 - Atribuir um valor aleatorio para cada posição
    Random random = new Random();
    vetor[i] = random.Next(1000);

}
//4 - Imprimir o vetor sem ordenação
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

Console.WriteLine("\n");
//5 - Ordenar o vetor com o bubble Sort
bool troca = false;
do
    {  
        troca  = false;
        for (int i = 0; i < vetor.Length - 1; i++)
        {
        int atual = vetor[i];
        int proxima = vetor[i+1];

        if (atual > proxima)
        {
            troca = true;
            int auxiliar = atual;
            vetor[i] = proxima;
            vetor[i+1] = auxiliar;
        }

}
    }while (troca == true);
Console.WriteLine("\n");

//6 - Imprimir o vetor com ordenação
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}



