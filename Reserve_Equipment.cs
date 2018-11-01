using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management3
{
    class Reserve_Equipment
    {


        public Student students;
        public string DateTaken_Equip;
        public string DateDue_Equip;
        public EQUIPMENT equipments;

       

        public int equipments_id;
        public int student_id;


        private int _id;

        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (value > 0)
                {
                    this._id = value;
                }
                else
                {
                    this._id = 0;
                }
            }
        }


        public void Setstudent(Student Student)
        {
            this.students = Student;
        }
        public void SetEQUIPMENTS(EQUIPMENT EQUIPMENT)
        {
            this.equipments = EQUIPMENT;

        }
        public Reserve_Equipment() {
            this.id = id;
            this.student_id = 0;
            this.equipments_id = 0;
            this.DateDue_Equip = "";
            this.DateTaken_Equip = "";


        }
        public Reserve_Equipment(int id, int equipments_id, int student_id, string DateTaken_Equip, string DateDue_Equip)
        {
            this.id = id;
            this.equipments_id = equipments_id;
            this.student_id = student_id;
            this.DateTaken_Equip = DateTaken_Equip;
            this.DateDue_Equip = DateDue_Equip;

        }

        
    }
}

