using System;

namespace flower_shop
{
    public class Sunflower : Flower, IDescribable, IStemLength
    {
        public double StemLength { get; set; }
        public int PetalCount { get; set; }

        public string Describe()
        {
            return $"This Sunflower has a lovey {PetalCount} number of petals.";
        }
    }
}