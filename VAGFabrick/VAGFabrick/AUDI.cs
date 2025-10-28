using System;
using System.Xml.Linq;
using System.Collections.Generic;
using VAGFabric;

namespace VAGFabric
{
    public class AUDI : VAG
    {
        public AUDI() { }
        public AUDI(string name, int quantity, int tankVolume, string carCase, double fuelQuantity, double fuelConsumption)
            : base(name, quantity, tankVolume, carCase, fuelQuantity, fuelConsumption)
        { }
    }
}