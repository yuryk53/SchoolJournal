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
using System.Text.RegularExpressions;

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
        public static List<T> PopulateFromStoredProcedure<T>(string procedureName, Func<DataRow, T> rowMapper, params SqlParameter[] parameters)  where T:class
        {
            DataTable resultSet = PopulateFromStoredProcedure(procedureName, parameters);
            List<T> resultList = new List<T>();
            foreach (DataRow dr in resultSet.Rows)
            {
                T item = rowMapper(dr);
                resultList.Add(item);
            }
            return resultList;
        }
        public static bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn,
                   @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }
    }

}
