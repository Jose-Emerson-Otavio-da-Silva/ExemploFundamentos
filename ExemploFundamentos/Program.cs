using ExemploFundamentos.Common.Models;

Calculadora calculadora = new();

calculadora.RaizQuadrada(9);

// calculadora.Seno(30);
// calculadora.Coseno(30);
// calculadora.Tangente(30);



// calculadora.Somar(10, 30);
// calculadora.Subtrair(10,50);
// calculadora.Multiplicar(15,45);
// calculadora.Dividir(2,2);










// DateTime dateAtual = DateTime.Now;

// Console.WriteLine("Data e hora atual: " +
// DateTime.Now.AddHours(3).AddMinutes(30));

// string a = 5.ToString();
Pessoas pessoas = new()
{
    Nome = "Emerson",
    Idade = 40
};

pessoas.Apresentar();