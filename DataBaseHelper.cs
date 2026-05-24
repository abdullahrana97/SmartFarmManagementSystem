using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFarmManagementSystem
{
    internal class DataBaseHelper
    {

        private static string connectionstring= "server=localhost;user id=root;database=smartfarmdb;password=2025cs196";

        public static MySqlConnection getconnection()
        {
            MySqlConnection con = new MySqlConnection(connectionstring);
            
                try
                {
                    con.Open();
                    return con;
                }

                catch(Exception ex)
                {
                    MessageBox.Show("Connection Failed");
                    return null;
                }
            
        }


        public static void FillComboBox(ComboBox combo, string query, string displayMember, string valueMember)
        {
            try
            {
                // Replace with your actual connection string
                using (MySqlConnection conn = getconnection())
                {
                    
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind the data
                    combo.DataSource = dt;
                    combo.DisplayMember = displayMember; // What the user sees (e.g., "CropName")
                    combo.ValueMember = valueMember;     // The ID stored in DB (e.g., "CropID")

                    // Optional: Start with an empty selection
                    combo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ComboBox: " + ex.Message);
            }
        }


        public static void SetComboValue(ComboBox cmb, string valueMember, int id)
        {
            foreach (DataRowView row in cmb.Items)
            {
                if (Convert.ToInt32(row[valueMember]) == id)
                {
                    cmb.SelectedItem = row;
                    return;
                }
            }
        }

    }
}
