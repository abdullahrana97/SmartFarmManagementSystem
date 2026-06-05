using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFarmManagementSystem.AllClasses
{
    internal class FertilizerApplicationBL
    {
        private int fieldID;
        private int fertilizerID;
        private int workerID;
        private decimal quantityused;
        private DateTime applicationdate;

        public FertilizerApplicationBL(int fieldID, int fertilizerID,int workerID, decimal quantityused,DateTime applicationdate)
        {
            this.fieldID = fieldID;
            this.fertilizerID = fertilizerID;
            this.workerID = workerID;
            this.quantityused = quantityused;
            this.applicationdate = applicationdate;
        }

        public bool checkinputs()
        {
            if (fieldID <= 0 || fertilizerID <= 0 ||
                workerID <= 0 || quantityused <= 0)
                return false;
            return true;
        }

        public bool addApplication()
        {
            string query = @"INSERT INTO fertilizerapplication 
                            (FieldID, FertilizerID, WorkerID, QuantityUsed, ApplicationDate)
                            VALUES (@f, @fert, @w, @q, @d)";
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@f", fieldID);
                    cmd.Parameters.AddWithValue("@fert", fertilizerID);
                    cmd.Parameters.AddWithValue("@w", workerID);
                    cmd.Parameters.AddWithValue("@q", quantityused);
                    cmd.Parameters.AddWithValue("@d", applicationdate);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    // trigger will throw error if not enough stock
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool deleteApplication(int applicationID)
        {
            string query = "DELETE FROM fertilizerapplication WHERE ApplicationID=@id";
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", applicationID);
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

        public DataTable loadApplications()
        {
            string query;
            if (LoginInfo.role.ToLower() == "admin")
                query = @"SELECT fa.ApplicationID,
                  field.Name AS FieldName,
                    field.FieldId,
                  farm.Name AS FarmName,
                  fert.Name AS Fertilizer,
                    fert.FertilizerID,
                  w.WorkerName AS Worker,
                  w.WorkerID,
                  fa.QuantityUsed,
                  fa.ApplicationDate
                  FROM fertilizerapplication fa
                  JOIN field ON fa.FieldID = field.FieldID
                  JOIN farm ON field.FarmID = farm.FarmID
                  JOIN fertilizer fert ON fa.FertilizerID = fert.FertilizerID
                  JOIN worker w ON fa.WorkerID = w.WorkerID
                  ORDER BY fa.ApplicationDate DESC";
            else
                query = @"SELECT fa.ApplicationID,
                  field.Name AS FieldName,
                  farm.Name AS FarmName,
                  field.FieldId,
                  w.WorkerID,
                  fert.Name AS Fertilizer,
                  fert.FertilizerID,
                  w.WorkerName AS Worker,
                  fa.QuantityUsed,
                  fa.ApplicationDate
                  FROM fertilizerapplication fa
                  JOIN field ON fa.FieldID = field.FieldID
                  JOIN farm ON field.FarmID = farm.FarmID
                  JOIN fertilizer fert ON fa.FertilizerID = fert.FertilizerID
                  JOIN worker w ON fa.WorkerID = w.WorkerID
                  WHERE farm.FarmerID = " + LoginInfo.userid + @"
                  ORDER BY fa.ApplicationDate DESC";

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
