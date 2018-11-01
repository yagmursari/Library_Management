using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management3
{
    class Student
    {
        public int student_password;
        public string student_lastname;
        public string student_firstname;

        public Reserve_Equipment reserve_equipments;

        public int reserve_equipments_id;
        public int student_id;

        public List<Reserve> reserveslist = new List<Reserve>();

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



        public List<Reserve> Reserve
        {
            get
            {
                return reserveslist;
            }

            set
            {
                reserveslist = value;
            }
        }



       



        public void addreserve(Reserve Reserve)
        {
            if (reserveslist == null)
            {
                reserveslist = new List<Reserve>();
            }
            this.reserveslist.Add(Reserve);
        }
        public void SetReserveEquipment(Reserve_Equipment Reserve_Equipment)
        {
            this.reserve_equipments = Reserve_Equipment;

        }
        public Student()
        {
        }
        public Student(int student_password, string student_lastname, string student_firstname, string reserves)
        {

            this.student_password = student_password;
            this.student_lastname = student_lastname;
            this.student_firstname = student_firstname;

        }


    }
}
