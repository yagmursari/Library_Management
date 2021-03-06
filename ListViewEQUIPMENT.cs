﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management3
{
    class ListViewEQUIPMENT : ListViewBase
    {
        public ListViewEQUIPMENT() : base()
        {
            SutunEkle();
        }
        public override void GrideEkle(object obj)
        {
            ListViewItem lvi = new ListViewItem();

            lvi.Text = ((EQUIPMENT)obj).equipment_id.ToString();
            lvi.SubItems.Add(((EQUIPMENT)obj).id.ToString());
            lvi.SubItems.Add(((EQUIPMENT)obj).EquipmentType.ToString());

            this.Items.Add(lvi);
        }

        public override void SutunEkle()
        {
            this.Columns.Add("id");
            this.Columns.Add("Equipment ID");
            this.Columns.Add("Equipment Type");
            this.Columns[0].Width = this.Width / 3;
            this.Columns[1].Width = this.Width / 3;
            this.Columns[2].Width = this.Width / 3;

        }


    }
}

