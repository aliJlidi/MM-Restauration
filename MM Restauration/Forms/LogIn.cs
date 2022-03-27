using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Threading;
using System.Windows.Forms;


namespace MM_Restauration
{
    public partial class LogIn : Form
    {
        SQLiteConnection con = new SQLiteConnection();
        SqlCommand com = new SqlCommand();
        //Check logIn
        public static bool LogedIn = false; 
        public LogIn()
        {
            //new thread to start the loading page 
            Thread trd = new Thread(new ThreadStart(formRun));
            //start the thread 
           trd.Start();
            // take some time to show the loading
            Thread.Sleep(3500);

            InitializeComponent();
            //stop the thread 
            trd.Abort();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }
        private void formRun()
        {
            Application.Run(new LoadingPage());
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            //open connection
            con.Open();
            //create the query
            string query = "SELECT * FROM Users WHERE user='" + username.Text + "'AND password='" + password.Text + "'";
            // create the command 
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.ExecuteNonQuery();
            SQLiteDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (username.Text.Equals(dr["user"].ToString()) && password.Text.Equals(dr["password"].ToString()))
                {
                    LogedIn = true;
                    con.Close();
                    this.Close();
                }
                else
                {
                    CustomizedErrorMessage.Show("Utilisateur non trouvé \n Ou mot de pass incorrect \n Réessayer!", "MSG", "OK!");
                }
            }
            else
            {
                CustomizedErrorMessage.Show("Utilisateur non trouvé \n Ou mot de pass incorrect \n Réessayer!", "MSG", "OK!");
                con.Close();
            }
   
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
