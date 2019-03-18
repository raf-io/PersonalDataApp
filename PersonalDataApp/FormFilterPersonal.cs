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
    public partial class FormFilterPersonal : Form
    {
        public FormFilterPersonal()
        {
            InitializeComponent();

            comboBoxSugu.Items.Add(new ComboItem(0, "Kõik"));
            comboBoxSugu.Items.Add(new ComboItem(1, "Mees"));
            comboBoxSugu.Items.Add(new ComboItem(2, "Naine"));
            comboBoxSugu.SelectedIndex = 0;
            comboBoxKeel.Items.Add(new ComboItem(0, "Kõik"));
            comboBoxKeel.SelectedIndex = 0;
            comboBoxTase.Items.Add("Kõik");
            comboBoxTase.SelectedIndex = 0;

            DataTable tb = new DataTable();
            Database db = new Database();
            db.open();

            if (db.Connected)
            {
                try
                {
                    tb = db.table("SELECT * FROM [dbo].[Keeled]");

                    for (int i = 0; i < tb.Rows.Count; i++)
                    {
                        comboBoxKeel.Items.Add(new ComboItem(Convert.ToInt32(tb.Rows[i]["Id"]), tb.Rows[i]["Keel"].ToString()));
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }

                db.close();
                db = new Database();
                db.open();

                try
                {
                    tb = db.table("SELECT Tase FROM [dbo].[KeeleTasud]");

                    for (int i = 0; i < tb.Rows.Count; i++)
                    {
                        comboBoxTase.Items.Add(tb.Rows[i]["Tase"].ToString());
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }

                db.close();
            }
        }

        public string Sugu
        {
            get
            {
                ComboItem item = comboBoxSugu.SelectedItem as ComboItem;

                return item.Key.ToString();
            }
        }

        public string Keel
        {
            get
            {
                ComboItem item = comboBoxKeel.SelectedItem as ComboItem;
                string val = item.Value;

                if (val == "Kõik") val = "*";

                return val;
            }
        }

        public string Tase
        {
            get
            {
                string val = comboBoxTase.SelectedItem.ToString();

                if (val == "Kõik") val = "*";

                return val;
            }
        }

        public string VanusAlates
        {
            get
            {
                return numVA.Value.ToString();
            }
        }

        public string VanusKuni
        {
            get
            {
                return numVK.Value.ToString();
            }
        }
    }
}
