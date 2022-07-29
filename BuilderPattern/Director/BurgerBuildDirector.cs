using BuilderPattern.Builders;
using BuilderPattern.Product;

namespace BuilderPattern.Director
{
    public class BurgerBuildDirector
    {
        public Burger ConstructBurger(IBurgerBuilder builder ,string size)
        {
            builder.SetSize(size);
            builder.AddCutlet();
            builder.AddCheese();
            builder.AddJalapeno();
            builder.AddOnion();
            builder.AddSauce();
            builder.AddTomatoo();
            
            return builder.GetBurger();
        }
    }
}
