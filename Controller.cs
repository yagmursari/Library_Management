using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management3
{
    class Controller
    {
        IView iv;

       public static List<Reserve> reserveslist = new List<Reserve>();
        public static List<Librarian> Librarianslist = new List<Librarian>();
        public static List<Book> Bookslist = new List<Book>();
        public static List<Reserve_Equipment> reserve_equipmentslist = new List<Reserve_Equipment>();
        public static List<Student> studentlist = new List<Student>();
        public static List<EQUIPMENT> EQUIPMENTlist = new List<EQUIPMENT>();


       

        public Controller(IView iv)
        {
            this.iv = iv;
        }


        public List<EQUIPMENT> EQUIPMENT
        {
            get
            {
                return EQUIPMENTlist;
            }
            set
            {
                EQUIPMENTlist = value;
            }
        }
        public List<Student> Student
        {
            get
            {
                return studentlist;

            }
            set
            {
                studentlist = value;
            }
        }
        public List<Book> Book
        {
            get
            {
                return Bookslist;
            }

            set
            {
                Bookslist = value;
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

        //sınıfları listele
        public void Studentlistele()
        {
            foreach (Student std in studentlist)
            {
                iv.GrideEkle(std);
            }
        }
        public void Booklistele()
        {
            foreach (Book book in Bookslist)
            {
                iv.GrideEkle(book);
            }
        }
        public void Librarianlistele()
        {
            foreach (Librarian lib in Librarianslist)
            {
                iv.GrideEkle(lib);
            }
        }
        public void Reservelistele()
        {
            foreach (Reserve Res in reserveslist)
            {
                iv.GrideEkle(Res);
            }
        }
        public void Reserve_Equipmentlistele(){

            foreach(Reserve_Equipment reserve_equip in reserve_equipmentslist)
            {
                iv.GrideEkle(reserve_equip);
            }

            }
        public void EQUIPMENTlistele()
        {
            foreach(EQUIPMENT EQUIP in EQUIPMENTlist)
            {
                iv.GrideEkle(EQUIP);
            }
        }
        public bool StudentEkle(Student addThis)
        {
            Populasyon.studentlist.Add(addThis);
            return true;
        }
        public bool LibrarianEkle(Librarian addThis)
        {
            Populasyon.Librarianslist.Add(addThis);
            return true;
        }
        public bool ReserveEkle(Reserve addThis)
        {
            Populasyon.reserveslist.Add(addThis);
            return true;
        }
        public bool Reserve_EquipmentEkle(Reserve_Equipment addThis)
        {
            Populasyon.reserve_equipmentslist.Add(addThis);
            return true;
        }
        public bool BookEkle(Book addThis)
        {
            Populasyon.Bookslist.Add(addThis);
            return true;
        }
        public bool EQUIPMENTEkle(EQUIPMENT addThis)
        {
            Populasyon.EQUIPMENTlist.Add(addThis);
            return true;

        }

            }
        }




