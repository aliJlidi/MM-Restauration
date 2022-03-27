using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using MMLibrary.Models;
using MMLibrary;
using System.Drawing.Printing;

namespace MM_Restauration.Forms
{
    public partial class Orders : Form
    {
        //quantity of items
        int quantityValue = 1;
        //totale of items
        float totale = 0;
        //the current category
         string category;
        //empty list of food called output
        List<food> output;
        // defing a sqlite data access instance to access it functions 
        sqliteDataAccess con = new sqliteDataAccess();
        //Define a font collection 
        
        public Orders()
        {

            InitializeComponent();
            WireUpCustomerList();
            totalTxt.Text = totale + " €";
            panelIceSize.Hide();
            pizzaSize.Hide();
            panelBrand.Hide();
            quantityTxt.Text = "1";
            
        }

        public void showPizzaSize()
        {
            if (category == "Pizza T" || category == "Pizza C"||category=="Pizza B")
            {
                pizzaSize.Show();
            }
            else
            {
                pizzaSize.Hide();
            }
        }
        public void showIceSize()
        {
            if (category == "Glaces")
            {
                panelIceSize.Show();
            }
            else
            {
                panelIceSize.Hide();
            }
        }
        public void showBrand()
        {
            if (category == "Boissons")
            {
                panelBrand.Show();
            }
            else
            {
                panelBrand.Hide();
            }
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home home = (Home)Application.OpenForms["Home"];
            home.Show();
            this.Close();
        }
        //showing the food list 
        #region
        private void burgerBtn_Click(object sender, EventArgs e)
        {
            category = "Burgers";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Burgers' ").ToList();
                WireUpFoodLists(output);
                showPizzaSize();
                showIceSize();
      
            }

        }

        private void paniniBtn_Click(object sender, EventArgs e)
        {
            category = "Paninis";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Paninis' ").ToList();
                WireUpFoodLists(output);
                showPizzaSize();
                showIceSize();
                showBrand();
           
            }

        }

        private void zapBtn_Click(object sender, EventArgs e)
        {
            category = "Zapwichs";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Zapwichs' ").ToList();
                WireUpFoodLists(output);
                showPizzaSize();
                showIceSize();
                showBrand();
     
            }

        }

        private void tomateBtn_Click(object sender, EventArgs e)
        {
            category = "Pizza T";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Pizza T' ").ToList();
                WireUpFoodLists(output);
                showPizzaSize();
                showIceSize();
                showBrand();
        
            }
        }

        private void cremeBtn_Click(object sender, EventArgs e)
        {
            category = "Pizza C";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Pizza C' ").ToList();
                WireUpFoodLists(output);
                showPizzaSize();
                showIceSize();
                showBrand();
     
            }
        }
        private void bbqBtn_Click(object sender, EventArgs e)
        {
            category = "Pizza B";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Pizza B' ").ToList();
                WireUpFoodLists(output);
                showPizzaSize();
                showIceSize();
                showBrand();
         
            }
        }

        private void texBtn_Click(object sender, EventArgs e)
        {
            category = "Tex-Mex";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Tex-Mex' ").ToList();
                WireUpFoodLists(output);
                showPizzaSize();
                showIceSize();
                showBrand();
            
            }
        }

        private void saladBtn_Click(object sender, EventArgs e)
        {
            category = "Salades";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Salades' ").ToList();
                WireUpFoodLists(output);
                showPizzaSize();
                showIceSize();
                showBrand();
     
            }
        }

        private void iceBtn_Click(object sender, EventArgs e)
        {
            category = "Glaces";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Glaces' ").ToList();
                WireUpFoodLists(output);
                showPizzaSize();
                showIceSize();
                showBrand();
         
            }
        }

        private void desertBtn_Click(object sender, EventArgs e)
        {
            category = "Desserts";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Desserts' ").ToList();
                WireUpFoodLists(output);
                showPizzaSize();
                showIceSize();
                showBrand();
           
            }
        }

        private void drinkBtn_Click(object sender, EventArgs e)
        {
            category = "Boissons";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Boissons' ").ToList();
                WireUpFoodLists(output);
                showPizzaSize();
                showIceSize();
                showBrand();
          
            }
        }

        private void kidBtn_Click(object sender, EventArgs e)
        {
            category = "Bambino";
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE category  LIKE 'Bambino' ").ToList();
                WireUpFoodLists(output);
                showPizzaSize();
                showIceSize();
                showBrand();
       
            }
        }
        #endregion
        public void WireUpFoodLists(List<food> output)
        {
            foodList.DataSource = null;
            this.foodList.DataSource = output;
            this.foodList.DisplayMember = "foodName";
          
        }
        public void WireUpCustomerList()
        {
            customerList.DataSource = null;
            this.customerList.DataSource = con.customer_GetAll();
            this.customerList.DisplayMember = "orderShow";
        }

      // counter Mega
        int pizzaMega = 0;
        // counter sinior
        int pizzaSenior = 0;
        private void addtoListBtn_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (foodList.SelectedValue != null) {
            food currentFd = (food)foodList.SelectedItem;
             //validate quantity 
            if (Int32.TryParse(quantityTxt.Text, out  check)) {
                quantityValue = Int32.Parse(quantityTxt.Text);
                string quantityString = quantityTxt.Text;
                // manipulating the price and the total by the pizza size
            if (currentFd.category == "Pizza T" || currentFd.category == "Pizza C" )
            {
                if (comboBoxPizzaSize.SelectedItem != null) {
            
            switch (comboBoxPizzaSize.SelectedItem.ToString())
            {
                case "Junior":
                    totale += float.Parse(currentFd.price)*quantityValue;
                    receiptList.Items.Add(quantityString + "X".PadRight(2)+ currentFd.category.PadRight(9) + comboBoxPizzaSize.SelectedItem.ToString().PadRight(8) + currentFd.name.PadRight(15) + "€".PadRight(1) +string.Format("{0:00.00}", (float.Parse(currentFd.price) * quantityValue)));
                    if (minusTxt.Text != "")
                    {
                        receiptList.Items.Add(" ~ sans :" + minusTxt.Text);
                    }
                    minusTxt.Text = "";
                    break;
                case "Sénior":
                    totale += (float.Parse(currentFd.price)+5)*quantityValue;
                    pizzaSenior = pizzaSenior + 1;
                    receiptList.Items.Add(quantityString+"X".PadRight(2)+currentFd.category.PadRight(9) + comboBoxPizzaSize.SelectedItem.ToString().PadRight(8) +currentFd.name.PadRight(15) + "€".PadRight(1) + string.Format("{0:00.00}", ((float.Parse(currentFd.price)+5f)*quantityValue)));
                                        if (minusTxt.Text != "")
                    {
                        receiptList.Items.Add(" ~ sans :" + minusTxt.Text);
                    }
                    minusTxt.Text = "";
                    break;
                case "Méga":
                    totale += (float.Parse(currentFd.price)+10)*quantityValue;
                    pizzaMega = pizzaMega + 1;
                    receiptList.Items.Add(quantityString + "X".PadRight(2) + currentFd.category.PadRight(9) + comboBoxPizzaSize.SelectedItem.ToString().PadRight(8) + currentFd.name.PadRight(15) + "€".PadRight(1) + string.Format("{0:00.00}", ((float.Parse(currentFd.price)+10f) * quantityValue)));
                                       if (minusTxt.Text != "")
                    {
                        receiptList.Items.Add(" ~ sans :" + minusTxt.Text);
                    }
                    minusTxt.Text = "";
                    break;
            }
           
                }
                else
                {
                    CustomizedErrorMessage.Show("Vous devez selectionner \nune Taille pour le pizza", "Erreur", "Ok!");
                }
            }

            else if (currentFd.category == "Glaces")
            {
                if (comboBoxIceSize.SelectedItem != null) {
                    switch (comboBoxIceSize.SelectedItem.ToString())
                    {
                        case "100 mL":
                            totale += float.Parse(currentFd.price)*quantityValue;
                            receiptList.Items.Add(quantityString + "X".PadRight(2) + currentFd.category.PadRight(9) + comboBoxIceSize.SelectedItem.ToString().PadRight(8) + currentFd.name.PadRight(15) + "€".PadRight(1) + (float.Parse(currentFd.price) * quantityValue));
                      if (minusTxt.Text != "")
                    {
                        receiptList.Items.Add(" ~ sans :" + minusTxt.Text);
                    }
                    minusTxt.Text = "";
                            break;
                        case "500 mL" :
                            totale += (float.Parse(currentFd.price) + 3.5f)*quantityValue;
                            receiptList.Items.Add(quantityString + "X".PadRight(2) + currentFd.category.PadRight(9) + comboBoxIceSize.SelectedItem.ToString().PadRight(8) + currentFd.name.PadRight(15) + "€".PadRight(1) + string.Format("{0:00.00}", (float.Parse(currentFd.price) + 3.5f) * quantityValue));
                           if (minusTxt.Text != "")
                    {
                        receiptList.Items.Add(" ~ sans :" + minusTxt.Text);
                    }
                    minusTxt.Text = "";
                            break;
                    }
                }
                else
                {
                    CustomizedErrorMessage.Show("Vous devez selectionner\n une Taille pour le Glaces", "Erreur", "Ok!");
                }
            }
            else if (currentFd.category == "Boissons")
            {
                if (comboBoxBrand.SelectedItem != null)
                {
                    switch (comboBoxBrand.SelectedItem.ToString())
                    {
                        case "Coca":
                            totale += float.Parse(currentFd.price)*quantityValue;
                            receiptList.Items.Add(quantityString + "X".PadRight(2) + currentFd.category.PadRight(9) + comboBoxBrand.SelectedItem.ToString().PadRight(8) + currentFd.name.PadRight(15) + "€".PadRight(1) + string.Format("{0:00.00}",(float.Parse(currentFd.price) * quantityValue)));
                            if (minusTxt.Text != "")
                            {
                                receiptList.Items.Add(" ~ sans :" + minusTxt.Text);
                            }
                            minusTxt.Text = "";
                            break;
                        case "Fanta":
                            totale += float.Parse(currentFd.price) * quantityValue;
                            receiptList.Items.Add(quantityString + "X".PadRight(2) + currentFd.category.PadRight(9) + comboBoxBrand.SelectedItem.ToString().PadRight(8) + currentFd.name.PadRight(15) + "€".PadRight(1) + string.Format("{0:00.00}", (float.Parse(currentFd.price) * quantityValue)));
                            if (minusTxt.Text != "")
                            {
                                receiptList.Items.Add(" ~ sans :" + minusTxt.Text);
                            }
                            minusTxt.Text = "";
                            break;
                        case "Oasis":
                            totale += float.Parse(currentFd.price) * quantityValue;
                            receiptList.Items.Add(quantityString + "X".PadRight(2) + currentFd.category.PadRight(9) + comboBoxBrand.SelectedItem.ToString().PadRight(8) + currentFd.name.PadRight(15) + "€".PadRight(1) + string.Format("{0:00.00}", (float.Parse(currentFd.price) * quantityValue)));
                            if (minusTxt.Text != "")
                            {
                                receiptList.Items.Add(" ~ sans :" + minusTxt.Text);
                            }
                            minusTxt.Text = "";
                            break;
                        case "Orangina":
                            totale += float.Parse(currentFd.price) * quantityValue;
                            receiptList.Items.Add(quantityString + "X".PadRight(2) + currentFd.category.PadRight(9) + comboBoxBrand.SelectedItem.ToString().PadRight(8) + currentFd.name.PadRight(15) + "€".PadRight(1) + string.Format("{0:00.00}", (float.Parse(currentFd.price) * quantityValue)));
                            if (minusTxt.Text != "")
                            {
                                receiptList.Items.Add(" ~ sans :" + minusTxt.Text);
                            }
                            minusTxt.Text = "";
                            break;
                        case "Ice Tea":
                            totale += float.Parse(currentFd.price) * quantityValue;
                            receiptList.Items.Add(quantityString + "X".PadRight(2) + currentFd.category.PadRight(9) + comboBoxBrand.SelectedItem.ToString().PadRight(8) + currentFd.name.PadRight(15) + "€".PadRight(1) + string.Format("{0:00.00}", (float.Parse(currentFd.price) * quantityValue)));
                            if (minusTxt.Text != "")
                            {
                                receiptList.Items.Add(" ~ sans :" + minusTxt.Text);
                            }
                            minusTxt.Text = "";
                            break;
                    }
                }
                else
                {
                    CustomizedErrorMessage.Show("Vous devez selectionner\n une Marque pour le Boisson", "Erreur", "Ok!");
                }
            }
            else
            {
                receiptList.Items.Add(quantityString + "X".PadRight(2) + currentFd.category.PadRight(9) + "---".PadRight(8) + currentFd.name.PadRight(15) + "€".PadRight(1) + string.Format("{0:00.00}",(float.Parse(currentFd.price) * quantityValue)));
                totale += float.Parse(currentFd.price)*quantityValue;
                if (minusTxt.Text != "")
                {
                    receiptList.Items.Add(" ~ sans :" + minusTxt.Text);
                }
                minusTxt.Text = "";
            }
            quantityTxt.Text = "1";
            totalTxt.Text = String.Format("{0:00.00}", totale) + " €";
            }
            else
            {
                CustomizedErrorMessage.Show("Vous devez entrer une valide\n nombre comme quantité", "Erreur", "Ok!");
            }
            }
            else
            {
                CustomizedErrorMessage.Show("Vous devez d'abord sélectionner\n quelle entité a ajouter", "Erreur", "Ok!");
            }
        }

        private void removeFromListBtn_Click(object sender, EventArgs e)
        {

            if (receiptList.SelectedItem != null)
            {
         
                string item = receiptList.SelectedItem.ToString();
                receiptList.Items.RemoveAt(receiptList.SelectedIndex);
                if (!item.Contains('~')) {
                    totale -= float.Parse(item.Substring(item.Length - 5, 5));
                }
                totalTxt.Text = String.Format("{0:00.00}", totale) + " €";

            }
            else
            {
                CustomizedErrorMessage.Show("La liste est actualement vide !", "Erreur", "Ok!");
            }
       
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (customerList.SelectedItem != null && receiptList.Items.Count>=1) { 
            if (CashValidate()) {
                if (float.Parse(moneyTxt.Text) >= totale)
                {
                    PrintDialog printDialog = new PrintDialog();
                    PrintDocument printDocument = new PrintDocument();
                    //preview printing
                    PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();
                    //add the document to the dialog box...
                    printDialog.Document = printDocument;
                    //add an event handler that will do the printing
                    //on a till will not want to ask the user where to print 
                    printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt);
                    // preview the assigned document or you can create a different previewButton for it
                   // printPrvDlg.Document = printDocument;
                   // printPrvDlg.ShowDialog();
                    DialogResult result = printDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        printDocument.Print();
                    }
                }
                else
                {
                    CustomizedErrorMessage.Show("Le montant a payer doit étre\n supérieure au egale au totale", "Msg", "Ok!");
                }
            }
            else
            {
                CustomizedErrorMessage.Show("L'argent doit prend \n le format suivant 00 ou 00.00", "Erreur", "Ok!");
            }
            }
            else
            {
                CustomizedErrorMessage.Show("Vous devez selectionner un client\n ou ajouter une article au liste !", "Erreur", "Ok!");
            }

        }
        bool CashValidate()
        {
            float f = 0f;
            bool output = true;
            if (moneyTxt.Text == "")
            {
                output = false;
            }
            if (!float.TryParse(moneyTxt.Text,out f))
            {
                output = false;
            }
            return output;
        }
        //create receipt
        #region
        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float total = 0;
            float cash = float.Parse(moneyTxt.Text);
            float change = 0.00f;

            //this prints the reciept
            Graphics graphic = e.Graphics;
            //must use a mono spaced font as the spaces need to line up
            Font font = new Font("Courier New", 12);

            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;
            
            // draw the title 
            graphic.DrawString("Bienvenue El Gusto ", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            customer currentCtsm = (customer)customerList.SelectedItem;
            graphic.DrawString("Client :".PadRight(9) + currentCtsm.name + " " + currentCtsm.surName, font, new SolidBrush(Color.Black), startX, startY + offset);
            string top ="Qu".PadRight(4)+"Famille".PadRight(9) + "Taille".PadRight(8) + "Article".PadRight(15) + "Prix";
            offset = offset + (int)fontHeight+10;
            //draw the Header raw
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY+offset);
            //make the spacing consistent
            offset = offset + (int)fontHeight;
            // draw a line 
            graphic.DrawString("".PadRight(40,'-'), font, new SolidBrush(Color.Black), startX, startY + offset);
            //get the current selected client

            
            offset = offset + (int)fontHeight+5;
            total = float.Parse(totalTxt.Text.Substring(0,5));

            foreach (string item in receiptList.Items)
            {
              
        
                    graphic.DrawString(item, font, new SolidBrush(Color.Black), startX, startY+offset);
                    //make the space consistent
                    offset = offset + (int)fontHeight + 5;
               
            }
            if (pizzaMega >= 2 ||pizzaSenior>=2)
            {
                graphic.DrawString("Vous avez achetez deux pizza \n La troiséme est Offrete ", font, new SolidBrush(Color.Black), startX, startY + offset);
                //make more space
                offset = offset + 15;
            }
            change = (cash - total);
            //when we finish drawing all the items ,draw the total
            //make some space so that the total stands out
            offset = offset + 20;
            graphic.DrawString("Net a payer : ".PadRight(10) + string.Format("{0:f2}", total) + " €", new Font("Courier New", 12, FontStyle.Bold),
                new SolidBrush(Color.Black), startX, startY + offset);
            //make more space
            offset = offset + 30;

            graphic.DrawString("Cache : ".PadRight(10) + string.Format("{0:f2}", cash) + " €", font, new SolidBrush(Color.Black), startX, startY + offset);
            //make more space
            offset = offset + 15;
            graphic.DrawString("monnaie d'échange : ".PadRight(10) + string.Format("{0:f2}", change)+" €", font, new SolidBrush(Color.Black), startX, startY + offset);
            //make more space
            offset = offset + 40;
            if (currentCtsm.adress != "" && currentCtsm.adress!=""&&currentCtsm.phone!="") {
            graphic.DrawString("Adresse : ".PadRight(10) + currentCtsm.adress.Insert(22,"\n")+" "+currentCtsm.Zip, font, new SolidBrush(Color.Black), startX, startY + offset);
            //make more space
            offset = offset + 40;
            graphic.DrawString("Ville : ".PadRight(10) + currentCtsm.city, font, new SolidBrush(Color.Black), startX, startY + offset);
            //make more space
            offset = offset + 25;
            graphic.DrawString("Tel : ".PadRight(10) + currentCtsm.phone, font, new SolidBrush(Color.Black), startX, startY + offset);
            //make more space
            offset = offset + 15;
            }
            graphic.DrawString("  Merçi de votre commande",font, new SolidBrush(Color.Black), startX, startY+offset);
            offset = offset + 15;
            graphic.DrawString("    A Bientôt    ", font, new SolidBrush(Color.Black), startX, startY+offset);
        }
        #endregion

        private void searchFood_TextChanged(object sender, EventArgs e)
        {
            foodList.DataSource = null;
            this.foodList.DataSource = food_GetSearsch();
            this.foodList.DisplayMember = "foodName";
        }

        private void searchClient_TextChanged(object sender, EventArgs e)
        {
            customerList.DataSource = null;
            this.customerList.DataSource = customer_GetSearsch();
            this.customerList.DisplayMember = "orderShow";
        }
        public List<customer> customer_GetSearsch()
        {
            List<customer> output;
            //open the connection and close when done , never leave connection open
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<customer>("SELECT * FROM customer WHERE name  LIKE '%" + searchClient.Text + "%' or surName LIKE '%" + searchClient.Text + "%' or customerCode LIKE '%" + searchClient.Text + "%'").ToList();
            }
            return output;
        }
        public List<food> food_GetSearsch()
        {
            List<food> output;
            //open the connection and close when done , never leave connection open
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<food>("SELECT * FROM food WHERE name  LIKE '%" + searchFood.Text + "%' or category LIKE '%" + searchFood.Text + "%'").ToList();
            }
            return output;
        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.Show();
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            totale = 0;
            totalTxt.Text = totale + " €";
            receiptList.Items.Clear();
        }



    }
}
