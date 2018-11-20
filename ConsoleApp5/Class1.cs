using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{

    public class Farm
    {
        public string Name { get; set; }
        public double Square { get; set; }
        public List<GardenBed> GardenBeds { get; set; }
        public List<Building> Buildings { get; set; }
    }


    
}
