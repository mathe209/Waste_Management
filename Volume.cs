using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Volume
    {
        public decimal dm3 {  get; private set; }
        public decimal Multiplier { get; private set; }
        public decimal ReducedVolume { get; private set; }
        public Volume(decimal _dm3, decimal _multiplier) 
        {
            //setting the constructors params to properties
            this.dm3 = _dm3;
            this.Multiplier = _multiplier;
            this.ReducedVolume = _dm3*_multiplier;
        }

        public Volume(decimal v)
        {
        }

        public static Volume operator +(Volume v1, Volume v2) //overloaded operator
        {
            //calculates the resultant volumes, with the multiplier being weighted
            decimal totalDm3 = v1.dm3 + v2.dm3;
            decimal weightedMultiplier = ((v1.dm3 * v1.Multiplier) + (v2.dm3 * v2.Multiplier)) / totalDm3; //I'm not sure of this formula
            //returns the total dm3, weighted multiplier, and reduced volume for the two volume objects
            return new Volume(totalDm3, weightedMultiplier);
        }
    }
}
