using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management3
{
    public interface IView
    {

        void GrideEkle(object obj);
        void owner_MouseClick(object sender, MouseEventArgs e);




    }
}