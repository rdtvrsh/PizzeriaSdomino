using PizzeriaPinguino.Model;
using System.Collections.Generic;
using System.Linq;

namespace PizzeriaPinguino.DataProvider
{
    public class ReadAllOrdini
    {
        public IEnumerable<Comanda> GetComanda()
        {
            var folderreader = new FolderReader();
            var filelist = folderreader.GetFilesCsv("boh");
            var filereader = new FileReader();
            foreach (var f in filelist)
            {
                var comanda = new Comanda() { Ordini = filereader.Read(f) };
                yield return comanda;
            }
        }

        //public static Ticket CreaScontrino(IEnumerable<Pizza> mypizze)
        //{
        //    var scontrino = new Ticket();
        //    scontrino.listaPizze = mypizze;
        //    scontrino.Conto = mypizze.Sum(x => x.TotalPrice());
        //    return scontrino;
        //}




        //public static IEnumerable<Pizza> CreaPizza(FileHandler filehandler, Comanda comanda)
        //{
        //    foreach (var ordine in comanda.Ordini)
        //    {
        //        (var basePizza, var impasto, var ingredienti) = filehandler.FileSeparator(ordine);
        //        var pizzabuilder = new PizzaBuilder();
        //        var pizza = pizzabuilder.CreatePizza(basePizza, impasto, ingredienti);
        //        yield return pizza;
        //    }

        //}
    }

}