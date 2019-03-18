using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonalDataApp
{
    public partial class FormKeeleTasud : Form
    {
        private int id;

        public FormKeeleTasud(string title, string label, string button, int id)
        {
            InitializeComponent();

            this.Text = title;
            label1.Text = label;
            buttonAddEdit.Text = button;
            this.id = id;

            if (id > 0)
            {
                DataTable tb = new DataTable();
                Database db = new Database();
                db.open();

                if (db.Connected)
                {
                    try
                    {
                        tb = db.table("SELECT * FROM [dbo].[KeeleTasud] WHERE Id = '" + id.ToString() + "'");
                        textTase.Text = tb.Rows[0]["Tase"].ToString();
                        numSumma.Value = Convert.ToDecimal(tb.Rows[0]["Summa"]);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                    db.close();
                }
            }
        }

        public string Id
        {
            get
            {
                return id.ToString();
            }
        }

        public string Tase
        {
            get
            {
                return textTase.Text.Replace("'", "''");
            }
        }

        public string Summa
        {
            get
            {
                return numSumma.Value.ToString().Replace(",", ".");
            }
        }
    }
}
