using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management3
{
    public interface IFactoryListView
    {
        ListViewBase createListViewStudent();
        ListViewBase createListViewBook();
        ListViewBase createListViewReserve();
        ListViewBase createListViewReserve_Equipment();
        ListViewBase createListViewLibrarian();
        ListViewBase createListViewEQUIPMENT();
        ListViewBase createListViewStudentDetay();
    }
}
