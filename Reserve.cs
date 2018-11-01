using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management3
{
    class Reserve
    {
        public string DueDate;
        public string DateTaken;
        public string fine;

        public Student student;
        public Book Book;

        
        public int Student_id;
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


        public void Setstudents(Student Student)
        {
            this.student = Student;

        }
        public void SetBook(Book Book)
        {
            this.Book = Book;
        }

        public Reserve()
        {
            this.id =id;
            this.book_id = 0;
            this.Student_id = 0;
            this.DateTaken = "";
            this.DateTaken = "";
            this.fine = "";



        }
        public Reserve(int id,int book_id,int Student_id,string DueDate, string DateTaken, string fine)
        {
            this.id = id;
            this.book_id = book_id;
            this.Student_id = Student_id;
            this.DateTaken = DateTaken;
            this.DueDate = DueDate;            
            this.fine = fine;     
                 
            
           
        }

    }
}