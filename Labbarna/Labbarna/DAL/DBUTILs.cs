using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Labbarna.DAL
{
    class DBUTILs
    {
        public static SqlConnection Connect()
        {
            string connsting = "Data Source = DESKTOP-THBJUU3\\SQLEXPRESS;Initial Catalog = Patient; User ID = sa; Password=hej123 ";
            SqlConnection conn = new SqlConnection(connsting);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return conn;
        }

        public static DataSet spCarBrand(int maxPrice)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
           

            cmd.CommandText = "spCarBrand";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaxPrice", maxPrice);

            cmd.Connection = Connect();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            

            da.Fill(ds);
            return ds;
            

        }

        public static DataSet spSearchVariabel(string tableName)
        {
            try
            {

            
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();


            cmd.CommandText = "spSearchVariabel";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TableName", tableName);

            cmd.Connection = Connect();
            SqlDataAdapter da = new SqlDataAdapter(cmd);


            da.Fill(ds);
            return ds;
        } catch (SqlException ex)
            {
                if (ex.Number.Equals(208))
                {
                    Console.WriteLine("Bad name");
                }
                return null;
            }

    }





    }
}
