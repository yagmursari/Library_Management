using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management3
{
    class EQUIPMENT
    {

       
       public string EquipmentType;

      public  List<Reserve_Equipment> reserve_equipmentslist = new List<Reserve_Equipment>();
      public  List<Librarian> Librarianslist = new List<Librarian>();

        public int equipment_id;

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


        public List<Reserve_Equipment> Reserve_Equipment
        {
            get
            {
                return reserve_equipmentslist;
            }

            set
            {
                reserve_equipmentslist = value;
            }
        }

        public List<Librarian> Librarian
        {
            get
            {
                return Librarianslist;
            }

            set
            {
                Librarianslist = value;
            }
        }


       
        public void addreserve_equipments(Reserve_Equipment Reserve_Equipment)
        {
            if (reserve_equipmentslist == null)
            {
                reserve_equipmentslist = new List<Reserve_Equipment>();
            }
            this.reserve_equipmentslist.Add(Reserve_Equipment);
        }

        public void addLibrarians(Librarian Librarian)
        {
            if (Librarianslist == null)
            {
                Librarianslist = new List<Librarian>();
            }
            this.Librarianslist.Add(Librarian);
        }
        public EQUIPMENT()
        {
            this.id = id;
            this.equipment_id = 0;
            this.EquipmentType = "";
        }
        public EQUIPMENT(int id,int equipment_id,string EquipmentType)
        {
            this.id = id;
            this.equipment_id=equipment_id;
            this.EquipmentType = EquipmentType;

        }
    }
}
