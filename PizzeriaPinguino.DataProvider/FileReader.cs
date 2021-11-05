using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaPinguino.DataProvider
{
    public class FileReader
    {
        private FileValidator validator;

        public FileReader()
        {
            validator = new FileValidator();
        }

        public List<string> Read(string filename) => File.ReadAllLines(filename).Where(x => validator.IsValid(x)).ToList();
    }
}
