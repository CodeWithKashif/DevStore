namespace BuilderPatternDemo
{
    /// <summary>
    /// ConcreteBuilder class - implements 'Builder' interface
    /// </summary>
    class BasicLaptopBuilder : ILaptopBuilder
    {
        private readonly Laptop _laptop = new Laptop();

        public void AddModelNumber()
        {
            _laptop.ModelNumber = "Basic1001";
        }

        public void AddDisplay()
        {
            _laptop.Display = "SD Display";
        }

        public void AddRam()
        {
            _laptop.Ram = "2GB";
        }

        public void AddGraphicsCard()
        {
            _laptop.GraphicsCard = "No graphics card";
        }

        public void AddTouchScreen()
        {
            _laptop.TouchScreen = "NO";
        }

        public Laptop GetLaptop()
        {
            return _laptop;
        }
    }
}