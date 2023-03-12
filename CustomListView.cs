using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class CustomListView : ListView
    {
        public CustomListView()
        {
            this.Activation = ItemActivation.OneClick;
            this.AllowColumnReorder = true;
            this.BackColor = SystemColors.InactiveCaption;
            this.BorderStyle = BorderStyle.None;
            this.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullRowSelect = true;
            this.GridLines = true;
            this.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            this.HideSelection = false;
            this.HoverSelection = true;
            this.MultiSelect = false;
            this.Name = "usersList";
            this.Size = new Size(969, 420);
            this.TabIndex = 0;
            this.UseCompatibleStateImageBehavior = false;
            this.View = View.Details;
            this.DrawItem += new DrawListViewItemEventHandler(this.onElementAdded);
            this.OwnerDraw = true;
            this.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(this.onColumnHeaderAdded);
            // When columns header are added we fix the width of the columns 
            this.HandleCreated += new EventHandler(this.onControlBuild);
            this.ClientSizeChanged += new EventHandler(this.onControlBuild);
        }

        
        private void onColumnHeaderAdded(object sender,
                                            DrawListViewColumnHeaderEventArgs e)
        {
            // add the background color #1687FA to the header
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(168, 215, 250)), e.Bounds);
            e.DrawText();

        }
        
        private void onElementAdded(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void onControlBuild(object sender, EventArgs e)
        {
            // we fix the width of the columns
            foreach (ColumnHeader column in this.Columns)
            {
                column.Width = this.Width / this.Columns.Count;
            }
        }

    }
}
