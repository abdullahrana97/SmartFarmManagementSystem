using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;

namespace SmartFarmManagementSystem.AllClasses
{
    internal class WorkerBL
    {
        private string workername;
        private string workerphone;
        private string role;

        private int farmerid = LoginInfo.userid;

        public WorkerBL(string workername, string workerphone, string role)
        {
            this.workername = workername;
            this.workerphone = workerphone;
            this.role = role;

        }

        public bool checkinputs()
        {
            if (string.IsNullOrEmpty(workername) || string.IsNullOrEmpty(workerphone) || string.IsNullOrEmpty(role))
            {
                return false;
            }
            return true;
        }

        public bool addworker()
        {

            string query = $"Insert into worker (WorkerName,WorkerRole,Phone,FarmerId) values (@n,@r,@p,@f)";
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@n", workername);
                    cmd.Parameters.AddWithValue("@r", role);
                    cmd.Parameters.AddWithValue("@p", workerphone);
                    cmd.Parameters.AddWithValue("@f", farmerid);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {

                    return false;
                }
            }

        }

        public bool updateworker(int workerid)
        {
            string query = $"Update worker set WorkerName = @n,WorkerRole = @r,Phone = @p where WorkerId = @w and FarmerId = @f";
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@n", workername);
                    cmd.Parameters.AddWithValue("@r", role);
                    cmd.Parameters.AddWithValue("@p", workerphone);
                    cmd.Parameters.AddWithValue("@w", workerid);
                    cmd.Parameters.AddWithValue("@f", farmerid);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool deleteworker(int workerid)
        {
            string query = $"Delete from worker where WorkerId = @w and FarmerId = @f";
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@w", workerid);
                    cmd.Parameters.AddWithValue("@f", farmerid);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

      

    }
}
