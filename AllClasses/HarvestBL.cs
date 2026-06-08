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
    internal class HarvestBL
    {
        private int plantationid;
        private decimal quantity;
        private DateTime harvestdate;

        public HarvestBL(int plantationid, decimal quantity, DateTime harvestdate)
        {
            this.plantationid = plantationid;
            this.quantity = quantity;
            this.harvestdate = harvestdate;
        }

        public bool checkinputs()
        {
            if (plantationid <= 0 || quantity <= 0)
                return false;
            return true;
        }

        public bool addHarvest()
        {
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                MySqlTransaction transaction = null;
                try
                {
                    transaction = con.BeginTransaction();

                    // insert harvest record
                    MySqlCommand cmd1 = new MySqlCommand(
                        @"INSERT INTO harvest (PlantationID, Quantity, HarvestDate)
                        VALUES (@p, @q, @d)", con, transaction);
                    cmd1.Parameters.AddWithValue("@p", plantationid);
                    cmd1.Parameters.AddWithValue("@q", quantity);
                    cmd1.Parameters.AddWithValue("@d", harvestdate);
                    cmd1.ExecuteNonQuery();

                    // update plantation status to Harvested
                    MySqlCommand cmd2 = new MySqlCommand(
                        "UPDATE plantation SET Status='Harvested' WHERE PlantationID=@id",
                        con, transaction);
                    cmd2.Parameters.AddWithValue("@id", plantationid);
                    cmd2.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool deleteHarvest(int harvestid)
        {
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                MySqlTransaction transaction = null;
                try
                {
                    transaction = con.BeginTransaction();

                    // get plantation id before deleting
                    MySqlCommand cmd0 = new MySqlCommand(
                        "SELECT PlantationID FROM harvest WHERE HarvestID=@id",
                        con, transaction);
                    cmd0.Parameters.AddWithValue("@id", harvestid);
                    int pid = Convert.ToInt32(cmd0.ExecuteScalar());

                    // delete harvest
                    MySqlCommand cmd1 = new MySqlCommand(
                        "DELETE FROM harvest WHERE HarvestID=@id", con, transaction);
                    cmd1.Parameters.AddWithValue("@id", harvestid);
                    cmd1.ExecuteNonQuery();

                    // revert plantation status back to Active
                    MySqlCommand cmd2 = new MySqlCommand(
                        "UPDATE plantation SET Status='Active' WHERE PlantationID=@id",
                        con, transaction);
                    cmd2.Parameters.AddWithValue("@id", pid);
                    cmd2.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable loadHarvests()
        {
            string query;
            if (LoginInfo.role.ToLower() == "admin")
                query = @"SELECT h.HarvestID, h.PlantationID,
                          CONCAT(c.Name,' - ',f.Name) AS Plantation,
                          h.Quantity as QuantityHarvested, h.HarvestDate
                          FROM harvest h
                          JOIN plantation p ON h.PlantationID = p.PlantationID
                          JOIN crop c ON p.CropID = c.CropID
                          JOIN field f ON p.FieldID = f.FieldID
                          JOIN farm fm ON f.FarmID = fm.FarmID
                          ORDER BY h.HarvestDate DESC";
            else
                query = @"SELECT h.HarvestID, h.PlantationID,
                          CONCAT(c.Name,' - ',f.Name) AS Plantation,
                          h.Quantity as QuantityHarvested, h.HarvestDate
                          FROM harvest h
                          JOIN plantation p ON h.PlantationID = p.PlantationID
                          JOIN crop c ON p.CropID = c.CropID
                          JOIN field f ON p.FieldID = f.FieldID
                          JOIN farm fm ON f.FarmID = fm.FarmID
                          WHERE fm.FarmerID = " + LoginInfo.userid + @"
                          ORDER BY h.HarvestDate DESC";

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
