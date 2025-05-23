using FirstStrike.Models;
using System.Collections.Generic;

namespace FirstStrike
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IDF idf =  IDFGenerator.GenerateIDF();
            Hamas hamas = GeneratorTerrorists.GenerateTerrorists(6);
            Aman mossad = IDFGenerator.GenerateIntel(hamas);
            CommanderConsole console = new CommanderConsole(idf, hamas, mossad);
            console.Menu();
        }
    }
}