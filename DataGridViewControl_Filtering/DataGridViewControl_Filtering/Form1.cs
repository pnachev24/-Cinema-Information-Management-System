using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Data;
using static DataGridViewControl_Filtering.authenticate;

namespace DataGridViewControl_Filtering
{
    public partial class Form1 : Form
    {

        private User authenticatedUser;


        public Form1(User user)
        {
            InitializeComponent();
            this.authenticatedUser = user;
            usernameLabel.Text = $"Welcome, {authenticatedUser.Username}";
        }


        // Event handler for when the form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC19\SQLEXPRESS; Initial Catalog=DataGridView; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Start with a base SQL query
                string query = "SELECT * FROM Cinema WHERE 1 = 1";

                // Create a list to store the conditions for filtering
                List<string> conditions = new List<string>();

                // Check each ComboBox and add a condition if an item is selected
                if (status.SelectedItem != null)
                    conditions.Add("status = @status");

                if (roomType.SelectedItem != null)
                    conditions.Add("roomType = @roomType");

                if (availability.SelectedItem != null)
                    conditions.Add("availability = @roomAvailability");

                if (roomNo.SelectedItem != null)
                    conditions.Add("roomNo = @roomNo");

                // combine the conditions into the SQL query
                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                // Set parameters based on selected values
                if (status.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@status", status.SelectedItem.ToString());
                if (roomType.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@roomType", roomType.SelectedItem.ToString());
                if (availability.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@roomAvailability", availability.SelectedItem.ToString());
                if (roomNo.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@roomNo", roomNo.SelectedItem.ToString());

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            roomType.SelectedIndex = -1;
            availability.SelectedIndex = -1;
            status.SelectedIndex = -1;
            roomNo.SelectedIndex = -1;
        }

        private void checkIn_Click(object sender, EventArgs e)
        {
            using (check_in userInputForm = new check_in())
            {
                // Display the form as a dialog
                userInputForm.ShowDialog();

            }
        }


    }
}