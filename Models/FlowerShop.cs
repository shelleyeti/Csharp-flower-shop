using System.Collections.Generic;

namespace flower_shop
{
    public class FlowerShop
    {
        public List<Rose> Roses { get; set; }
        public List<Lily> Lilies { get; set; }
        public List<Sunflower> Sunflowers { get; set; }
        public List<Tulip> Tulips { get; set; }

        //Any flower that goes in the Mother's Day Arrangement must have a stem length property
        public List<IStemLength> MothersDayArrangement { get; set; } = new List<IStemLength>
        {
            new Rose() { PetalCount = 50, Price = 3.00 },
            new Sunflower() {PetalCount = 150, Price = 5.00}
        };

        //Any flower that goes in the Birthday Arrangement must have a color property
        public List<IColor> BirthdayArrangement { get; set; } = new List<IColor>
        {
            new Rose() { Color = "Red", Price = 3.00 },
            new Tulip() { Color = "White", Price = 4.00},
            new Lily() { Color = "Purple", Price = 3.00}
        };
    }
}