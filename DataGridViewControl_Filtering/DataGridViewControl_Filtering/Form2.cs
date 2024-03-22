using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataGridViewControl_Filtering.authenticate;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace DataGridViewControl_Filtering
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            // Connecting to the database


            string user = uNameTxt.Text;
            string pass = passwordTxt.Text;

            // Validate input before attempting authentication
            if (!string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(pass))
            {
                authenticate.User authenticatedUser = DatabaseManager.AuthenticateUser(user, pass);

                if (authenticatedUser != null)
                {
                    // Display the username on Form5
                    Form1 welcome = new Form1(authenticatedUser);
                    welcome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }



            //this.Hide();
            //Form1 login = new Form1();
            //login.ShowDialog();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
