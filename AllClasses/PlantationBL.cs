using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFarmManagementSystem.AllClasses
{
    internal class PlantationBL
    {
        private int fieldid;
        private int cropid;
        private string status;
        private DateTime plantingdate;
        private DateTime expectedharvestdate;

        public PlantationBL(int fieldid, int cropid, DateTime plantingdate, string status)
        {
            this.fieldid = fieldid;
            this.cropid = cropid;
            this.plantingdate = plantingdate;
            this.status = status;
        }

        public bool checkinput()
        {
            if (fieldid <= 0 || cropid <= 0)
            {
                return false;
            }
           
           
            return true;
        }

        public DateTime? gettingharvestdate()
        {
            string query = $"Select DaysToHarvest from crop where CropId = {cropid}";
            using (MySqlConnection conn = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int growthduration = Convert.ToInt32(cmd.ExecuteScalar());
                    expectedharvestdate = plantingdate.AddDays(growthduration);
                    return expectedharvestdate;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }



        public bool saveplantation()
        {
            gettingharvestdate();

            string query = "Insert into plantation (FieldId,CropId,PlantingDate,ExpectedHarvestDate,status) values (@fieldid,@cropid,@plantingdate,@expectedharvestdate,@status)";
            using (MySqlConnection conn = DataBaseHelper.getconnection())
            {
                MySqlTransaction transaction = null;
                try
                {
                    transaction = conn.BeginTransaction();
                    MySqlCommand cmd = new MySqlCommand(query, conn,transaction);

                    cmd.Parameters.AddWithValue("@fieldid", this.fieldid);
                    cmd.Parameters.AddWithValue("@cropid", this.cropid);
                    cmd.Parameters.AddWithValue("@plantingdate", this.plantingdate);
                    cmd.Parameters.AddWithValue("@expectedharvestdate",this. expectedharvestdate);
                    cmd.Parameters.AddWithValue("@status", this.status);

                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return false;

                }
            }
        }

        public bool updateplantation(int plantationid)
        {
            if (plantationid <= 0)
            {
                return false;
            }

            gettingharvestdate();

            string query = "Update plantation set FieldId = @fieldid, CropId = @cropid, PlantingDate = @plantingdate, ExpectedHarvestDate = @expectedharvestdate, status = @status where PlantationId = @plantationid";
            using (MySqlConnection conn = DataBaseHelper.getconnection())
            {
                MySqlTransaction transaction = null;

                try
                {
                    transaction = conn.BeginTransaction();
                    MySqlCommand cmd = new MySqlCommand(query, conn,transaction);

                   

                    cmd.Parameters.AddWithValue("@fieldid", this.fieldid);
                    cmd.Parameters.AddWithValue("@cropid", this.cropid);
                    cmd.Parameters.AddWithValue("@plantingdate", this.plantingdate);
                    cmd.Parameters.AddWithValue("@status", this.status);
                    cmd.Parameters.AddWithValue("@expectedharvestdate", this.expectedharvestdate);
                    cmd.Parameters.AddWithValue("@plantationid", plantationid);
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public bool deleteplanataion(int plantationid)
        {
            
            string query = "Delete from plantation where PlantationId = @plantationid";
            using (MySqlConnection conn = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@plantationid", plantationid);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }


        public DataTable loaddgvplantations()
        {
            string query;
            if (LoginInfo.role.ToLower() == "admin")
                query = "SELECT * FROM vw_plantationdetails";
            else
                query = "SELECT * FROM vw_plantationdetails WHERE FarmerID = " + LoginInfo.userid;

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
