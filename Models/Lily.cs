using System;

namespace flower_shop
{
    public class Lily : Flower, IDescribable, IColor
    {
        public string Color { get; set; }

        public string Describe()
        {
            return $"A beautiful {Color} Lily.";
        }
    }
}