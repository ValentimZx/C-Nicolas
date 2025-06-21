using System.Runtime.CompilerServices;
using System.Security.Cryptography;

Console.WriteLine("Exercios fase 2\n");


string nome = "Paulo";


int idade = 17;


double nota = 7.5;

Console.WriteLine($"Seu nome e {nome} e sua idade e {idade} anos e sua nota foi {nota}\n");

// 2- Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes
string nome1 = "Paulo";
int idade1 = 17;
double nota1 = 7.5;

Console.WriteLine($"seu nome e: {nome} \nsua idade e: {idade} anos \ne sua nota foi: {nota}\n");

// 5- Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
// a concatenação e também a interpolação de strings

Console.WriteLine("Digite a primeira letra:\n ");
string letra = Console.ReadLine();

Console.WriteLine("Digite a segunda letra:\n ");
string letra1 = Console.ReadLine();

Console.WriteLine("Digite a terceira letra: \n");
string letra2 = Console.ReadLine();

Console.WriteLine($"A Ordem reversa e: {letra2}, {letra1}, {letra}");

// 7- Escreva um programa para receber dois valores via teclado do tipo double e a seguir
// realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
// exibindo o resultado:

Console.WriteLine("Defina um valor a X: \n");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Defina um valor a Y: ");
double y = Convert.ToDouble(Console.ReadLine());

double soma = x + y;
double subtração = x - y;
double multiplicação = x * y;
double exponenciação = Math.Pow(x, y);

Console.WriteLine($"A soma e {soma}, a subatrcao e {subtração}, a multiplicacao e {multiplicação} e a exponeciacao e {exponenciação}");

//Faca um programa para calcular a formula de baskara

int a = 1, b = 12, c = -13;
double delta, x1, x2;

delta = Math.Pow(b, 2) - 4 * a * c;

x1 = ((-b)) + Math.Sqrt((delta)) / 2 * a;
x2 = ((-b)) - Math.Sqrt(delta) / 2 * a;

Console.WriteLine("x1 = " + x1);
Console.WriteLine("x2 = " + x2);

Console.ReadLine();

// Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
// Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
// então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
// inválido’:

Console.WriteLine("Informe o nome \t");
string nome3 = Console.ReadLine();

Console.Write("Informe a senha: \t");
int senha = Convert.ToInt32(Console.ReadLine());

var resultado = (nome == "admin" || nome3 == "maria") && senha == 123 ? "Login Legal" : "Login falhou.";
Console.WriteLine(resultado);

// Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
// console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)

Console.WriteLine("Defina um valor a z: \n");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Defina um valor a w: \n");
int w = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(z % 2 == 0 ? "z e par" : "z e impar");
Console.WriteLine(w % 2 == 0 ? "w e par" : "w e impar");

// Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no
// console o resultado das seguintes operações : (x^2 -> x ao quadrado) (pi = 3.1415)

Console.WriteLine("Defina um valor de f: \t");
int f = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(-6 + f * 5);
Console.WriteLine((13 - 2) * f);
Console.WriteLine((x + 2) * (20 / x));
Console.WriteLine((12 + x) / (x - 4));
double resultado2 = 3 * Math.Pow(x, 2) + x + 10;
double area = Math.PI * Math.Pow(x,2);
Console.WriteLine(resultado);
Console.WriteLine(area);

// Escreva um programa que solicite a temperatura em graus Celsius e converta para
// Kelvin e Farhenheit usando as fórmulas a seguir:

Console.Write("Informe o valor em graus Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Graus Kelvin = {celsius + 273}");
double farhenheit = (celsius * 9) / 5 + 32;
Console.WriteLine($"Graus Fahrenheit = {farhenheit}");









