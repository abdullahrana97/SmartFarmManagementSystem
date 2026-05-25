using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFarmManagementSystem.AllClasses
{
    internal class BuyerBL
    {
        private string name;
        private string phone;

        public BuyerBL(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public bool checkinputs()
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
                return false;
            return true;
        }

        public bool addBuyer()
        {
            string query = "INSERT INTO buyer (Name, Phone) VALUES (@n, @p)";
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@n", name);
                    cmd.Parameters.AddWithValue("@p", phone);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool updateBuyer(int buyerid)
        {
            string query = "UPDATE buyer SET Name=@n, Phone=@p WHERE BuyerID=@id";
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@n", name);
                    cmd.Parameters.AddWithValue("@p", phone);
                    cmd.Parameters.AddWithValue("@id", buyerid);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool deleteBuyer(int buyerid)
        {
            string query = "DELETE FROM buyer WHERE BuyerID=@id";
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", buyerid);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable loadBuyers()
        {
            string query = "SELECT BuyerID, Name, Phone FROM buyer";
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }
    }
}
