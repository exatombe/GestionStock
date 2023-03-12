using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace GestionStock
{
    internal class CustomButton : Button
    {

        public int radius = 20;
        [Category("Appearance"), Browsable(true), Description("The color of the button when the mouse is over it"), DefaultValue(20)]
        public int borderRadius
        {
            get
            {
                return this.radius;
            }
            set
            {
                this.radius = value < 0 ? 1 : value;
                this.Invalidate();
            }
        }

        public CustomButton()
        {
            this.BackColor = Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(115, 86);
            this.Size = new System.Drawing.Size(234, 51);
            this.UseVisualStyleBackColor = false;
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            // make border radius 20 pixels
            path.AddArc(0, 0, this.radius, this.radius, 180, 90);
            path.AddArc(this.Width - this.radius, 0, this.radius, this.radius, 270, 90);
            path.AddArc(this.Width - this.radius, this.Height - this.radius, this.radius, this.radius, 0, 90);
            path.AddArc(0, this.Height - this.radius, this.radius, this.radius, 90, 90);
            this.Region = new Region(path);
            base.OnPaint(e);
        }
    }
}
