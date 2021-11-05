using PizzeriaPinguino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaPinguino.Creation
{
    public class AggiunteCreator
    {
        public static Aggiunte Creation(string aggiunte) => aggiunte switch
        {
            "ProsciuttoCotto" => new ProsciuttoCotto() { Name = "ProsciuttoCotto", Price = 1 },
            "Funghi" => new Funghi() { Name = "Funghi", Price = 2 },
            "ProsciuttoCrudo" => new ProsciuttoCrudo() { Name = "ProsciuttoCrudo", Price = 2 },
            "Ananas" => new Ananas() { Name = "Ananas", Price = 0 },
            _ => throw new Exception("Nessuna Aggiunta")
        };
    }
}
