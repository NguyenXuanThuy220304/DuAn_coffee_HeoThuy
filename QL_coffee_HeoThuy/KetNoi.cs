using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_coffee_HeoThuy
{
    internal class KetNoi
    {
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True");
        public bool TestConnection()
        {
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("failed" + e.Message);
                return false;
            }
        }
    }
}
