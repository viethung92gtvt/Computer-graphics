using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace draw_geometry
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnShowEx_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string frmName = btn.Name;

            switch (frmName)
            {
                case "btnDrawLine":
                    {
                        PracticeLine frm = new PracticeLine();
                        frm.ShowDialog();
                        break;
                    }
                case "btnDrawCircle":
                    {
                        PracticeCircle frm = new PracticeCircle();
                        frm.ShowDialog();
                        break;
                    }
                case "btnDrawEllipse":
                    {
                        PracticeElip frm = new PracticeElip();
                        frm.ShowDialog();
                        break;
                    }
                case "btnEx1":
                    {
                        Ex1 frm = new Ex1();
                        frm.ShowDialog();
                        break;
                    }
                case "btnEx2":
                    {
                        Ex2 frm = new Ex2();
                        frm.ShowDialog();
                        break;
                    }
                case "btnEx3":
                    {
                        Ex3 frm = new Ex3();
                        frm.ShowDialog();
                        break;
                    }
                case "btnEx4":
                    {
                        Ex4 frm = new Ex4();
                        frm.ShowDialog();
                        break;
                    }
                case "btnEx5":
                    {
                        Ex5 frm = new Ex5();
                        frm.ShowDialog();
                        break;
                    }
                case "btnEx6":
                    {
                        Ex6 frm = new Ex6();
                        frm.ShowDialog();
                        break;
                    }
                case "btnEx7":
                    {
                        Ex7 frm = new Ex7();
                        frm.ShowDialog();
                        break;
                    }
                case "btnEx8":
                    {
                        Ex8 frm = new Ex8();
                        frm.ShowDialog();
                        break;
                    }
                case "btnEx9":
                    {
                        Ex9 frm = new Ex9();
                        frm.ShowDialog();
                        break;
                    }
                case "btnEx10":
                    {
                        Ex10 frm = new Ex10();
                        frm.ShowDialog();
                        break;
                    }
                case "btnClock":
                    {
                        Clock frm = new Clock();
                        frm.Show();
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
