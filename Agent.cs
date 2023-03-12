using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock
{
    public class Agent
    {
        public int id { get; set; }
        public string username { get; set; }
        public bool isAdmin { get; set; }
        public override string ToString()
        {
            return this.username;
        }
    }
}
