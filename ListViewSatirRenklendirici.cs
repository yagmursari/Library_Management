using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management3
{
    class ListViewSatirRenklendirici : ListViewBaseDecorator
    {
        Color c1, c2, siradaki;
        public ListViewSatirRenklendirici(ListViewBase listView,
            Color color1, Color color2)
        {
            c1 = color1;
            c2 = color2;
            siradaki = c2;
            this.listView = listView;
        }


        public override void GrideEkle(object obj)
        {
            listView.GrideEkle(obj);
            listView.Items[listView.Items.Count - 1].BackColor = SiradakiRenk();
        }
        private Color SiradakiRenk()
        {
            if (c1 == siradaki)
            {
                siradaki = c2;
            }
            else
            {
                siradaki = c1;
            }
            return siradaki;
        }
        public override void SutunEkle()
        {
            listView.SutunEkle();
        }
    }
}

