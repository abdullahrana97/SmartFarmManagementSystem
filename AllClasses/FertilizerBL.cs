using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFarmManagementSystem.AllClasses
{
    internal class FertilizerBL
    {

        private string name;
        private string type;

        public FertilizerBL(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public bool checkinputs()
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(type))
                return false;
            return true;
        }

        public bool addFertilizer()
        {
            string query = "INSERT INTO fertilizer (Name, Type) VALUES (@n, @t)";
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                { 
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@n", name);
                    cmd.Parameters.AddWithValue("@t", type);
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

        public bool updateFertilizer(int fertilizerID)
        {
            string query = "UPDATE fertilizer SET Name=@n, Type=@t WHERE FertilizerID=@id";
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@n", name);
                    cmd.Parameters.AddWithValue("@t", type);
                    cmd.Parameters.AddWithValue("@id", fertilizerID);
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

        public bool deleteFertilizer(int fertilizerID)
        {
            string query = "DELETE FROM fertilizer WHERE FertilizerID=@id";
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", fertilizerID);
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

        public DataTable loadFertilizers()
        {
            string query = "SELECT FertilizerID, Name, Type FROM fertilizer";
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
