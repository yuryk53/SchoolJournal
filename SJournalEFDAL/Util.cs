using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SJournalEFDAL
{
    public class Util
    {
        public static DataTable PopulateFromStoredProcedure(string procedureName, params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["schooljournalDisconnected"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);

            cmd = new SqlCommand(procedureName, conn);
            foreach (SqlParameter p in parameters)
            {
                cmd.Parameters.Add(p);
            }
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);

            conn.Close();

            return dt;
        }
    }
}
