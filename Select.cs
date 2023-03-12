using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GestionStock
{
    public partial class Select : ComboBox
    {
        public Select()
        {
            this.Size = new Size(229, 39);
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
        }

    }
}
