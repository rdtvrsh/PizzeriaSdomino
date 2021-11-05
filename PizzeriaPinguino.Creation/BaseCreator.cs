using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaPinguino.Model;

namespace PizzeriaPinguino.Creation
{
    public class BaseCreator
    {
        public static Base Creation(string basi) => basi switch
        {
            "Margherita" => new Margherita() {Name="Margherita",Price=5 },
            "Pepperoni" => new Pepperoni() { Name = "Pepperoni", Price = 7 },
            "Napoletana" => new Napoletana() { Name = "Napoletana", Price = 3 },
            _ => new Margherita() { Name = "Margherita", Price = 5 }
        };
    }
}
