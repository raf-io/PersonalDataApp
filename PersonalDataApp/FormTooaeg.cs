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
    public partial class FormTooaeg : Form
    {
        private int id;

        public FormTooaeg(string title, string label, string button, int id)
        {
            InitializeComponent();

            this.Text = title;
            label1.Text = label;
            buttonAddEdit.Text = button;
            this.id = id;

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

                if (id > 0)
                {
                    db = new Database();
                    db.open();

                    try
                    {
                        tb = db.table("SELECT * FROM [dbo].[Tooaeg] WHERE Id = '" + id.ToString() + "'");
                        dateKuupaev.Value = DateTime.Parse(tb.Rows[0]["Kuupaev"].ToString());
                        numTootunnid.Value = Convert.ToDecimal(tb.Rows[0]["Tootunnid"]);

                        for (int i = 0; i < comboBoxNimi.Items.Count; i++)
                        {
                            ComboItem item = comboBoxNimi.Items[i] as ComboItem;

                            if (item.Key == Convert.ToInt32(tb.Rows[0]["idPersonal"]))
                            {
                                comboBoxNimi.SelectedIndex = i;
                            }
                        }
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

        public string IdP
        {
            get
            {
                ComboItem item = comboBoxNimi.SelectedItem as ComboItem;

                return item.Key.ToString();
            }
        }

        public string Kuupaev
        {
            get
            {
                return dateKuupaev.Value.ToString("yyyy-MM-dd");
            }
        }

        public string Tootunnid
        {
            get
            {
                return numTootunnid.Value.ToString().Replace(",", ".");
            }
        }
    }
}
