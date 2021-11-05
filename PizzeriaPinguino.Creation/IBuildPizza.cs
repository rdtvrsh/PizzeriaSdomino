using PizzeriaPinguino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaPinguino.Creation
{
    public interface IBuildPizza
    {
       Pizza CreatePizza(string basepizza, string impastopizza, IList<string> aggiuntepizza);
    }
}
