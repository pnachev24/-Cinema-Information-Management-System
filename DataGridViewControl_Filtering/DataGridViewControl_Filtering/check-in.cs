using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewControl_Filtering
{
    public partial class check_in : Form
    {
        public check_in()
        {
            InitializeComponent();
        }
        private void phoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (phoneNumber.Text.Length <= 9)
            {
                MessageBox.Show("The phone number should be at least 10 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phoneNumber.Focus();
                e.Cancel = true;
            }
        }


        private void reserve_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC19\SQLEXPRESS; Initial Catalog=DataGridView; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Check if the room is available
                string availabilityQuery = "SELECT availability FROM Cinema WHERE roomNo = @roomNo";

                SqlCommand availabilityCmd = new SqlCommand(availabilityQuery, sqlCon);
                availabilityCmd.Parameters.AddWithValue("@roomNo", roomNumber.Text);
                string availabilityResult = availabilityCmd.ExecuteScalar().ToString().Trim();

                if (availabilityResult.Equals("Available", StringComparison.OrdinalIgnoreCase))
                {
                    // Room is available, proceed with booking
                    string insertQuery = "INSERT INTO CheckInInformation VALUES (@roomNo, @guestName, @phoneNumber, @checkInDate, @checkOutDate)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon);

                    // Set parameters based on selected values
                    insertCmd.Parameters.AddWithValue("@roomNo", roomNumber.Text);
                    insertCmd.Parameters.AddWithValue("@guestName", guestName.Text);
                    insertCmd.Parameters.AddWithValue("@phoneNumber", phoneNumber.Text);
                    insertCmd.Parameters.AddWithValue("@checkInDate", checkInDate.Value);
                    insertCmd.Parameters.AddWithValue("@checkOutDate", checkOutDate.Value);

                    insertCmd.ExecuteNonQuery();

                    // Update room availability status
                    string updateAvailabilityQuery = "UPDATE Cinema SET availability = 'Booked' WHERE roomNo = @roomNo";
                    SqlCommand updateAvailabilityCmd = new SqlCommand(updateAvailabilityQuery, sqlCon);
                    updateAvailabilityCmd.Parameters.AddWithValue("@roomNo", roomNumber.Text);
                    updateAvailabilityCmd.ExecuteNonQuery();

                    MessageBox.Show("Booking Successful!");
                }
                else
                {
                    // Room is not available
                    MessageBox.Show("Sorry, the room is not available for booking.");
                }
            }
        }
    }
}
// ADD ANOTHER TABLE INTO YOUR DATABASE, THAT MAKES SENSE.
// CREATE ANOTHER DIALOG IN YOUR PROGRAM TO COLLECT INFORMATION FROM YOUR USERS
// INSERT THE INFORMATION INTO YOUR NEW TABLE.