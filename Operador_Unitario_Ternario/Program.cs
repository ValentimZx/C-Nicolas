Console.WriteLine("## Operador Uniario e Ternario\n");

//Uniario (+) Uniario (-) Ternario (?:)

// int positivo = 1;
// int resultado;

// resultado = +positivo;
// Console.WriteLine(resultado);

// Console.WriteLine("Informe um numero: \n");
// var n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"O negativo de {n} e {-n}");

// Console.WriteLine("Informe a temeperaura \n");
// var temp = Convert.ToDouble(Console.ReadLine());

// var resultado = temp > 27 ? "Quente" : "Normal";
// Console.WriteLine($"O tempo esta: {resultado}");

Console.WriteLine("Informe valor de x\n");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe valor de y\n");
int y = Convert.ToInt32(Console.ReadLine());

string resultado = x > y ? "X e maior que y" : x < y ? "X e menor que Y" : x == y ? "X e igual a Y" : "Sem resultado";
Console.WriteLine(resultado);



Console.ReadKey();
