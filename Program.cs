using Fundamentos.C_.Models;


//OPERADORES ARITMÉTICOS



Calculadora calculadora = new Calculadora();

calculadora.somar(5, 5);
calculadora.subtrai(200, 100);
calculadora.multiplicar(500, 2);
calculadora.dividir(25, 5);
calculadora.restoDaDivisao(30, 5);
calculadora.potencia(2, 3);

calculadora.seno( 30);
calculadora.Coseno( 30 );
calculadora.Tangente( 30 );

int numeroIncremento = 10;

 numeroIncremento ++;

Console.WriteLine(numeroIncremento);

int numeroDecremento = 10;

numeroDecremento --;

Console.WriteLine(numeroDecremento);

calculadora.RaizQuadrada(9);















//OPERADORES LOGICOS 

//OPERADOR DE NEGAÇÃO ! (NOT)
// bool choveu = true;
// bool estarTarde = true;

// if(!choveu && !estarTarde)
// {
//     Console.WriteLine("vou pedalar");
// }
// else
// {
//     Console.WriteLine("vou pedalar outro dia");
// }


















//OPERADOR && (É)
// bool possuiPresencaMinima = false;
// double media = 7.5;

// if(possuiPresencaMinima && media >= 7.5)
// {
//     Console.WriteLine("APROVADO!");
// }
// else
// {
//     Console.WriteLine("REPROVADO");
// }
















//OPERADOR || (OU)
// bool heMaiorDeIdade = false;
// bool possuiAutorizacao = true;

// if(heMaiorDeIdade || possuiAutorizacao)
// {
//     Console.WriteLine("Entrada liberada");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }


























//conversão modo tryparse 

// Console.WriteLine($"qual é sua idade?");

// string idade1 = Console.ReadLine();
// int idade;

// int.TryParse(idade1, out idade);

// if(idade >=18)
// {
//     Console.WriteLine("Pode entrar na festa");
// }
// else
// {
//     Console.WriteLine("naõ pode entrar");
// }



























//SWITCH CASE  

// Console.WriteLine("digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":   

//             Console.WriteLine("Vogal");
//             break;

//             default:
//                 Console.WriteLine("Não é vogal");
//                 break;
// }


















// if(letra == "a"||
// letra == "e"||
// letra == "i"||
// letra == "o"||
// letra == "u") 
// {
// Console.WriteLine("vogal");
// }
// else
// {
//     Console.WriteLine("Não é vogal");
// }





















//OPERADOR IF ANINHADO 

// int quantidadeEmEstoque = 9;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($" quantidade em estoque: {quantidadeEmEstoque}");


// Console.WriteLine($"é possivel vender?{possivelVenda}");

// if(quantidadeCompra == 0)
// {
//   Console.WriteLine("venda negada !");
// }

// else if(possivelVenda)
// {
//     Console.WriteLine("venda realizada com sucesso !");
// }

// else
// {
//     Console.WriteLine("Venda negada!");
// }

























//OPERADOR CONDICIONAL

// int quantidadeEmEstoque = 10;

// int quantidadeCompra = 11;

// if(quantidadeEmEstoque >= quantidadeCompra)
// {
//     Console.WriteLine("Venda realizada!");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade em estoque");
// }

// int quantidadeEmEstoque = 9;
// int quantidadeCompra = 10;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($" quantidade em estoque: {quantidadeEmEstoque}");


// Console.WriteLine($"é possivel vender?{possivelVenda}");

// if(possivelVenda)
// {
//     Console.WriteLine("venda realizada com sucesso !");
// }

// else
// {
//     Console.WriteLine("Venda negada!");,
// }













//conversão de maneira segura

// string a = "15-";

// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");





// string a = "15";

// int b = Convert.ToInt32(a);

// Console.WriteLine(a);












//ORDEM DOS OPERADORES

// double a = 4 /( 2 + 2);

// Console.WriteLine(a);




















//CASTING IMPLÍCITO


// int a = 10;

// double b = a;








// long a = 5;

// int b = Convert.ToInt32 (a);











// int inteiro = 5;

// string a = inteiro.ToString();

// Console.WriteLine();

















//OPERADORES DE ATRIBUIÇÃO

// int a = 2;
// int b = 5;

// int c = a + b;

//c = c + 5;

//c += 5;

//Console.WriteLine(c);





//CONVERSÃO DE TIPO   Cast-Casting

//int a = Convert.ToInt32 ("5");

//int a = int.Parse("5");

//Console.WriteLine(a);








// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Marcos Paulo";
// pessoa1.Idade = 25;
// pessoa1.Apresentar();