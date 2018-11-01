using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management3
{
    public class ListViewStudent : ListViewBase
    {
        public ListViewStudent() : base()
        {
            SutunEkle();
        }

        public override void GrideEkle(object obj)
        {
            ListViewItem lvi = new ListViewItem();

            lvi.Text = ((Student)obj).student_id.ToString();
            lvi.SubItems.Add(((Student)obj).student_firstname);
            lvi.SubItems.Add(((Student)obj).student_lastname);
            lvi.SubItems.Add(((Student)obj).student_password.ToString());
            lvi.SubItems.Add(((Student)obj).id.ToString());
            lvi.SubItems.Add(((Student)obj).reserve_equipments_id.ToString());

            this.Items.Add(lvi);

        }

        public override void SutunEkle()
        {
            this.Columns.Add("Student_fistname");
            this.Columns.Add("Student_lastname");
            this.Columns.Add("student_id");
            this.Columns.Add("Student_password");
            this.Columns.Add("id");
            this.Columns.Add("reserve_equipment_id");
            this.Columns[0].Width = this.Width / 3;
            this.Columns[1].Width = this.Width / 3;
            this.Columns[2].Width = this.Width / 3;
            this.Columns[3].Width = this.Width / 3;
            this.Columns[4].Width = this.Width / 3;
            this.Columns[5].Width = this.Width / 3;


        }
    }
}
