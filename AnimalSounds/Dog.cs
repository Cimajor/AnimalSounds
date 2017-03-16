using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    class Dog : Animals, Isound
    {

        private string name;
        private string color;

        public void Sounds()
        {
            Console.WriteLine("Gav");
        }

        public string Name    // the Name property
        {
            get { return name; }
            set { name = value; }

        }

        public string Color    // the Color property
        {
            get { return color; }
            set { color = value; }
        }
    }
}
