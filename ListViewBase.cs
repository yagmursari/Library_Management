using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management3
{
    public abstract class ListViewBase : ListView
    {
        public ListViewBase()
        {
            GridTemizle();
            setProperties();
        }
        public abstract void GrideEkle(object obj);
        public abstract void SutunEkle();

        public void setProperties()
        {
            this.View = View.Details;
            this.GridLines = true;
            this.FullRowSelect = true;
            this.BringToFront();
            this.Dock = DockStyle.Fill;

        }
        public void GridTemizle()
        {
            this.Items.Clear();
        }

    }
}
