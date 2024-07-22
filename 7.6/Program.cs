namespace _7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class Engine() { }
    class CarPart() { }
    class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart{ }

    }
    class ElectricEngine : Engine
    {

    }
    class GasEngine : Engine
    {
    
    }
    class Battery() : CarPart{ }

    class Differential() : CarPart{ }

    class Wheel() : CarPart { }


}
