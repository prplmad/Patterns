using BuilderPattern.Product;

namespace BuilderPattern.Builders
{
    public class BeefBurgerBuilder : IBurgerBuilder
    {
        private Burger burger;

        public BeefBurgerBuilder()
        {
            burger = new Burger();
            burger.BurgerType = "Beef Burger";
        }

        public void SetSize(string size)
        {
            burger.Size = size;
        }

        public void AddCheese()
        {
            burger.Cheese = true;
        }

        public void AddCutlet()
        {
            burger.BeefCutlet = true;
        }

        public void AddJalapeno()
        {
            burger.Jalapeno = true;
        }

        public void AddOnion()
        {
            burger.Onion = true;
        }

        public void AddSauce()
        {
            burger.Sauce = true;
        }

        public void AddTomatoo()
        {
            burger.Tomatoo = true;
        }

        public Burger GetBurger()   
        {
            return burger;
        }
    }
}
