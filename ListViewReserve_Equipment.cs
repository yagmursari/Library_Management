using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management3
{
    public class ListViewReserve_Equipment : ListViewBase
    {
        public ListViewReserve_Equipment() : base()
        {
            SutunEkle();
        }
        public override void GrideEkle(object obj)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = ((Reserve_Equipment)obj).equipments_id.ToString();
            lvi.SubItems.Add(((Reserve_Equipment)obj).student_id.ToString());
            lvi.SubItems.Add(((Reserve_Equipment)obj).id.ToString());
            lvi.SubItems.Add(((Reserve_Equipment)obj).DateDue_Equip);
            lvi.SubItems.Add(((Reserve_Equipment)obj).DateTaken_Equip);

            this.Items.Add(lvi);
        }

        public override void SutunEkle()
        {

            this.Columns.Add("DateDue");
            this.Columns.Add("DateTaken");
            this.Columns.Add("id");
            this.Columns.Add("student_id");
            this.Columns.Add("equipment_id");

            this.Columns[0].Width = this.Width / 3;
            this.Columns[1].Width = this.Width / 3;
            this.Columns[2].Width = this.Width / 3;
            this.Columns[3].Width = this.Width / 3;
            this.Columns[4].Width = this.Width / 3;



        }


    }
}
