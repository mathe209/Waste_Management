using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Product
    {
        public ProductType Type { get; private set; }
        public Volume Volume { get; private set; }
        public Product(ProductType _type, decimal _volume, decimal _percent) 
        {
            //instantiates a new volume objects and sets it to the Volume property
            Type = _type;
            Volume volume = new Volume(_volume, _percent);
            this.Volume = volume;
        }
        public string ToString()
        {
            //tab delimited string
            return Type + "\t\t\t" + Volume.dm3 + "\t\t\t" + Volume.ReducedVolume;
        }
    }
}
