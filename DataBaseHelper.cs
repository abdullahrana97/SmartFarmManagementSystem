using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

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




    }
}
