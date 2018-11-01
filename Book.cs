using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management3
{
    class Book
    {

       
        public string BookAuthor;
        public string BookName;

        public int Book_id;

        public List<Reserve> reserveslist = new List<Reserve>();
        
        public List<Librarian> Librarianslist = new List<Librarian>();
        

        
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

        public void addReserves(Reserve Reserve)
        {
            if (reserveslist == null)
            {
                reserveslist = new List<Reserve>();
            }
            this.reserveslist.Add(Reserve);
        }


        public void addLibrarian(Librarian Librarian)
        {
            if (Librarianslist == null)
            {
                Librarianslist = new List<Librarian>();
            }
            this.Librarianslist.Add(Librarian);
        }


        public Book() {
            this.id = id;
            this.Book_id = 0;
            this.BookName = "";
            this.BookAuthor = "";



        }
        public Book( int Book_id,int id, string BookAuthor, string BookName)
        {
            this.Book_id = Book_id;
            this.id = id;
            this.BookAuthor = BookAuthor;
            this.BookName = BookName;


        }


    }
}
