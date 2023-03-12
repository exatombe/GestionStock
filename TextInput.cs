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
    public partial class TextInput : TextBox
    {
        public TextInput()
        {
            this.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
            this.Size = new Size(229, 39);
        }
    }
}
