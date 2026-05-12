using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFarmManagementSystem.AllClasses
{
    internal class FieldBL
    {
        private string fieldname;
        private double area;
        private int soiltypeid;
        private int farmid;


        public FieldBL(string fieldname, double area, int soiltypeid, int farmid)
        {
            this.fieldname = fieldname;
            this.area = area;
            this.soiltypeid = soiltypeid;
            this.farmid = farmid;
        }


        public bool checkinputs()
        {
            if (area <= 0 || double.TryParse(area.ToString(), out double result) == false)
            {
                MessageBox.Show("Please enter a valid positive number for area.");

                return false;
            }
            if (string.IsNullOrEmpty(fieldname) || soiltypeid <= 0 || farmid <= 0)
            {
                return false;

            }
            else return true;

        }

        public bool addField()
        {
            string query = $"Insert into field (Name,Area,SoilTypeID,FarmId) Values (@n,@a,@st,@fid);";
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@n", fieldname);
                    cmd.Parameters.AddWithValue("@a", area);
                    cmd.Parameters.AddWithValue("@st", soiltypeid);
                    cmd.Parameters.AddWithValue("@fid", farmid);
                    cmd.ExecuteNonQuery();
                    return true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding field: " + ex.Message);
                    return false;

                }
            }
        }

            public bool updateField(int fieldid)
            {
                string query = $"Update field set Name=@n, Area=@a, SoilTypeID=@st, FarmId=@fid where FieldID = @id;";
                using (MySqlConnection con = DataBaseHelper.getconnection())
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@n", fieldname);
                        cmd.Parameters.AddWithValue("@a", area);
                        cmd.Parameters.AddWithValue("@st", soiltypeid);
                        cmd.Parameters.AddWithValue("@fid", farmid);
                        cmd.Parameters.AddWithValue("@id", fieldid);
                        cmd.ExecuteNonQuery();
                        return true;
    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating field: " + ex.Message);
                        return false;
    
                    }
                }
        }

        public bool deleteField(int fieldid)
        {
            string query = $"Delete from field where FieldID = @id;";
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", fieldid);
                    cmd.ExecuteNonQuery();
                    return true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting field: " + ex.Message);
                    return false;

                }
            }
        }
        }
}
