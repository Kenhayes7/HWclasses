using System;

namespace HWclasses
{
    class Program
    {
        static void Main(string[] args)
        {
            dreamCar DC07 = new dreamCar("Equinox", "black");
            DC07.superSpeed(75);
            DC07.seating(7);

            dreamCar DC11 = new dreamCar("Range Rover", "black");
            DC11.superSpeed(68);
            DC11.seating(5);
        }
    }

    public class dreamCar
    {
        public string _brandName { set; get; }
        public string _color { set; get; }

        public dreamCar(string carName, string color)
        {
            _brandName = carName;
            _color = color;
            Console.WriteLine("This is about my dream car");
            Console.WriteLine("My dream car is a {0}", carName);
            Console.WriteLine("The color will be {0}", color);
        }

        public void superSpeed(int speed)
        {
            speed = speed * 2;
            Console.WriteLine("The max speed is {0}", speed);
        }

        public void seating(int seat)
        {
            Console.WriteLine("It seats up to {0}", seat);
        }
    }
}
