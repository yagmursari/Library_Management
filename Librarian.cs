using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management3
{
    class Librarian
    {


        
        public string librarian_Name;
        public string librarian_password;
        public EQUIPMENT equipments;

        public int librarian_id;
        public int equipments_id;

        public List<Book> Bookslist = new List<Book>();
        public int book_id;

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
        public void addbooks(Book Book)
        {
            if (Bookslist == null)
            {
                Bookslist = new List<Book>();
            }
            this.Bookslist.Add(Book);
        }
        public void SetEQUIPMENT(EQUIPMENT EQUIPMENT)
        {
            this.equipments = EQUIPMENT;

        }
        public Librarian() {

            this.id = id;
            this.librarian_Name = "";
            this.librarian_password = "";
            this.book_id = 0;

        }



        public Librarian(int book_id,int id, string librarian_Name, string librarian_password)
        {
            this.id = id;
            this.book_id = book_id;
            this.librarian_Name = librarian_Name;
            this.librarian_password = librarian_password;

        }



    }
}
