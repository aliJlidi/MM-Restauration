using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MMLibrary.Models;
using MMLibrary;
using System.Data.SQLite;
using System.Configuration;
using Dapper;

namespace MM_Restauration.Forms
{
    public partial class Customers : Form
    {
        //code that define the customer
        string code;
        // define a message to show if something wrong in the customized error message 
        string errorMsg;
        // get the current selected customer to pass it as para in the confirmation message
        customer currentCstm;
        // check what is the current state delete or edit to pass it when challing the confirmation message
        string state;
        // empty list of customer to use it for the check 
        List<customer> cstmCheck = new List<customer>();
        // defing a sqlite data access instance to access it functions 
        sqliteDataAccess con = new sqliteDataAccess();
        // create empty list of customers model
        List<customer> customerList = new List<customer>();
        public Customers()
        {
            InitializeComponent();

            WireUpLists();
        
        }
        public void WireUpLists()
        {
            customersList.DataSource = null; 
            this.customersList.DataSource = con.customer_GetAll();
         
            this.customersList.DisplayMember = "fullName";
        }
        #region //mainButtons
        private void closeBtn_Click(object sender, EventArgs e)
        {
            CustomizedErrorMessage.Show("Voulez vous vraiment quitter L'application?", "alerte", "Oui");
            if (CustomizedErrorMessage.closeProgram)
            {
                Application.Exit();
            }
        }

        private void maxiBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {

                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home home = (Home)Application.OpenForms["Home"];
            home.Show();
            this.Close();
        }
        #endregion
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
               
                customer cstm = new customer( code, nomTxt.Text, preTxt.Text, adressTxt.Text, postalTxt.Text, vilTxt.Text, telTxt.Text,mailTxt.Text);
                // save costumer
                con.customer_Create(cstm);

                codeTxt.Text = "";
                nomTxt.Text ="";
                preTxt.Text="";
                adressTxt.Text="";
                postalTxt.Text="";
                vilTxt.Text="";
                telTxt.Text="";
                mailTxt.Text = "";
                WireUpLists();
                CustomizedErrorMessage.Show("Client créé", "Client", "Ok!");

            }
            else
            {
                CustomizedErrorMessage.Show(errorMsg, "Erreur", "OK!");
            }
        }
#region
        private bool ValidateForm()
        {
            cstmCheck = con.customer_GetAll();
            bool output = true;
            int placeNumber = 0;
            bool ValidNumber1 = int.TryParse(postalTxt.Text, out placeNumber);
            bool ValidNumber2 = int.TryParse(telTxt.Text, out placeNumber);
            if (nomTxt.Text != "" && preTxt.Text != "" && telTxt.Text != "") { 
            code = nomTxt.Text.Substring(0, 1).ToUpper() + preTxt.Text.Substring(0, 1).ToUpper() + telTxt.Text;
            }

            if ((ValidNumber1 && ValidNumber2) == false)
            {
                output = false;
                errorMsg = "le numéro de téléphone et l'adresse postale\n doivent être des nombres";
            }
            foreach (customer cstm in cstmCheck)
            {
                if (cstm.customerCode == code)
                {
                    output = false;
                    errorMsg = "Le code client existe déjà";
                    
                }
            }
            if (telTxt.Text.Length != 8)
            {
                output = false;
                errorMsg = "Le numéro de téléphone doit avoir huit chiffres";
            }
            if (nomTxt.Text.Length == 0 || preTxt.Text.Length == 0 || adressTxt.Text.Length == 0 || vilTxt.Text.Length == 0 || postalTxt.Text.Length==0 )
            {
                output = false;
                errorMsg = "Certain champs sont vides !";
            }
            return output;
        }

        private void nomTxt_TextChanged(object sender, EventArgs e)
        {
     
            if (nomTxt.Text.Length >= 3)
            {
                nomTxt.ForeColor = Color.SkyBlue;
            }
            else
            {
                nomTxt.ForeColor = Color.Gray; 
            }
        }

        private void preTxt_TextChanged(object sender, EventArgs e)
        {

            if (preTxt.Text.Length >= 3)
            {   
                preTxt.ForeColor = Color.SkyBlue;
            }   
            else
            {   
                preTxt.ForeColor = Color.Gray;
            }
        }

        private void adressTxt_TextChanged(object sender, EventArgs e)
        {
  
            if (adressTxt.Text.Length >= 7)
            {   
                adressTxt.ForeColor = Color.SkyBlue;
            }   
            else
            {   
                adressTxt.ForeColor = Color.Gray;
            }
        }

        private void postalTxt_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (Int32.TryParse(postalTxt.Text.ToString(), out number))
            {
                postalTxt.ForeColor = Color.SkyBlue;
            }
            else
            {
                postalTxt.ForeColor = Color.Gray;
            }
        }

        private void vilTxt_TextChanged(object sender, EventArgs e)
        {

            if (vilTxt.Text.Length >= 3)
            {   
                vilTxt.ForeColor = Color.SkyBlue;
            }   
            else
            {   
                vilTxt.ForeColor = Color.Gray;
            }
        }

        private void telTxt_TextChanged(object sender, EventArgs e)
        {

            int number;
            if (Int32.TryParse(telTxt.Text.ToString(), out number)&& telTxt.Text.Length ==8)
            {   
                telTxt.ForeColor = Color.SkyBlue;
            }   
            else
            {   
                telTxt.ForeColor = Color.Gray;
            }
        }

        private void mailTxt_TextChanged(object sender, EventArgs e)
        {

            if (mailTxt.Text.Length >= 5)
            {   
                mailTxt.ForeColor = Color.SkyBlue;
            }   
            else
            {   
                mailTxt.ForeColor = Color.Gray;
            }
        }
#endregion  // validating entery
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (codeTxt.Text == "CP")
            {
                CustomizedErrorMessage.Show("Vous ne pouvez pas modifier cet entitée", "Message", "Ok!");
                return;
            }
            if (customersList.SelectedValue != null)
            {
                if (ValidateForm()) { 
                {
                    state = "edit";
                    currentCstm = new customer(codeTxt.Text, nomTxt.Text, preTxt.Text, adressTxt.Text, postalTxt.Text, vilTxt.Text, telTxt.Text, mailTxt.Text);
                    string _id = customersList.GetItemText(this.customersList.SelectedItem);
                    ConfirmationForm.Show("Confirmation", "êtes-vous sûr de supprimer cet client:\n" + _id, currentCstm, state);
                }
                }
                else
                {
                    CustomizedErrorMessage.Show(errorMsg, "Erreur", "OK!");
                }

            }
            else
            {
                CustomizedErrorMessage.Show("Vous devez d'abord sélectionner quelle entité a modifier", "Erreur", "Ok!");
            }


        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (codeTxt.Text == "CP")
            {
                CustomizedErrorMessage.Show("Vous ne pouvez pas supprimer cet entitée", "Message", "Ok!");
                return;
            }
            if (customersList.SelectedValue != null)
            {
                state = "delete";
                currentCstm = (customer)customersList.SelectedItem;
                string _id = customersList.GetItemText(this.customersList.SelectedItem);
                ConfirmationForm.Show("Confirmation", "êtes-vous sûr de supprimer cet client:\n" + _id, currentCstm, state);
            }
            else
            {
                CustomizedErrorMessage.Show("Vous devez d'abord sélectionner quelle entité a supprimer", "Erreur", "Ok!");
            }
        }
        public void editCustomer(customer paraCstm)
        {
          
            con.customer_Edit(paraCstm);
            WireUpLists();
        }

        public void deleteCustomer(customer paraCstm)
        {
            con.customer_Delete(paraCstm);
        }

        private void Customers_Activated(object sender, EventArgs e)
        {
            WireUpLists();
        }

        private void customersList_Click(object sender, EventArgs e)
        {
            if (customersList.SelectedValue != null)
            {
                currentCstm = (customer)customersList.SelectedItem;
                codeTxt.Text = currentCstm.customerCode;
                nomTxt.Text = currentCstm.name;
                preTxt.Text = currentCstm.surName;
                adressTxt.Text = currentCstm.adress;
                postalTxt.Text = currentCstm.Zip;
                vilTxt.Text = currentCstm.city;
                telTxt.Text = currentCstm.phone;
                mailTxt.Text = currentCstm.mail;
            }
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            codeTxt.Text = "";
            nomTxt.Text = "";
            preTxt.Text = "";
            adressTxt.Text = "";
            postalTxt.Text = "";
            vilTxt.Text = "";
            telTxt.Text = "";
            mailTxt.Text = "";
        }

        private void searschTxt_TextChanged(object sender, EventArgs e)
        {
            customersList.DataSource = null;
            this.customersList.DataSource = customer_GetSearsch();
            this.customersList.DisplayMember = "fullName";
        }
        public List<customer> customer_GetSearsch()
        {
            List<customer> output;
            //open the connection and close when done , never leave connection open
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<customer>("SELECT * FROM customer WHERE name  LIKE '%" + searschTxt.Text + "%' or surName LIKE '%" + searschTxt.Text + "%' or customerCode LIKE '%" + searschTxt.Text + "%'").ToList();
            }
            return output;
        }

 





    }
}
