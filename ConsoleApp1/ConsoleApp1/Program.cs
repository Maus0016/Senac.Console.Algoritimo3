using System.Globalization;

Console.Write("Imforme seu nome completo: ");
//criar a variavel nome e recebe seu valor
string nomeCompleto = Console.ReadLine();
Console.WriteLine();
Console.Write("Quantos quartos tem na sua casa? ");
// Write escreve na tinha que está, Write line escreve em linhas separadas
// coverte o texto digitado para um numero int(INTEIRO)
int quartos = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Informe o preco da internet: ");
double precoInternet = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();
Console.Write("Informe seu ultimo nome, idade e altura: ");
// ex Suarez(posisão 0) 32(posisão 1) 1.81(posição2)
string linha = Console.ReadLine();
//vetor de texto  - divisao quando encontrar um espaço
//[] identifica que é um vetor
// string é um vetor
string[] vetor = linha.Split(' ');
string sobrenNome = vetor[0];
int idade = int.Parse(vetor[1]);
double altura = double.Parse(vetor[2]);
//varias variaveis para ficar mais facil de entender (não obrigatorio)
Console.WriteLine(nomeCompleto);
Console.WriteLine(quartos);
Console.WriteLine(precoInternet.ToString("F2"));
Console.WriteLine(sobrenNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2"));
//F2 significa duas casas decimais
//WriteLine com escrita imprime as coisas escritas na entrada
