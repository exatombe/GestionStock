using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public int mtbf { get; set; }
        public string serial { get; set; }
        public override string ToString()
        {
            if (this.serial != null)
            {
                return this.name + " (" + this.serial + ")";
            }
            else
            {
                return this.name;
            }
        }
    }
}
