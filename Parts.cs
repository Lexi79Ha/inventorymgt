using System;

namespace C968
{
    public abstract class Part
    {
        private int partID;
        private string name;
        private int instock;
        private decimal price;
        private int max;
        private int min;

        public int PartID { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public decimal Price { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }


    }
}