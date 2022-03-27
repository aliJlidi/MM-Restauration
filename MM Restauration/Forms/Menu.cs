using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using MMLibrary.Models;
using MMLibrary;
using MM_Restauration.Forms;

namespace MM_Restauration
{
    public partial class Menu : Form
    {

        //the current category
        string category;
        // define a message to show if something wrong in the customized error message 
        string errorMsg;
        //code that define the food
        string code;
        // check what is the current state delete or edit to pass it when challing the confirmation message
        string state;
        // defing a sqlite data access instance to access it functions 
        sqliteDataAccess con = new sqliteDataAccess();
        // empty list of customer to use it for the check 
        List<food> foodCheck = new List<food>();
        // get the current selected food to pass it as para in the confirmation message
        food currentFood;
        public Menu()
        {
            InitializeComponent();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home home = (Home)Application.OpenForms["Home"];
            home.Show();
            this.Close();
        }

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
        List<food> output;
        public void WireUpLists(List<food> output)
        {
            foodList.DataSource = null;
            this.foodList.DataSource = output;

            this.foodList.DisplayMember = "foodName";
        }
         
        private void burgerBtn_Click(object sender, EventArgs e)
        {
            category = "Burgers";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Burgers' ").ToList();
                WireUpLists(output);
                categoryTxt.Text = "Burgers";
         
            }

        }

        private void paniniBtn_Click(object sender, EventArgs e)
        {
            category = "Paninis";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Paninis' ").ToList();
                WireUpLists(output);
                categoryTxt.Text = "Paninis";
           
            }

        }

        private void zapBtn_Click(object sender, EventArgs e)
        {
            category = "Zapwichs";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Zapwichs' ").ToList();
                WireUpLists(output);
                categoryTxt.Text = "Zapwichs";
          
            }

        }

        private void tomateBtn_Click(object sender, EventArgs e)
        {
            category = "Pizza T";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Pizza T' ").ToList();
                WireUpLists(output);
                categoryTxt.Text = "Pizza T";
       
            }
        }

        private void cremeBtn_Click(object sender, EventArgs e)
        {
            category = "Pizza C";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Pizza C' ").ToList();
                WireUpLists(output);
                categoryTxt.Text = "Pizza C";
       
            }
        }

        private void bbqBtn_Click(object sender, EventArgs e)
        {
            category = "Pizza B";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Pizza B' ").ToList();
                WireUpLists(output);
                categoryTxt.Text = "Pizza B";
      
            }
        }  

        private void texBtn_Click(object sender, EventArgs e)
        {
            category = "Tex-Mex";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Tex-Mex' ").ToList();
                WireUpLists(output);
                categoryTxt.Text = "Tex-Mex";
     
            }
        }

        private void saladBtn_Click(object sender, EventArgs e)
        {
            category = "Salades";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Salades' ").ToList();
                WireUpLists(output);
                categoryTxt.Text = "Salades";
       
            }
        }

        private void iceBtn_Click(object sender, EventArgs e)
        {
            category = "Glaces";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Glaces' ").ToList();
                WireUpLists(output);
                categoryTxt.Text = "Glaces";
         
            }
        }

        private void desertBtn_Click(object sender, EventArgs e)
        {
            category = "Desserts";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Desserts' ").ToList();
                WireUpLists(output);
                categoryTxt.Text = "Desserts";
         
            }
        }

        private void drinkBtn_Click(object sender, EventArgs e)
        {
            category = "Boissons";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Boissons' ").ToList();
                WireUpLists(output);
                categoryTxt.Text = "Boissons";
        
            }
        }

        private void kidBtn_Click(object sender, EventArgs e)
        {
            category = "Bambino";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Bambino' ").ToList();
                WireUpLists(output);
                categoryTxt.Text = "Bambino";
          
            }
        }

        private void foodList_Click(object sender, EventArgs e)
        {
            if (foodList.SelectedValue != null)
            {
                currentFood = (food)foodList.SelectedItem;
                codeTxt.Text = currentFood.foodCode;
                nomTxt.Text = currentFood.name;
                categoryTxt.Text = currentFood.category;
                priceTxt.Text = currentFood.price;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
      if (ValidateForm())
            {
               
                food fd = new food( code, nomTxt.Text, categoryTxt.Text, priceTxt.Text);
                // save costumer
                con.food_Create(fd);

                codeTxt.Text = "";
                nomTxt.Text ="";
                categoryTxt.Text="";
                priceTxt.Text ="";
                WireUpLists(currentFoodList());
                CustomizedErrorMessage.Show("Article créé", "Client", "Ok!");

            }
            else
            {
                CustomizedErrorMessage.Show(errorMsg, "Erreur", "OK!");
            }
        }

        public List<food> currentFoodList()
        {
            
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE '" + category + "' ").ToList();
            }
            return output;

        }
        

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (foodList.SelectedValue != null)
            {
                state = "editFood";
                currentFood = new food(codeTxt.Text, nomTxt.Text, categoryTxt.Text, priceTxt.Text);
                string _id = foodList.GetItemText(this.foodList.SelectedItem);
                ConfirmationForm.Show("Confirmation", "êtes-vous sûr de modifier cet article:\n" + _id, currentFood, state);
            }
            else
            {
                CustomizedErrorMessage.Show("Vous devez d'abord sélectionner quelle entité a supprimer", "Erreur", "Ok!");
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (foodList.SelectedValue != null)
            {
                state = "deleteFood";
                currentFood = (food)foodList.SelectedItem;
                string _id = foodList.GetItemText(this.foodList.SelectedItem);
                ConfirmationForm.Show("Confirmation", "êtes-vous sûr de supprimer cet article:\n" + _id, currentFood, state);
            }
            else
            {
                CustomizedErrorMessage.Show("Vous devez d'abord sélectionner quelle entité a supprimer", "Erreur", "Ok!");
            }
        }
        public void editFood(food paraFood)
        {

           con.food_Edit(paraFood);
   
        }

        public void deleteFood(food paraFood)
        {
            con.food_Delete(paraFood);
            codeTxt.Text = "";
            nomTxt.Text = "";
            priceTxt.Text = "";
        }
        private bool ValidateForm()
        {
            foodCheck = con.food_GetAll();
            bool output = true;
            if (nomTxt.Text != "" && categoryTxt.Text != "")
            {
                code = nomTxt.Text.Substring(0, 1).ToUpper() + categoryTxt.Text.Substring(0, 1).ToUpper() + priceTxt.Text.Substring(0,1);
            }

            foreach (food fd in foodCheck)
            {
                if (fd.foodCode == code)
                {
                    output = false;
                    errorMsg = "Le code déjà existe ";

                }
            }

            if (nomTxt.Text.Length == 0 || categoryTxt.Text.Length == 0 || priceTxt.Text.Length == 0 )
            {
                output = false;
                errorMsg = "Certain champs sont vides !";
            }
            return output;
        }

        private void Menu_Activated(object sender, EventArgs e)
        {
            WireUpLists(currentFoodList());
        }

        public List<food> food_GetSearsch()
        {
            List<food> output;
            //open the connection and close when done , never leave connection open
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE name  LIKE '%" + searschTxt.Text + "%' or category LIKE '%" + searschTxt.Text + "%'").ToList();
            }
            return output;
        }

        private void searschTxt_TextChanged(object sender, EventArgs e)
        {
            foodList.DataSource = null;
            this.foodList.DataSource = food_GetSearsch();
            this.foodList.DisplayMember = "foodName";
        }



 
    }
}
