using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management3
{
    class ListViewBook : ListViewBase
    {
        public ListViewBook() : base()
        {
            SutunEkle();
        }
        public override void GrideEkle(object obj)
        {
            ListViewItem lvi = new ListViewItem();

            lvi.Text = ((Book)obj).Book_id.ToString();
            lvi.SubItems.Add(((Book)obj).id.ToString());
            lvi.SubItems.Add(((Book)obj).BookAuthor);
            lvi.SubItems.Add(((Book)obj).BookName);

            this.Items.Add(lvi);
        }

        public override void SutunEkle()
        {
            this.Columns.Add("id");
            this.Columns.Add("Book_ID");
            this.Columns.Add("BookAuthor");
            this.Columns.Add("BookName");
            this.Columns[0].Width = this.Width / 3;
            this.Columns[1].Width = this.Width / 3;
            this.Columns[2].Width = this.Width / 3;
            this.Columns[3].Width = this.Width / 3;


        }
    }



}