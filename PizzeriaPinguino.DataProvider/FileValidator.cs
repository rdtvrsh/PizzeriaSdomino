using System;

namespace PizzeriaPinguino.DataProvider
{
    public class FileValidator
    {
        public bool IsValid(string str) => !str.StartsWith(";;");
    }
}
