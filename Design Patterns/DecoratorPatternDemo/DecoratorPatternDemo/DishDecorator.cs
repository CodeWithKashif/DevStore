namespace DecoratorPatternDemo
{
    /// <summary>
    /// https://exceptionnotfound.net/decorator-the-daily-design-pattern/
    /// The abstract Decorator class.  
    /// </summary>
    abstract class DishDecorator : Dish
    {
        protected Dish Dish;

        protected DishDecorator(Dish dish)
        {
            Dish = dish;
        }

        public override void Display()
        {
            Dish.Display();
        }

    }
}