using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;

namespace SmartFarmManagementSystem.AllClasses
{
    internal class PlantationBL
    {
        private int fieldid;
        private int cropid;
        private DateTime plantingdate;
        private DateTime expectedharvestdate;

        public PlantationBL(int fieldid, int cropid, DateTime plantingdate)
        {
            this.fieldid = fieldid;
            this.cropid = cropid;
            this.plantingdate = plantingdate;

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

            string query = "Insert into plantation (FieldId,CropId,PlantingDate,ExpectedHarvestDate) values (@fieldid,@cropid,@plantingdate,@expectedharvestdate)";
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

            string query = "Update plantation set FieldId = @fieldid, CropId = @cropid, PlantingDate = @plantingdate, ExpectedHarvestDate = @expectedharvestdate where PlantationId = @plantationid";
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

            if (LoginInfo.role.ToLower() == "farmer")
            {
                query = $"Select p.PlantationId,c.Name as CropName,c.Season,f.Name as FieldName,fm.Name as FarmName,p.PlantingDate,p.ExpectedHarvestDate from plantation p join crop c on p.CropId = C.CropId  join field f on p.FieldId = f.FieldId join farm fm on f.FarmId = fm.FarmId where fm.FarmerId = "+ LoginInfo.userid;
            }

            else
            {
                query = $"Select p.PlantationId,c.Name as CropName,c.Season,f.Name as FieldName,fm.Name as FarmName,p.PlantingDate,p.ExpectedHarvestDate from plantation p join crop c on p.CropId = C.CropId  join field f on p.FieldId = f.FieldId join farm fm on f.FarmId = fm.FarmId";
            }

            using(MySqlConnection con = DataBaseHelper.getconnection())
            {

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    adp.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    return null;
                }

            }
        }

    }
}
