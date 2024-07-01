using syntax_indentation_dotnet.Models;

// Person pessoa1 = new Person
// {
//     Name = "Douglas",
//     Age = 29
// };

// pessoa1.Apresentar();

// Car car1 = new Car
// {
//   Name = "Sandeiro",
//   Brand = "Renault",
//   Color = "Preto",
//   Age = 2017
// };

// car1.ShowCar();

// Fruits fruits = new Fruits();

// fruits.Name = "Abacaxi";
// fruits.Name = "Maça";
// fruits.Name = "Banana";
// fruits.Name = "Pera";

// fruits.Price = 2;
// fruits.Price = 3;
// fruits.Price = 4;
// fruits.Price = 5;

// fruits.Apresentation();

// Soccer soccer1 = new Soccer
// {
//   Time = "Palmeiras",
//   Campeonato = "Libertadores",
//   Jogadores = 11
// };

// soccer1.ShowSoccer();

// string apresentacao = "Hello world";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável: " + quantidade);
// Console.WriteLine("Valor da variável: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável: " + preco);
// Console.WriteLine("Valor da variável: " + condicao);

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));