using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClownsAndInterfacesTest
{
    internal interface IClown
    {
        protected static Random random = new Random();
        private static int carCapacity = 12;

        string FunnyThingIHave { get; }
        public static int CarCapacity
        {
            get { return carCapacity; }
            set
            {
                if (value > 10) carCapacity = value;
                else Console.Error.WriteLine($"Warning: Car capacity {value} is too small");
            }
        }

        void Honk();
        public static string ClownCarDescription()
        {
            return $"A clown car with {random.Next(CarCapacity / 2, CarCapacity)} clowns";
        }
    }

    interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }

        void ScareLittleChildren();
        void ScareAdults()
        {
            Console.WriteLine($@"I am an ancient evil that will haunt your dreams.
Behold my terrifying necklace with {random.Next(4, 10)} of my last victim's fingers.

Oh, also, before I forget...");
            ScareLittleChildren();
        }
    }
}
