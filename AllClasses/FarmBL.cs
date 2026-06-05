using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFarmManagementSystem.AllClasses
{
    internal class FarmBL
    {
        private string farmname;
        private string location;
        private string status;
        private int farmerid;

        public FarmBL(string farmname, string location,string status,int farmerid)
        {
            this.farmname = farmname;
            this.location = location;
            this.status = status;
            this.farmerid = farmerid;
        }


        public bool checkinputs()
        {
            if (string.IsNullOrEmpty(farmname) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(status)) { 

                return false;
            }

            else return true;
        }

        public bool addFarm()
        {
            string query = $"Insert into farm (Name,Status,Location,FarmerId) Values (@n,@s,@l,@fid);";

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@n", farmname);
                    cmd.Parameters.AddWithValue("@s", status);
                    cmd.Parameters.AddWithValue("@l", location);
                    cmd.Parameters.AddWithValue("@fid", farmerid);
                    cmd.ExecuteNonQuery();

                    return true;
                }

                catch(Exception)
                {
                    return false;
                }
            }
        }

        public bool updateFarm(int farmid)
        {
            string query = "UPDATE farm SET Name=@n, Status=@s, Location=@l WHERE FarmID=@id";

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@n", farmname);
                    cmd.Parameters.AddWithValue("@s", status);
                    cmd.Parameters.AddWithValue("@l", location);
                    cmd.Parameters.AddWithValue("@id", farmid);
                    cmd.ExecuteNonQuery();

                    return true;
                }

                catch (Exception)
                {
                    return false;
                }
            }

        }
        public bool deleteFarm(int farmid)
        {
            string query = "Delete from farm WHERE FarmID=@id";

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                 
                    cmd.Parameters.AddWithValue("@id", farmid);
                    cmd.ExecuteNonQuery();

                    return true;
                }

                catch (Exception)
                {
                    return false;
                }
            }

        }




    }
}
