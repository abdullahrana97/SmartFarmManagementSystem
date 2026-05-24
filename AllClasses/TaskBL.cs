using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFarmManagementSystem.AllClasses
{
    internal class TaskBL
    {
        private int fieldid;
        private int workerid;
        private int tasktypeid;
        private string status;
        private DateTime startdate;
        private DateTime? enddate;

        public TaskBL(int fieldid, int workerid, int tasktypeid,
                      string status, DateTime startdate, DateTime? enddate)
        {
            this.fieldid = fieldid;
            this.workerid = workerid;
            this.tasktypeid = tasktypeid;
            this.status = status;
            this.startdate = startdate;
            this.enddate = enddate;
        }

        public bool checkinputs()
        {
            if (fieldid <= 0 || workerid <= 0 ||
                tasktypeid <= 0 || string.IsNullOrEmpty(status))
                return false;
            return true;
        }

        public bool addTask()
        {
            string query = @"INSERT INTO task 
                            (FieldID, WorkerID, TaskTypeID, Status, StartDate, EndDate)
                            VALUES (@f, @w, @tt, @s, @sd, @ed)";

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@f", fieldid);
                    cmd.Parameters.AddWithValue("@w", workerid);
                    cmd.Parameters.AddWithValue("@tt", tasktypeid);
                    cmd.Parameters.AddWithValue("@s", status);
                    cmd.Parameters.AddWithValue("@sd", startdate);
                    cmd.Parameters.AddWithValue("@ed", enddate.HasValue ?
                                               (object)enddate.Value : DBNull.Value);
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

        public bool updateTask(int taskid)
        {
            string query = @"UPDATE task SET 
                            FieldID=@f, WorkerID=@w, TaskTypeID=@tt,
                            Status=@s, StartDate=@sd, EndDate=@ed
                            WHERE TaskID=@id";

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
             
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@f", fieldid);
                    cmd.Parameters.AddWithValue("@w", workerid);
                    cmd.Parameters.AddWithValue("@tt", tasktypeid);
                    cmd.Parameters.AddWithValue("@s", status);
                    cmd.Parameters.AddWithValue("@sd", startdate);
                    cmd.Parameters.AddWithValue("@ed", enddate.HasValue ?
                                               (object)enddate.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", taskid);
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

        public bool deleteTask(int taskid)
        {
            string query = "DELETE FROM task WHERE TaskID=@id";
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                 
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", taskid);
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

        public DataTable loadTasks()
        {
            string query;
            if (LoginInfo.role.ToLower() == "admin")
                query = "SELECT * FROM vw_AllTasks";
            else
                query = "SELECT * FROM vw_AllTasks WHERE FarmerID = " + LoginInfo.userid;

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

        // fetch worker role for validation
        public static string getWorkerRole(int workerid)
        {
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                
                    MySqlCommand cmd = new MySqlCommand(
                        "SELECT Role FROM worker WHERE WorkerID=@id", con);
                    cmd.Parameters.AddWithValue("@id", workerid);
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : "";
                }
                catch
                {
                    return "";
                }
            }
        }

        // fetch tasktype name for validation
        public static string getTaskTypeName(int tasktypeid)
        {
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                  
                    MySqlCommand cmd = new MySqlCommand(
                        "SELECT Name FROM tasktype WHERE TaskTypeID=@id", con);
                    cmd.Parameters.AddWithValue("@id", tasktypeid);
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : "";
                }
                catch
                {
                    return "";
                }
            }
        }
    }
}
