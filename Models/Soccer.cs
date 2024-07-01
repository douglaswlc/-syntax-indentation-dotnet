using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace syntax_indentation_dotnet.Models
{
    public class Soccer
    {
        public string Time { get; set; }
        public string Campeonato { get; set; }
        public int Jogadores { get; set; }

        public void ShowSoccer()
        {
            Console.WriteLine($"Meu time é o {Time}, disputa o campeonato {Campeonato} e tem {Jogadores} jogadores.");
        }
    }
}