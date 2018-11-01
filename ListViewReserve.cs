using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management3
{
    class ListViewReserve : ListViewBase
    {
        public ListViewReserve() : base()
        {
            SutunEkle();

        }

        public override void GrideEkle(object obj)
        {
            ListViewItem lvi = new ListViewItem();

            lvi.Text = ((Reserve)obj).book_id.ToString();
            lvi.SubItems.Add(((Reserve)obj).Student_id.ToString());
            lvi.SubItems.Add(((Reserve)obj).id.ToString());
            lvi.SubItems.Add(((Reserve)obj).DateTaken);
            lvi.SubItems.Add(((Reserve)obj).DueDate);
            lvi.SubItems.Add(((Reserve)obj).fine);


            this.Items.Add(lvi);

        }

        public override void SutunEkle()
        {
            this.Columns.Add("id");
            this.Columns.Add("student_id");
            this.Columns.Add("Book_id");
            this.Columns.Add("DateTaken");
            this.Columns.Add("DueDate");
            this.Columns.Add("fine");

            this.Columns[0].Width = this.Width / 3;
            this.Columns[1].Width = this.Width / 3;
            this.Columns[2].Width = this.Width / 3;
            this.Columns[3].Width = this.Width / 3;
            this.Columns[4].Width = this.Width / 3;
            this.Columns[5].Width = this.Width / 3;

        }
    }
}
