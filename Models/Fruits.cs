using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace syntax_indentation_dotnet.Models
{
    public class Fruits
    {
        public string Name { get; set; }
        public int Price { get; set; }

    public void Apresentation()
    {
        Console.WriteLine($"Nós temos as seguintes frutas: {Name}, o valor é de: R${Price}");
    }

    }
}