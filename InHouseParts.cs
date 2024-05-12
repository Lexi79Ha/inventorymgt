using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968
{
    public class InHousePart : Part
    {
      private int machID;
      public int MachineID { get; set; }
      public InHousePart() { }
      public InHousePart(int partID, string name, int instock, decimal price, int max, int min)
            {
                PartID = partID;
                Name = name;
                Inventory = instock;
                Price = price;
                Max = max;
                Min = min;

            }
      public InHousePart(int partID, string name, int instock, decimal price, int max, int min,int machID)
            {
                PartID = partID;
                Name = name;
                Inventory = instock;
                Price = price;
                Max = max;
                Min = min;
                MachineID = machID;
            }
        }
    }
