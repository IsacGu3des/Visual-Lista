//1) Escreva um programa em C# que declare variáveis dos tipos int, float, string e bool. Atribua valores a essas variáveis e imprima-os no console.


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
    
static void Main(){
    Console.WriteLine("Primeira Nota:");
    float n1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segunda Nota:");
    float n2 = float.Parse(Console.ReadLine());
    Console.WriteLine("Terceira Nota:");
    float n3 = float.Parse(Console.ReadLine());

    float media = CalcularMedia(n1,n2,n3);
    Console.WriteLine($"{media}");
}
Main();

//8) Escreva um programa que leia três números e determine o maior e o menor deles. Exiba o resultado no console.

int um = int.Parse(Console.ReadLine());
int dois = int.Parse(Console.ReadLine());
int tres = int.Parse(Console.ReadLine());

if (um > dois && um > tres){
    Console.WriteLine($"{um} é o maior");
    if(dois< tres){
        Console.WriteLine($"{dois} é o menor");
    }
    else{
        Console.WriteLine($"{tres} é o menor");
    }
}

else if(dois > um && dois >tres){
    Console.WriteLine($"{dois} é o maior");
    if(um>tres){
        Console.WriteLine($"{tres} é o menor");
    }
    else{
        Console.WriteLine($"{um} é o menor");
    }
}

else if(tres > um && tres > dois){
    Console.WriteLine($"{tres} é o maior");
    if(dois>um){
        Console.WriteLine($"{um} é o menor");
    }
    else{
        Console.WriteLine($"{dois} é o menor");
    }
}
//9) Crie um programa que solicite números ao usuário até que ele digite zero. Ao final, o programa deve exibir a soma de todos os números digitados.
int Num = 1;
int soma = 0;
while(Num != 0)
{
    Num = 0;
    Console.WriteLine("Digite ai vai");
    Num = int.Parse(Console.ReadLine());
    soma = soma + Num;
}
Console.Clear();
Console.WriteLine($"A soma disso é {soma}");

//10)Escreva um programa que leia um valor em reais e o converta para dólares. Considere que a taxa de câmbio seja informada pelo usuário. Exiba o valor convertido no console.

    Console.WriteLine("Escreva uma quantia de Reais");
    float RS =float.Parse(Console.ReadLine());
    Console.WriteLine($"Considerando que o dolar esta 5,48R$ então voce digitou o equivalente a {RS / 5.48:F2} dolares");

//11)Implemente uma função recursiva em C# chamada CalcularFatorial que recebe um número inteiro n e retorna o fatorial dele. Utilize operadores lógicos para garantir que a função trate adequadamente os casos de entrada negativa e zero. Teste a função a partir do método Main.

static int Fatorial(int n){
    if (n == 1 ){
        return 1;
    }
    else{

    return n * Fatorial(n-1);

    }
}
static void Main1(){
    Console.WriteLine("Numero para fatorial");
    int N = int.Parse(Console.ReadLine());
    Console.WriteLine(Fatorial(N));
    }
    Main1();

    /* 12)Crie um programa que gere a sequência de Fibonacci até um número n fornecido pelo usuário.
     Utilize um loop while para gerar a sequência e uma estrutura condicional para evitar números negativos e zero como entrada. */

     Console.WriteLine("Vezes para ser repetida na sequêcia de Fibonacci");
     int n = int.Parse(Console.ReadLine());
     int ant = 0;
     int atu = 1;
     int Count = 0;
     Console.Clear();
     if(n<0){
        Console.WriteLine("Não aceita numeros negativos");
     }
        else{
     
     while (Count != n){
        int fib = ant + atu;
        Console.WriteLine($"{fib}");
        ant = atu;
        atu = fib;
        Count++;
     }
     }

     /*Escreva um programa que leia uma lista de nomes do usuário e ordene essa lista em ordem alfabética. Utilize uma função 
     para realizar a ordenação (pode ser um algoritmo de ordenação simples, como bubble sort ou insertion sort) e exiba a lista ordenada no console.*/
     
    Console.WriteLine("Não sei o que é bubblo sort, ou insertion sort. :) ");
     
