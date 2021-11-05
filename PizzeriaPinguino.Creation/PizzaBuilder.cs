using PizzeriaPinguino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaPinguino.Creation
{
    public class PizzaBuilder : IBuildPizza
    {
       
        public Pizza CreatePizza(string basepizza, string impastopizza, IList<string> aggiuntepizza)
        {
            var pizza = new Pizza();
            pizza.basepizza = BaseCreator.Creation(basepizza);
            pizza.impastopizza = ImpastoCreator.Creation(impastopizza);
            foreach (var elem in aggiuntepizza)
            {
                var aggiunta = AggiunteCreator.Creation(elem);
                pizza.aggiunte.Add(aggiunta);
              
            }
                return pizza;
        }
    }
}
