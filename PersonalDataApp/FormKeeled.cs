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
    public partial class FormKeeled : Form
    {
        private int id;

        public FormKeeled(string title, string label, string button, int id)
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
                        tb = db.table("SELECT * FROM [dbo].[Keeled] WHERE Id = '" + id.ToString() + "'");
                        textKeel.Text = tb.Rows[0]["Keel"].ToString();
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

        public string Keel
        {
            get
            {
                return textKeel.Text.Replace("'", "''");
            }
        }
    }
}
