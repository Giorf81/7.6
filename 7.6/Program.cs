namespace _7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class Car<T1>
    {
        public T1 Engine;

        public virtual void ChangePart<T2>(T2 newPart) { }

    }
    class ElectricEngine
    {

    }
    class GasEngine 
    {
    
    }
    class Battery() { }

    class Differential() { }

    class Wheel() { }


}
