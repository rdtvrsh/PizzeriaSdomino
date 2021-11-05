using System;

namespace PizzeriaPinguino.Model
{
    public interface IIdentity
    {
        string Name { get; set; }
        decimal Price { get; set; }
    }
}

