using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Minishop
{
    class DungChung
    {
        public static int ID_Role;
        public static string DSChucNang;
        public static int ID_User;
        public static string User_name;
        public static string Role_name;


        OleDbConnection conn = new OleDbConnection();

        public void loadData()
        {
            conn.ConnectionString = @"Provider=Microsoft.Jet.Oledb.4.0;Data Source=C:\Users\ADMIN88\source\repos\QL_Thuoc\data\CSDL\QuanLyQuayThuoc.mdb";
            conn.Open();
        }

        public DataTable query(String a, String tbl, String param) {
            loadData();

            String sql = String.Format("Select {0} From {1} {2}", a, tbl, param);
            OleDbDataAdapter ad = new OleDbDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);

            conn.Close();

            return tb;

        }


        public void Delete( String table, String param)
        {
            loadData();

            String sql = String.Format("Delete From {0} {1}", table, param);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

        }


        public void Insert(String table, String columns, String values)
        {
            loadData();

            String sql = String.Format("INSERT INTO {0} {1} VALUES {2}", table, columns, values);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public void Update(String table, String param)
        {
            loadData();
            
            String sql = String.Format("UPDATE {0} SET {1}", table, param);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

        }

    }
}
