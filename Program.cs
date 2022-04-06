using System;

Console.WriteLine("Entre com o seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Entre com o sua altura (em metros) :");
float altura = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Entre com o seu peso. Exemplo: 67,7");
float peso = Convert.ToSingle(Console.ReadLine());

Pessoa p1 = new Pessoa(nome, altura, peso);

double imc = peso / (altura*altura);

Console.WriteLine("{0} sua altura é {1} e seu peso {2}", nome, altura, peso);
Console.WriteLine ("Seu IMC é {0}", imc);