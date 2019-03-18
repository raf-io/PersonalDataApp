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
    public partial class FormFilterPalgad : Form
    {
        public FormFilterPalgad()
        {
            InitializeComponent();

            comboBoxKuu.Items.Add(new ComboItem(0, "Kõik"));
            comboBoxKuu.Items.Add(new ComboItem(1, "Jaanuar"));
            comboBoxKuu.Items.Add(new ComboItem(2, "Veebruar"));
            comboBoxKuu.Items.Add(new ComboItem(3, "Märts"));
            comboBoxKuu.Items.Add(new ComboItem(4, "Aprill"));
            comboBoxKuu.Items.Add(new ComboItem(5, "Mai"));
            comboBoxKuu.Items.Add(new ComboItem(6, "Juuni"));
            comboBoxKuu.Items.Add(new ComboItem(7, "Juuli"));
            comboBoxKuu.Items.Add(new ComboItem(8, "August"));
            comboBoxKuu.Items.Add(new ComboItem(9, "September"));
            comboBoxKuu.Items.Add(new ComboItem(10, "Oktoober"));
            comboBoxKuu.Items.Add(new ComboItem(11, "November"));
            comboBoxKuu.Items.Add(new ComboItem(12, "Detsember"));
            comboBoxKuu.SelectedIndex = 0;

            comboBoxNimi.Items.Add(new ComboItem(0, "Kõik"));
            comboBoxNimi.SelectedIndex = 0;

            DataTable tb = new DataTable();
            Database db = new Database();
            db.open();

            if (db.Connected)
            {
                try
                {
                    tb = db.table("SELECT Id, Perekonnanimi + ' ' + Eesnimi Nimi FROM [dbo].[Personal]");

                    for (int i = 0; i < tb.Rows.Count; i++)
                    {
                        comboBoxNimi.Items.Add(new ComboItem(Convert.ToInt32(tb.Rows[i]["Id"]), tb.Rows[i]["Nimi"].ToString()));
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }

                db.close();
            }
        }

        public string Kuu
        {
            get
            {
                ComboItem item = comboBoxKuu.SelectedItem as ComboItem;
                string val = item.Key.ToString();

                if (val == "0") val = "NULL";

                return val;
            }
        }

        public string Aasta
        {
            get
            {
                string val = numAasta.Value.ToString();

                if (val == "0") val = "NULL";

                return val;
            }
        }

        public string IdP
        {
            get
            {
                ComboItem item = comboBoxNimi.SelectedItem as ComboItem;
                string val = item.Key.ToString();

                if (val == "0") val = "NULL";

                return val;
            }
        }
    }
}
