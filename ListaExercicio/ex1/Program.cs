/*Crie um algoritmo que permita fazer três conversões monetárias. O algoritmo deve receber o valor em real (R$) e apresentar os valores convertidos em:

1. Dólar (1 dólar = 5,17 reais)
2. Euro (1 euro = 6,14 reais)
3. Peso argentino (1 peso argentino = 0,05 reais) */

Console.WriteLine("Digite o valor de reais: ");
float real = float.Parse(Console.ReadLine());

float dolar = real * 5.17f;
float euro = real * 6.14f;
float peso = real * 0.05f;

Console.WriteLine($"Dolar: {dolar} Euro: {euro} Peso: {peso}" );
