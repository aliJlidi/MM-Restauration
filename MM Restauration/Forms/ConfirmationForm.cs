using MMLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MM_Restauration.Forms
{
    public partial class ConfirmationForm : Form
    {
        Customers cstmForm = new Customers();
        Menu fdForm = new Menu();
       static string opState;
        public static customer cstm;
        public static food fd;
        public ConfirmationForm()
        {
            InitializeComponent();
        }
        static ConfirmationForm conForm;

        public static void Show(string caption, string label, customer customer,string state)
        {
            conForm = new ConfirmationForm();
            conForm.captionLbl.Text = caption;
            conForm.msgLbl.Text = label;
            cstm = customer;
            opState = state;
            conForm.Show();

        }
        public static void Show(string caption, string label, food _food, string state)
        {
            conForm = new ConfirmationForm();
            conForm.captionLbl.Text = caption;
            conForm.msgLbl.Text = label;
            fd= _food;
            opState = state;
            conForm.Show();

        }

        private void validBtn_Click(object sender, EventArgs e)
        {
            switch (opState)
            {
                case "delete":
                    cstmForm.deleteCustomer(cstm);
                    break;
                case "edit":
                    cstmForm.editCustomer(cstm);
                    break;
                case "deleteFood":
                    fdForm.deleteFood(fd);
                    break;
                case"editFood":
                    fdForm.editFood(fd);
                    break;

            }
           
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            cstmForm.WireUpLists();
        }
    }
}
