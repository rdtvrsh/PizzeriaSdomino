using PizzeriaPinguino.Model;
using System;

namespace PizzeriaPinguino.Creation
{
    public class ImpastoCreator
    {
        public static Impasto Creation(string impasti) => impasti switch
        {
            "Normale" => new Normale() { Name = "Normale", Price = 0 },
            "Integrale" => new Integrale() { Name = "Integrale", Price = 1 },
            _ => new Normale() { Name = "Normale", Price = 0 }
        };
    }
}
