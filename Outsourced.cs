using System;

namespace C968
{

    public class OutsourcedPart : Part
    {
        private string companyName;
        public string CompanyName { get; set; }
        public OutsourcedPart() { }
        public OutsourcedPart(int partID, string name, int instock, decimal price, int max, int min)
        {
            PartID = partID;
            Name = name;
            Inventory = instock;
            Price = price;
            Max = max;
            Min = min;
        }
        public OutsourcedPart(int partID, string name, int instock, decimal price, int max, int min, string companyName)
        {
            PartID = partID;
            Name = name;
            Inventory = instock;
            Price = price;
            Max = max;
            Min = min;
            CompanyName = companyName;
          
        }
    }
}