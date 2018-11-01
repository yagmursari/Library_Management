using Library_Management3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management3
{
    class Populasyon
    {


        public static List<Reserve> reserveslist = new List<Reserve>();
        public static List<Librarian> Librarianslist = new List<Librarian>();
        public static List<Book> Bookslist = new List<Book>();
        public static List<Reserve_Equipment> reserve_equipmentslist = new List<Reserve_Equipment>();
        public static List<Student> studentlist = new List<Student>();
        public static List<EQUIPMENT> EQUIPMENTlist = new List<EQUIPMENT>();

        public Populasyon()
        {

        }
        private static Populasyon instance = null;

        public static Populasyon getInstance()
        {
            if (instance == null)
            {
                instance = new Populasyon();

            }
            return instance;

        }


        public void PopulasyonOlustur()
        {
            ReserveOluştur();
            StudentOluştur();
            LibrarianOluştur();
            BookOlustur();
            Reserve_EquipmentOlustur();
            EQUIPMENTOluştur();


            IliskiOlustur();
        }
        private void EQUIPMENTOluştur()
        {
            EQUIPMENTlist.Add(new EQUIPMENT(133, 123, "KİTAP"));
            EQUIPMENTlist.Add(new EQUIPMENT(144, 155, "KİTAP"));
            EQUIPMENTlist.Add(new EQUIPMENT(188, 199, "KİTAP"));
            EQUIPMENTlist.Add(new EQUIPMENT(177, 122, "KİTAP"));
        }

        private void Reserve_EquipmentOlustur()
        {
            reserve_equipmentslist.Add(new Reserve_Equipment(123, 123, 123, "10 / 12 / 2017", "15 / 12 / 2017"));
            reserve_equipmentslist.Add(new Reserve_Equipment(147, 156, 195, "11 / 12 / 2017", "14 / 12 / 2017"));
            reserve_equipmentslist.Add(new Reserve_Equipment(123, 156, 158, "12 / 12 / 2017", "13 / 12 / 2017"));
            reserve_equipmentslist.Add(new Reserve_Equipment(123, 465, 789, "12 / 12 / 2017", "13 / 12 / 2017"));


        }

        private void BookOlustur()
        {
            Bookslist.Add(new Book(12121212, 232323, "AYSE KULİN", "YAZ"));
            Bookslist.Add(new Book(12345698, 5656565, "MEHMET AK", "KIS"));
            Bookslist.Add(new Book(15555555, 898889, "ALİ CAN", "ILKBAHAR"));
            Bookslist.Add(new Book(16656565, 564644, "VELİ CAN", "SONBAHAR"));

        }

        private void LibrarianOluştur()
        {
            Librarianslist.Add(new Librarian(111111, 22222, "libraryname", "password"));
            Librarianslist.Add(new Librarian(333333, 22222222, "libraryname", "password"));
            Librarianslist.Add(new Librarian(444444, 22222222, "libraryname", "password"));
            Librarianslist.Add(new Librarian(555555, 22222222, "libraryname", "password"));
        }

        private void StudentOluştur()
        {

            studentlist.Add(new Student(20000, "ali", "kaya", "birinci kitap"));
            studentlist.Add(new Student(30000, "ayşe", "çınar", "birinci kitap"));
            studentlist.Add(new Student(40000, "ahmet", "kırmızı", "birinci kitap"));
            studentlist.Add(new Student(50000, "sevgi", "sarı", "birinci kitap"));
        }

        private void ReserveOluştur()
        {
            reserveslist.Add(new Reserve(1, 12, 12, "12/09/13 ", "12 / 09 / 13", "12/09/13"));
            reserveslist.Add(new Reserve(2, 32, 12, "12/09/13 ", "12 / 09 / 13", "12/09/13"));
            reserveslist.Add(new Reserve(3, 42, 12, "12/09/13 ", "12 / 09 / 13", "12/09/13"));
            reserveslist.Add(new Reserve(4, 52, 12, "12/09/13 ", "12 / 09 / 13", "12/09/13"));
        }

        private void IliskiOlustur()
        {
            
            IlıskıReserve_Student();
            IlıskıLibrarian_EQUIPMENT();
            IlıskıReserve_Equipment_EQUIPMENT();
            IlıskıReserve_Book();
            IlıskıLibrarian_Book();


        }

        public void IlıskıReserve_Book()
        {
            foreach (var Res in reserveslist)
            {
                foreach (var book in Bookslist)
                {
                    if (Res.book_id == book.id)
                    {
                        Res.Book = book;
                        if (book.reserveslist.IndexOf(Res) == -1) book.reserveslist.Add(Res);
                    }
                }
            }
        }

        public void IlıskıLibrarian_Book()
        {
            foreach (var lib in Librarianslist)
            {
                foreach (var book in Bookslist)
                {
                    if (lib.book_id == book.id)
                    {
                        if (lib.Bookslist.IndexOf(book) == -1) lib.Bookslist.Add(book);
                        if (book.Librarianslist.IndexOf(lib) == -1) book.Librarianslist.Add(lib);
                    }
                }
            }
        }

        public void IlıskıReserve_Equipment_EQUIPMENT()
        {
            foreach (var reserve_equip in reserve_equipmentslist)
            {
                foreach (var EQUIP in EQUIPMENTlist)
                {
                    if (reserve_equip.equipments_id == EQUIP.id)
                    {
                        reserve_equip.equipments = EQUIP;
                        if (EQUIP.reserve_equipmentslist.IndexOf(reserve_equip) == -1) EQUIP.reserve_equipmentslist.Add(reserve_equip);
                    }
                }
            }
        }

        public void IlıskıLibrarian_EQUIPMENT()
        {

            foreach (var lib in Librarianslist)
            {
                foreach (var EQUIP in EQUIPMENTlist)
                {
                    if (lib.equipments_id == EQUIP.id)
                    {
                        lib.equipments = EQUIP;
                        if (EQUIP.Librarianslist.IndexOf(lib) == -1) EQUIP.Librarianslist.Add(lib);
                    }
                }
            }
        }

        public void IlıskıReserve_Student()
        {

            foreach (var Res in reserveslist)
            {
                foreach (var std in studentlist)
                {
                    if (Res.Student_id == std.id)
                    {
                        Res.student = std;
                        if (std.reserveslist.IndexOf(Res)==-1) std.reserveslist.Add(Res);


                    }
                }
            }
        }
   
      


        }

    }

