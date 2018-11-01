using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management3
{
    class ListViewLibrarian : ListViewBase
    {
        public ListViewLibrarian() : base()
        {
            SutunEkle();
        }

        public override void GrideEkle(object obj)
        {
            ListViewItem lvi = new ListViewItem();

            lvi.Text = ((Librarian)obj).librarian_id.ToString();
            lvi.SubItems.Add(((Librarian)obj).equipments_id.ToString());
            lvi.SubItems.Add(((Librarian)obj).id.ToString());
            lvi.SubItems.Add(((Librarian)obj).librarian_Name);
            lvi.SubItems.Add(((Librarian)obj).librarian_password);
            lvi.SubItems.Add(((Librarian)obj).book_id.ToString());
            this.Items.Add(lvi);

        }

        public override void SutunEkle()
        {
            this.Columns.Add("librarian_id");
            this.Columns.Add("id");
            this.Columns.Add("book_id");
            this.Columns.Add("librarian_Name");
            this.Columns.Add("librarian_password");
            this.Columns.Add("equipment_id");
            this.Columns[0].Width = this.Width / 3;
            this.Columns[1].Width = this.Width / 3;
            this.Columns[2].Width = this.Width / 3;
            this.Columns[3].Width = this.Width / 3;
            this.Columns[4].Width = this.Width / 3;
            this.Columns[5].Width = this.Width / 3;
        }
    }
}
