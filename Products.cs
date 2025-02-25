using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Products //container class
    {
        private List<Product> lstproducts;
        //adding an indexer
        public Product this[int i] => lstproducts[i];

        public Products() 
        {
            //a list is instantiated
            lstproducts = new List<Product>();

        }
        public void Add(Product _product)
        {
            lstproducts.Add(_product);
        }
        public void Clear()
        {
            lstproducts.Clear();
        }
        public List<Product> ToList()
        {
            //removed the ToList() method
            return lstproducts;
        }
        public decimal TotalOriginalVolumeA()
        {
            //looping through the list and summing the volumes
            decimal volume = 0;
            foreach (var item in lstproducts)
            {
                volume += item.Volume.dm3;
            }
            return volume;
            
        }
        public decimal TotalReducedVolumeA()
        {
            //looping through the list and summing the reduced volumes
            decimal redVolume = 0;
            foreach(var item in lstproducts)
            {
                redVolume += item.Volume.ReducedVolume;
            }
            return redVolume;
        }
        public decimal TotalOriginalVolumeB()
        {
            //using lynq to sum all the volumes
            return lstproducts.Sum(x => x.Volume.dm3);
        }
        public decimal TotalReducedVolumeB()
        {
            //using lynq to sum all the reduced volumes
            return lstproducts.Sum(x =>x.Volume.ReducedVolume);
        }
        public decimal TotalOriginalVolumeC()
        {
            Volume v1 = lstproducts[0].Volume;
            Volume v2 = lstproducts[1].Volume;
            Volume v3 = lstproducts[2].Volume;
            Volume v4 = lstproducts[3].Volume;
            Volume v5 = lstproducts[4].Volume;

            Volume total1 = v1 + v2;
            Volume total2 = v3 + v4;
            Volume total3 = total2 + v5;
            
            return decimal.Parse(total3.dm3.ToString());

        }
        public decimal TotalReducedVolumeC()
        {
            //creating 5 volume instances and adding them, but cant do so dynamically(issue)
            Volume v1 = lstproducts[0].Volume;
            Volume v2 = lstproducts[1].Volume;
            Volume v3 = lstproducts[2].Volume;
            Volume v4 = lstproducts[3].Volume;
            Volume v5 = lstproducts[4].Volume;

            Volume total1 = v1 + v2;
            Volume total2 = v3 + v4;
            Volume total3 = total2 + v5;
            //returning the reduced volume property of the 'resultant' volume
            return decimal.Parse(total3.ReducedVolume.ToString());
        }
    }


}
