namespace HandsOnDI
{
    class Car
    {
        public string model;
        public string color;
        public Car(string model,string color) { 
            this.model = model;
            this.color = color;
        }
    }
    class ShowRoom
    {
        Car c;

        //public ShowRoom()
        //{
        //    c = new Car();
        //}
        //Constructor Injection
        public ShowRoom(Car c)
        {
            this.c = c;
        }
        public void Display()
        {
            Console.WriteLine($"Model:{c.model} Color:{c.color}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowRoom obj = new ShowRoom(new Car("i20", "blue"));
            obj.Display();
        }
    }
}
