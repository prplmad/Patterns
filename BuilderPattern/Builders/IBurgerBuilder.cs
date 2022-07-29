using BuilderPattern.Product;

namespace BuilderPattern.Builders
{
    public interface IBurgerBuilder
    {
        public void SetSize(string size);
        public void AddCheese();
        public void AddOnion();
        public void AddTomatoo();
        public void AddCutlet();
        public void AddJalapeno();
        public void AddSauce();

        public Burger GetBurger();
    }
}
