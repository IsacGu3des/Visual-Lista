﻿//1) Escreva um programa em C# que declare variáveis dos tipos int, float, string e bool. Atribua valores a essas variáveis e imprima-os no console.
using System.Numerics;

int x = 1;
float z = 19000;
string p = "coisa";
bool a = false;
Console.WriteLine($"{x} {z} {p} {a}");

//2) Crie um programa que leia dois números inteiros do usuário e exiba a soma, subtração, multiplicação e divisão desses números.

int Primeiro = int.Parse(Console.ReadLine());
int Segundo = int.Parse(Console.ReadLine());
Console.WriteLine($"Soma {Primeiro + Segundo}");
Console.WriteLine($"Multiplicação {Primeiro * Segundo}");
Console.WriteLine($"Subtração {Primeiro - Segundo}");
Console.WriteLine($"Divisão {Primeiro / Segundo}");

//3) Escreva um programa que solicite o nome do usuário e sua idade. O programa deve exibir uma mensagem como "Olá, [nome], você tem [idade] anos."

Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();
Console.WriteLine("Digite sua idade:");
int idade = int.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Olá, {nome}, você tem {idade} anos.");

//4) Faça um programa que leia um número do usuário e informe se ele é positivo, negativo ou zero.

Console.WriteLine("digite um numero");
float o = float.Parse(Console.ReadLine());
Console.Clear();
if (o > 0 ){
    Console.WriteLine("é um numero positivo");
}
else{
    Console.WriteLine("é um numero negativo");
}

//5) Crie um programa que exiba os números de 1 a 10 usando um loop for.

for (int X = 1; X <= 10; X++){
    Console.WriteLine(X);

}

//6) Escreva um programa que leia a idade de uma pessoa e verifique se ela é maior de idade (18 anos ou mais) e se está apta a votar e a dirigir.

Console.WriteLine("Digite sua idade:");
int Idade = int.Parse(Console.ReadLine());
Console.Clear();
if (Idade >= 18 ){
    Console.WriteLine("Voce é maior de idade. Pode dirigir");
}
else{
    Console.WriteLine($"Voce é menor de idade. Espere mais {18 - Idade} anos para dirigir");
}

//7) Implemente uma função em C# chamada CalcularMedia que recebe três notas (float) como parâmetros e retorna a média dessas notas. Chame essa função a partir do método Main e exiba o resultado no console.

static float CalcularMedia(float nota1, float nota2, float nota3)
{
return (nota1 + nota2 + nota3)/3;
}
Console.WriteLine("Digite as 3 notas");
float nota1 = float.Parse(Console.ReadLine());
float nota2 = float.Parse(Console.ReadLine());
float nota3 = float.Parse(Console.ReadLine());

float media = CalcularMedia(nota1, nota1, nota2);
Console.WriteLine($"A sua media das notas é: {media}");

//8) Escreva um programa que leia três números e determine o maior e o menor deles. Exiba o resultado no console.
