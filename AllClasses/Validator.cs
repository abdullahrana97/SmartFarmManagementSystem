using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFarmManagementSystem.AllClasses
{
    internal static class Validator
    {
        // check if field is empty
        public static bool IsEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        // check if value is a valid number
        public static bool IsValidNumber(string value)
        {
            decimal result;
            return decimal.TryParse(value, out result) && result > 0;
        }

        // check if area is valid decimal
        public static bool IsValidArea(string area)
        {
            decimal result;
            return decimal.TryParse(area, out result) && result > 0;
        }

        // check if quantity is valid
        public static bool IsValidQuantity(string qty)
        {
            decimal result;
            return decimal.TryParse(qty, out result) && result > 0;
        }
        public static bool IsValidPassword(string password)
        {
            return password.Length >= 6;
        }
        public static bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^03[0-9]{2}-?[0-9]{7}$");
        }

        // check if username is valid (min 4 chars, alphanumeric)
        public static bool IsValidUsername(string username)
        {
            return Regex.IsMatch(username, @"^[a-zA-Z0-9_]{4,}$");
        }

        // check if price is valid
        public static bool IsValidPrice(string price)
        {
            decimal result;
            return decimal.TryParse(price, out result) && result > 0;
        }

        // set error on control
        public static void SetError(ErrorProvider ep, Control ctrl, string message)
        {
            ep.SetError(ctrl, message);
        }

        // clear error on control
        public static void ClearError(ErrorProvider ep, Control ctrl)
        {
            ep.SetError(ctrl, "");
        }

        // clear all errors
        public static void ClearAll(ErrorProvider ep)
        {
            ep.Clear();
        }
    }
}
