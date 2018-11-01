using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management3
{
    class FactoryListView : IFactoryListView
    {
        public ListViewBase createListViewStudent()
        {
            return new ListViewStudent();
        }
        public ListViewBase createListViewBook()
        {
            return new ListViewBook();
        }
        public ListViewBase createListViewReserve()
        {
            return new ListViewReserve();
        }
        public ListViewBase createListViewReserve_Equipment()
        {
            return new ListViewReserve_Equipment();
        }
        public ListViewBase createListViewLibrarian()
        {
            return new ListViewBook();
        }
        public ListViewBase createListViewEQUIPMENT()
        {
            return new ListViewEQUIPMENT();
        }
        public ListViewBase createListViewStudentDetay()
        {
            return new ListViewStudentDetay();
        }
    }
}
