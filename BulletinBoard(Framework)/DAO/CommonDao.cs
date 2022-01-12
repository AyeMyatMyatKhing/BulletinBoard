using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Security.Cryptography;


namespace DAO
{
    public class CommonDao
    {
        static string constr = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        public static DataTable tblResult;
        public static string InsertItem = string.Empty;

        public static int  Insert(object[] arr ,string FieldName, string TableName)
        {
            int Id = 0;
            SqlTransaction tran;
            var cn = new SqlConnection();
            cn.ConnectionString = constr;
            cn.Open();
            tran = cn.BeginTransaction(IsolationLevel.ReadCommitted);
            var cmd = new SqlCommand();
            cmd.Connection = cn;
            if (arr is object)
            {
                for (int index = 1, loopTo = arr.Length - 1; index <= loopTo; index++)
                {
                    cmd.Parameters.AddWithValue("@" + index, arr[index - 1]);
                    if (index != arr.Length - 1)
                    {
                        InsertItem += "@" + index + ",";
                    }
                    else
                    {
                        InsertItem += "@" + index;
                    }
                }
            }

            try
            {
                cmd.CommandText = "INSERT INTO " + TableName + "(" + FieldName + ")" + " VALUES(" + InsertItem + ")";
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();
                cmd.CommandText = "";
                cmd.CommandText = "SELECT @@IDENTITY";
                Id = Convert.ToInt32(cmd.ExecuteScalar());
                tran.Commit();
                cn.Close();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                tblResult = null;
                throw ex;
            }

            return Id;

        }

        public static DataTable GetData(string commandText, CommandType commandType)
        {

            var cn = new SqlConnection();
            cn.ConnectionString = constr;
            cn.Open();
            var cmd = new SqlCommand(commandText, cn);
            cmd.CommandTimeout = 0;
            cmd.CommandType = commandType;
            try
            {
                var adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                var ds = new DataSet();
                adapter.Fill(ds);
                tblResult = ds.Tables[0];
            }
            catch (Exception ex)
            {
                tblResult = null;
                throw ex;
            }

            return tblResult;
        }

        public static bool Update(string UpdateQuery, object[] arr)
        {
            SqlTransaction tran;
            var conn = new SqlConnection(constr);
            conn.Open();
            tran = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            var cmd = new SqlCommand();
            cmd.Connection = conn;
            if (arr is object)
            {
                for (int index = 1, loopTo = arr.Length - 1; index <= loopTo; index++)
                {
                    cmd.Parameters.AddWithValue("@" + index, arr[index - 1]);
                    if (index != arr.Length - 1)
                    {
                        InsertItem += "@" + index + ",";
                    }
                    else
                    {
                        InsertItem += "@" + index;
                    }
                }
            }

            try
            {
                cmd.CommandText = UpdateQuery;
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();
                tran.Commit();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public static bool Delete(string UpdateQuery , object[] arr)
        {
            SqlTransaction tran;
            var conn = new SqlConnection(constr);
            conn.Open();
            tran = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            var cmd = new SqlCommand();
            cmd.Connection = conn;
            if (arr is object)
            {
                for (int index = 1, loopTo = arr.Length - 1; index <= loopTo; index++)
                {
                    cmd.Parameters.AddWithValue("@" + index, arr[index - 1]);
                    if (index != arr.Length - 1)
                    {
                        InsertItem += "@" + index + ",";
                    }
                    else
                    {
                        InsertItem += "@" + index;
                    }
                }
            }

            try
            {
                cmd.CommandText = UpdateQuery;
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();
                tran.Commit();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public static string Encrypt(string str)
        {
            string EncrptKey = "r00tpass";
            byte[] byKey = { };
            byte[] IV = { 18, 52, 86, 120, 144, 171, 205, 239 };
            byKey = System.Text.Encoding.UTF8.GetBytes(EncrptKey.Substring(0, 8));
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Encoding.UTF8.GetBytes(str);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Convert.ToBase64String(ms.ToArray());
        }

        public static string Decrypt(string str)
        {
            str = str.Replace(" ", "+");
            string DecryptKey = "r00tpass";
            byte[] byKey = { };
            byte[] IV = { 18, 52, 86, 120, 144, 171, 205, 239 };
            byte[] inputByteArray = new byte[str.Length];

            byKey = System.Text.Encoding.UTF8.GetBytes(DecryptKey.Substring(0, 8));
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            inputByteArray = Convert.FromBase64String(str.Replace(" ", "+"));
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;
            return encoding.GetString(ms.ToArray());
        }
    }
}
