using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management3
{
    public partial class MainForm : Form ,IView

    {

        Controller controller;
        ListViewBase lv;
        FactoryListView fact;
        ListViewBaseDecorator lvDecorator;
        bool isDecorator = false;

        public MainForm()
        {
            InitializeComponent();

            Populasyon instance = Populasyon.getInstance();
            instance.PopulasyonOlustur();
            controller = new Controller(this);
            Controller.studentlist= Populasyon.studentlist;
            Controller.reserveslist = Populasyon.reserveslist;
            Controller.Librarianslist= Populasyon.Librarianslist;
            Controller.Bookslist = Populasyon.Bookslist;
            Controller.reserve_equipmentslist = Populasyon.reserve_equipmentslist;
            Controller.EQUIPMENTlist = Populasyon.EQUIPMENTlist;
            fact = new FactoryListView(); 

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            cmSiniflar.Items.Add("Student");
            cmSiniflar.Items.Add("Book");
            cmSiniflar.Items.Add("Reserve");
            cmSiniflar.Items.Add("EQUIPMENT");
            cmSiniflar.Items.Add("Librarian");
            cmSiniflar.Items.Add("Reserve_Equipment");


        }
        private void cmSiniflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEkle.Visible = true;
            btnSil.Visible = true;
            btnduzenle.Visible = true;

            if (cmSiniflar.SelectedIndex == 0)
            {
                grpListele.Controls.Clear();
                isDecorator = false;

                isDecorator = true;
                lv = fact.createListViewStudent();
                lvDecorator = new ListViewSatirRenklendirici(lv, Color.AliceBlue, Color.AntiqueWhite);


                grpListele.Text = "Student Listesi";
                controller.Studentlistele();
                EkranaEkle();
            }

            else if (cmSiniflar.SelectedIndex == 1)
            {
                grpListele.Controls.Clear();
                isDecorator = false;

                isDecorator = true;
                lv = fact.createListViewBook();

                grpListele.Text = "Book Listesi";
                controller.Booklistele();

                lvDecorator = new ListViewSatirRenklendirici(lv, Color.AliceBlue, Color.AntiqueWhite);
                EkranaEkle();
            }

            else if (cmSiniflar.SelectedIndex == 2)
            {
                grpListele.Controls.Clear();
                isDecorator = false;

                isDecorator = true;
                lv = fact.createListViewLibrarian();

                grpListele.Text = "Librarian Listesi";
                controller.Librarianlistele();

                lvDecorator = new ListViewSatirRenklendirici(lv, Color.AliceBlue, Color.AntiqueWhite);
                EkranaEkle();

            }

            else if (cmSiniflar.SelectedIndex == 3)
            {
                grpListele.Controls.Clear();
                isDecorator = false;

                isDecorator = true;
                lv = fact.createListViewReserve();
                lvDecorator = new ListViewSatirRenklendirici(lv, Color.AliceBlue, Color.AntiqueWhite);


                grpListele.Text = "Reserve Listesi";
                controller.Reservelistele();
                EkranaEkle();
            }

            else if (cmSiniflar.SelectedIndex == 4)
            {
                grpListele.Controls.Clear();
                isDecorator = false;

                isDecorator = true;
                lv = fact.createListViewReserve_Equipment();

                grpListele.Text = " Reserve_Equipment Listesi";
                controller.Reserve_Equipmentlistele();

                lvDecorator = new ListViewSatirRenklendirici(lv, Color.AliceBlue, Color.AntiqueWhite);
                EkranaEkle();
            }

            else if (cmSiniflar.SelectedIndex == 5)
            {
                grpListele.Controls.Clear();
                isDecorator = false;

                isDecorator = true;
                lv = fact.createListViewEQUIPMENT();


                grpListele.Text = "EQUİPMENT Listesi";
                controller.EQUIPMENTlistele();
                lvDecorator = new ListViewSatirRenklendirici(lv, Color.AliceBlue, Color.AntiqueWhite);
                EkranaEkle();
            }
        }
        public void GrideEkle(object obj)
        {
            lv.GrideEkle(obj);
        }
        public void owner_MouseClick(object sender, MouseEventArgs e)
        {
            grpListele.Controls.Add(lv);
        }

        private void EkranaEkle()
        {
            grpListele.Controls.Add(lv);
        }
        private void EkranaEkle2(GroupBox grp)
        {
            grp.Controls.Add(lv);
        }
       

        private void btnEkle_Click(object sender, EventArgs e)
        {

            frmEkle frmEkl = new frmEkle();


            if (this.cmSiniflar.SelectedIndex == 0)
            {
                GroupBox grpEkle = new GroupBox();

                grpEkle.Controls.Clear();
                isDecorator = false;

                isDecorator = true;
                lv = fact.createListViewStudent();
                grpEkle.Text = "Student  Listesi";
                controller.Studentlistele();
                lvDecorator = new ListViewSatirRenklendirici(lv, Color.AliceBlue, Color.AntiqueWhite);

                EkranaEkle2(grpEkle);
                grpEkle.Size = new Size(450, 240);
                grpEkle.Location = new Point(4, 4);
                frmEkl.Controls.Add(grpEkle);
                grpEkle.Enabled = true;
                grpEkle.Visible = true;


            }
            frmEkl.ShowDialog();
        }

            private void btnSil_Click(object sender, EventArgs e)
        {
            lv.Items.Remove(lv.SelectedItems[0]);

        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {

                frmduzenle frmDuzenle = new frmduzenle();
                frmDuzenle.ShowDialog();

            }
      
    }
}
