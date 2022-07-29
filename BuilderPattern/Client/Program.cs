using BuilderPattern.Builders;
using BuilderPattern.Director;

BurgerBuildDirector direcror = new BurgerBuildDirector();

var burger1 = direcror.ConstructBurger(new BeefBurgerBuilder(), "Big");
var burger2 = direcror.ConstructBurger(new ChickenBurgerBuilder(), "Small");

Console.WriteLine("Размер первого бургера: " + burger1.Size);
Console.WriteLine("Размер второго бургера: " + burger2.Size);
Console.WriteLine("У первого бургера котлета из говядины : " + burger1.BeefCutlet);
Console.WriteLine("У второго бургера котлета из говядины : " + burger2.BeefCutlet);
Console.WriteLine("У второго бургера котлета из курицы : " + burger2.ChickenCutlet);

