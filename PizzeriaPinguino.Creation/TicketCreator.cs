using PizzeriaPinguino.DataProvider;
using PizzeriaPinguino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaPinguino.Creation
{
    public class TicketCreator
    {
        public IEnumerable<Pizza> CreaPizza(FileHandler filehandler, Comanda comanda)
        {
            foreach (var ordine in comanda.Ordini)
            {
                (var basePizza, var impasto, var ingredienti) = filehandler.FileSeparator(ordine);
                var pizzabuilder = new PizzaBuilder();
                var pizza = pizzabuilder.CreatePizza(basePizza, impasto, ingredienti);
                yield return pizza;
            }

        }
        public Ticket CreaScontrino(IEnumerable<Pizza> mypizze)
        {

            var scontrino = new Ticket();
            scontrino.listaPizze = mypizze;
            scontrino.Conto = mypizze.Sum(x => x.TotalPrice());
            return scontrino;

        }
    }


}

