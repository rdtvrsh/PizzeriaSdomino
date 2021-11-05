using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaPinguino.DataProvider
{
    public class FolderReader
    {
        public IEnumerable<string> GetFilesCsv(string path)
        {
            var directory = new DirectoryInfo(path);
            return directory.GetFiles("*.csv").Select(x => x.FullName);

        }
    }
}