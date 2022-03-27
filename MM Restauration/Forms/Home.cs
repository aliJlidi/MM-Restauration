using MM_Restauration.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MM_Restauration
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            CustomizedErrorMessage.Show("Voulez vous vraiment quitter L'application?", "alerte", "Oui");
            if (CustomizedErrorMessage.closeProgram)
            {
                Application.Exit();
            }
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
         
                this.WindowState = FormWindowState.Minimized;
            
        }

        private void maxiBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized) { 
           
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.WindowState = this.WindowState;
            menu.Show();
            Home home = (Home)Application.OpenForms["Home"];
            home.Hide();
        }

        private void cusBtn_Click(object sender, EventArgs e)
        {
            Customers cust = new Customers();
            cust.WindowState = this.WindowState;
            cust.Show();
            Home home = (Home)Application.OpenForms["Home"];
            home.Hide();
        }

        private void comBtn_Click(object sender, EventArgs e)
        {
            Orders ord = new Orders();
            ord.WindowState = this.WindowState;
            ord.Show();
            Home home = (Home)Application.OpenForms["Home"];
            home.Hide();
        }
    }
}
