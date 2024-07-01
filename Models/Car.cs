using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace syntax_indentation_dotnet.Models
{
    public class Car
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public void ShowCar()
        {
            Console.WriteLine($"O carro {Name} da marca {Brand}, cor {Color} e ano {Age} ainda está disponível.");
        }
    }
}