namespace BuilderPatternDemo
{
    /// <summary>
    /// Concrete Builder class - implements 'Builder' interface
    /// </summary>
    class GamingLaptopBuilder : ILaptopBuilder
    {
        private readonly Laptop _laptop = new Laptop();

        public void AddModelNumber()
        {
            _laptop.ModelNumber = "Gaming1001";
        }

        public void AddDisplay()
        {
            _laptop.Display = "Full HD display";
        }

        public void AddRam()
        {
            _laptop.Ram = "16 GB";
        }

        public void AddGraphicsCard()
        {
            _laptop.GraphicsCard = "Nvidia GeForce";
        }

        public void AddTouchScreen()
        {
            _laptop.TouchScreen = "Surface Wave Touch";
        }

        public Laptop GetLaptop()
        {
            return _laptop;
        }
    }
}