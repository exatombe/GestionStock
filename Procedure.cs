using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock
{
    public class Procedure
    {
        public int id
        {
            get; set;
        }
        public Agent agent
        {
            get; set;
        }
        public DateTime date
        {
            get; set;
        }

        public string commentaire
        {
            get; set;
        }
        public Customer client
        {
            get; set;
        }
        public Product produit
        {
            get; set;
        }
        public override string ToString()
        {
            return this.agent.username;
        }
    }
}
