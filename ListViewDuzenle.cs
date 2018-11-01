using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management3
{
    class ListViewDuzenle : ListViewBaseDecorator
    {
        ColumnHeader ch = null;
        IView owner;
        public ListViewDuzenle(IView owner, ListViewBase listView)
        {
            this.owner = owner;
            this.listView = listView;
            foreach (ListViewItem item in listView.Items)
            {
                SatirlaraDuzenleSutunuEkle(item.Index);
            }
        }
        public override void GrideEkle(object obj)
        {
            listView.GrideEkle(obj);
            SatirlaraDuzenleSutunuEkle(listView.Items.Count - 1);

            // listView.Items.Add(lvi);
        }

        private void SatirlaraDuzenleSutunuEkle(int index)
        {
            DuzenleSutunuEkle();

            ListViewItem lvi = listView.Items[index];
            ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
            subItem.Text = ch.Text;
            subItem.Font = new System.Drawing.Font("Georgia", 10,
                System.Drawing.FontStyle.Underline);
            subItem.ForeColor = System.Drawing.Color.Blue;
            lvi.UseItemStyleForSubItems = false;
            lvi.SubItems.Add(subItem);

        }

        private void DuzenleSutunuEkle()
        {
            if (ch == null)
            {
                ch = new ColumnHeader();
                ch.Text = "Düzenle";
                listView.Columns.Add(ch);
                listView.MouseClick += owner.owner_MouseClick;
            }

        }



        public override void SutunEkle()
        {
            listView.SutunEkle();
        }
    }
}
