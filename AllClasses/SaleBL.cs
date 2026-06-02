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
    internal class SaleBL
    {
        private int harvestid;
        private int buyerid;
        private decimal quantity;
        private decimal price;
        private DateTime saledate;

        public SaleBL(int harvestid, int buyerid, decimal quantity,
                      decimal price, DateTime saledate)
        {
            this.harvestid = harvestid;
            this.buyerid = buyerid;
            this.quantity = quantity;
            this.price = price;
            this.saledate = saledate;
        }

        public bool checkinputs()
        {
            if (harvestid <= 0 || buyerid <= 0 ||
                quantity <= 0 || price <= 0)
                return false;
            return true;
        }

        public bool addSale()
        {
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                MySqlTransaction transaction = null;
                try
                {
                    transaction = con.BeginTransaction();

                    MySqlCommand cmd1 = new MySqlCommand(
                        @"INSERT INTO sale (HarvestID, BuyerID, Quantity, Price, SaleDate)
                VALUES (@h, @b, @q, @p, @d)", con, transaction);
                    cmd1.Parameters.AddWithValue("@h", harvestid);
                    cmd1.Parameters.AddWithValue("@b", buyerid);
                    cmd1.Parameters.AddWithValue("@q", quantity);
                    cmd1.Parameters.AddWithValue("@p", price);
                    cmd1.Parameters.AddWithValue("@d", saledate);
                    cmd1.ExecuteNonQuery();

                    long saleid = cmd1.LastInsertedId;

                    MySqlCommand cmd2 = new MySqlCommand(
                        @"INSERT INTO payment (SaleID, Amount, PaymentDate, Method)
                VALUES (@s, @a, @d, 'Pending')", con, transaction);
                    cmd2.Parameters.AddWithValue("@s", saleid);
                    cmd2.Parameters.AddWithValue("@a", 0);
                    cmd2.Parameters.AddWithValue("@d", saledate);
                    cmd2.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    MessageBox.Show("Sale error: " + ex.Message); 
                    return false;
                }
            }
        }

        public bool deleteSale(int saleid)
        {
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(
                        "DELETE FROM sale WHERE SaleID=@id", con);
                    cmd.Parameters.AddWithValue("@id", saleid);
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

        public DataTable loadSales()
        {
            string query = "SELECT * FROM vw_SalesDetails ORDER BY SaleDate DESC";
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
