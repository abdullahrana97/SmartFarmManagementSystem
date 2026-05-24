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
    internal class FertilizerStockBL
    {
        private int fertilizerID;
        private double quantityadded;
        private DateTime stockdate;

        public FertilizerStockBL(int fertilizerID, double quantityadded, DateTime stockdate)
        {
            this.fertilizerID = fertilizerID;
            this.quantityadded = quantityadded;
            this.stockdate = stockdate;
        }

        public bool checkinputs()
        {
            if (fertilizerID <= 0 || quantityadded <= 0)
                return false;
            return true;
        }

        public bool addStock()
        {
            string query = @"INSERT INTO fertilizerstock 
                            (FertilizerID, QuantityAdded, StockDate) 
                            VALUES (@f, @q, @d)";
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@f", fertilizerID);
                    cmd.Parameters.AddWithValue("@q", quantityadded);
                    cmd.Parameters.AddWithValue("@d", stockdate);
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

        public bool deleteStock(int stockID)
        {
            string query = "DELETE FROM fertilizerstock WHERE StockID=@id";
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", stockID);
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

        public DataTable loadStock()
        {
            string query = @"SELECT fs.StockID, f.FertilizerID,f.Name AS Fertilizer,
                            fs.QuantityAdded, fs.StockDate
                            FROM fertilizerstock fs
                            JOIN fertilizer f ON fs.FertilizerID = f.FertilizerID
                            ORDER BY fs.StockDate DESC";
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

        public DataTable loadAvailableStock()
        {
            string query = "SELECT * FROM vw_FertilizerAvailable";
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
