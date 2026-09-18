using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClownsAndInterfacesTest
{
    internal class FunnyFunny : IClown
    {
        private string funnyThingIHave;

        public string FunnyThingIHave { get { return funnyThingIHave; } }

        public void Honk()
        {
            Console.WriteLine($"Hi kids! I have a {FunnyThingIHave}.");
        }

        public FunnyFunny(string funnyThing)
        {
            funnyThingIHave = funnyThing;
        }
    }

    class ScaryScary : FunnyFunny, IScaryClown
    {
        private short scaryThingCount;

        public string ScaryThingIHave { get { return scaryThingCount + " spiders"; } }

        public void ScareLittleChildren()
        {
            Console.WriteLine($"Boo! Gotcha! Look at my {ScaryThingIHave}!");
        }

        public ScaryScary(string funnyThing, short scaryThingCount) : base(funnyThing)
        {
            this.scaryThingCount = scaryThingCount;
        }
    }
}
