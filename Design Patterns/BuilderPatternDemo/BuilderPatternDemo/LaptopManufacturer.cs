namespace BuilderPatternDemo
{
    /// <summary>
    /// Director class
    /// </summary>
    class LaptopManufacturer
    {
        public void BuildLaptop(ILaptopBuilder laptopBuilder)
        {
            laptopBuilder.AddModelNumber();
            laptopBuilder.AddDisplay();
            laptopBuilder.AddRam();
            laptopBuilder.AddGraphicsCard();

            //So here we can customize the builder method according to builder type
            //Hence Touch screen wont be available for Basic Laptop
            if(laptopBuilder is BasicLaptopBuilder == false)
                laptopBuilder.AddTouchScreen();
        }
    }
}