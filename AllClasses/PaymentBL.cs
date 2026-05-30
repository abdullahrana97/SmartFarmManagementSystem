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
    internal class PaymentBL
    {
        private int saleid;
        private decimal amount;
        private string method;
        private DateTime paymentdate;

        public PaymentBL(int saleid, decimal amount, string method, DateTime paymentdate)
        {
            this.saleid = saleid;
            this.amount = amount;
            this.method = method;
            this.paymentdate = paymentdate;
        }

        public bool checkinputs()
        {
            if (saleid <= 0 || amount <= 0 || string.IsNullOrEmpty(method))
                return false;
            return true;
        }

        public bool updatePayment(int paymentid)
        {
            string query = @"UPDATE payment SET 
                    Amount = Amount + @a, 
                    Method = @m, 
                    PaymentDate = @d 
                    WHERE PaymentID = @id";

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@a", amount);
                    cmd.Parameters.AddWithValue("@m", method);
                    cmd.Parameters.AddWithValue("@d", paymentdate);
                    cmd.Parameters.AddWithValue("@id", paymentid);
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

        public DataTable loadPayments()
        {
            string query = @"SELECT 
                    p.PaymentID, 
                    p.SaleID,
                    b.Name AS Buyer,
                    (s.Quantity * s.Price) AS TotalAmount,
                    p.Amount, 
                    p.Method, 
                    p.PaymentDate
                    FROM payment p
                    JOIN sale s ON p.SaleID = s.SaleID
                    JOIN buyer b ON s.BuyerID = b.BuyerID
                    ORDER BY p.PaymentDate DESC";

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
