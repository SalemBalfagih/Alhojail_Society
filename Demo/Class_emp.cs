using System;
using System.Data;
using System.Data.SqlClient;

namespace OutlookDemo

{
    class Class_emp
    {
        public SqlCommand cmd;
        public DataTable dtitem = new DataTable();

        public void loaditem()
        {
            
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Class_conn.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "loaddata";
                Class_conn.cn.Open();
                dtitem.Load(cmd.ExecuteReader());
                Class_conn.cn.Close();
           
        }

        int num;
        public int MaxID()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Class_conn.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MAXIDitemSP";
                Class_conn.cn.Open();
                //ExecuteScalar يرجع قيمة اخر رقم
                num = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch
            {
                num = 0;
            }
            Class_conn.cn.Close();
            return num;
        }
       
       
        public void insertpro_image(int number, string name, string b_name, string team,string cust, string age, int id, byte[] code,byte[] img)
        {

            cmd = new SqlCommand();
            cmd.Connection = Class_conn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insertprodactimageSP";
            cmd.Parameters.Add("@number", SqlDbType.Int).Value = number;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = name;
            cmd.Parameters.Add("@b_name", SqlDbType.VarChar, 50).Value = b_name;
            cmd.Parameters.Add("@team", SqlDbType.VarChar,50).Value = team;
            cmd.Parameters.Add("@cust", SqlDbType.VarChar, 50).Value = cust;
            cmd.Parameters.Add("@age", SqlDbType.VarChar, 50).Value = age;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@code", SqlDbType.Image).Value = code;
            cmd.Parameters.Add("@img", SqlDbType.Image).Value = img;
            Class_conn.cn.Open();
            cmd.ExecuteNonQuery();
            Class_conn.cn.Close();
        }

        public void updateprodactImage( string name, string b_name, string team, string cust, string age, int id, byte[] img)
        {

            cmd = new SqlCommand();
            cmd.Connection = Class_conn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updateprodactImag";
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = name;
            cmd.Parameters.Add("@b_name", SqlDbType.VarChar, 50).Value = b_name;
            cmd.Parameters.Add("@team", SqlDbType.VarChar, 50).Value = team;
            cmd.Parameters.Add("@cust", SqlDbType.VarChar, 50).Value = cust;
            cmd.Parameters.Add("@age", SqlDbType.VarChar, 50).Value = age;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@img", SqlDbType.Image).Value = img;
            Class_conn.cn.Open();
            cmd.ExecuteNonQuery();
            Class_conn.cn.Close();
        }
        
       

        public void deleteitem(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Class_conn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "deleteitemSP";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            Class_conn.cn.Open();
            cmd.ExecuteNonQuery();
            Class_conn.cn.Close();
        }

        public DataTable getimgpro(string id)
        {

            DataTable dt = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = Class_conn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getimageproSP";
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 50).Value = id;
            Class_conn.cn.Open();
            dt.Load(cmd.ExecuteReader());
            Class_conn.cn.Close();
            return dt;

        }
        public void searchpro(string text)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Class_conn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "searchpr";
            cmd.Parameters.Add("@search", SqlDbType.VarChar, 50).Value = text;
            Class_conn.cn.Open();
            dtitem.Load(cmd.ExecuteReader());
            Class_conn.cn.Close();
        }

        public void oneprint()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Class_conn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "oneprint";
            Class_conn.cn.Open();
            dtitem.Load(cmd.ExecuteReader());
            Class_conn.cn.Close();

        }
        public void oneprint1(int text)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Class_conn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "oneprint1";
            cmd.Parameters.Add("@id", SqlDbType.Int, 50).Value = text;
            Class_conn.cn.Open();
            dtitem.Load(cmd.ExecuteReader());
            Class_conn.cn.Close();
        }
    }
}
