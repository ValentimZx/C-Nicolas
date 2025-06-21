Console.WriteLine("## Tipos de referencias Nullable Types/n");

//string nome = null;
//Console.WriteLine(nome.ToUpper());

string ? nome = null;

Console.WriteLine(nome?.ToUpper()); //Se a variavel nome for null, ele vai atribuir valor null a variavel "nome", se nome nao for null, ele vai atribuir valor a variavel "nome".




Console.ReadKey();