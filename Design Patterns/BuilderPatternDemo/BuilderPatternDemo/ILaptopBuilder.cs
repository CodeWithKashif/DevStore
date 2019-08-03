namespace BuilderPatternDemo
{
    /// <summary>
    /// Builder interface
    /// </summary>
    interface ILaptopBuilder
    {
        void AddModelNumber();
        void AddDisplay();
        void AddRam();
        void AddGraphicsCard();
        void AddTouchScreen();

        Laptop GetLaptop();
    }
}