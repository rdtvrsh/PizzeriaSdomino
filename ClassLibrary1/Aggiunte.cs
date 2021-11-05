namespace PizzeriaPinguino.Model
{
    public abstract class Aggiunte : IIdentity
    {
        public abstract string Name { get; set; }
        public abstract decimal Price { get; set; }
    }
}

