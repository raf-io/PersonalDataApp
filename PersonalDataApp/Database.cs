using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PersonalDataApp
{
    class Database
    {
        private bool connected = false;
        private SqlCommand cmd = new SqlCommand();
        private DataTable tb = new DataTable();
        private SqlConnection dbc = new SqlConnection();
        private SqlDataAdapter da = new SqlDataAdapter();

        public bool Connected
        {
            get
            {
                return connected;
            }
        }

        public Database()
        {
            dbc.ConnectionString = "Server=localhost; uid=sa; pwd=password; database=personal";
        }

        public void open()
        {
            try
            {
                dbc.Open();
                connected = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot connect to database server!", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public void close()
        {
            dbc.Close();
            connected = false;
        }

        public DataTable table(string sql)
        {
            cmd.CommandText = sql;
            cmd.Connection = dbc;
            da.SelectCommand = cmd;
            da.Fill(tb);

            return tb;
        }

        public void cmd_exec(string sql)
        {
            //dbc.Open();
            cmd.CommandText = sql;
            cmd.Connection = dbc;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot execute query!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

            //close();
        }
    }
}
