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
        public Products() 
        {
            //a list is instantiated
            lstproducts = new List<Product>();

        }
        //declaring an int indexer ('below the constructor')
        public Product this[int indxr] 
        {
            get
            {
                return lstproducts[indxr];
            }
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
            Volume resVol=null;
            Volume volume = lstproducts[0].Volume;
            for (int indxr = 1; indxr < lstproducts.Count; indxr++)
            {

                Volume _volume = lstproducts[indxr].Volume;
                resVol = volume + _volume;
                volume = resVol;
                
            }
            return resVol.dm3;
        }
        public decimal TotalReducedVolumeC()
        {
            Volume resVol = null;
            Volume volume = lstproducts[0].Volume;
            for (int indxr = 1; indxr < lstproducts.Count; indxr++)
            {

                Volume _volume = lstproducts[indxr].Volume;
                resVol = volume + _volume;
                volume = resVol;

            }
            return resVol.ReducedVolume;
        }
    }


}
