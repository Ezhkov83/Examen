using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Auto
    {
        string power= "";
        string model = "";
        int price = 0;

        public string Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

    }
}
