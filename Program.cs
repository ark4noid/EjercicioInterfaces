using System;

namespace EjerciciosInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Loro paco = new Loro();
            paco.Hablar();
        }
    }
    interface ICharlatan
    {
        public void Hablar();
    }
    abstract class Animal
    {


    }
    class Loro : Animal, ICharlatan
    {
        public void Hablar()
        {
            Console.WriteLine("BLA BLA, SOY UN LORO, BLA BLA");
        }

    }
    class Delfin : Animal
    {

    }
    class Tortuga : Animal
    {

    }
}
