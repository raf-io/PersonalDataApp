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
    public partial class FormPersonal : Form
    {
        private int id;

        public FormPersonal(string title, string label, string button, int id)
        {
            InitializeComponent();

            this.Text = title;
            label1.Text = label;
            buttonAddEdit.Text = button;
            this.id = id;

            comboBoxSugu.Items.Add(new ComboItem(1, "Mees"));
            comboBoxSugu.Items.Add(new ComboItem(2, "Naine"));

            if(id > 0)
            {
                DataTable tb = new DataTable();
                Database db = new Database();
                db.open();

                if (db.Connected)
                {
                    try
                    {
                        tb = db.table("SELECT * FROM [dbo].[Personal] WHERE Id = '" + id.ToString() + "'");
                        textPerekonnanimi.Text = tb.Rows[0]["Perekonnanimi"].ToString();
                        textEesnimi.Text = tb.Rows[0]["Eesnimi"].ToString();
                        dateSunnipaev.Value = DateTime.Parse(tb.Rows[0]["Sunnipaev"].ToString());
                        numPalk.Value = Convert.ToDecimal(tb.Rows[0]["Palk"]);

                        for (int i = 0; i < comboBoxSugu.Items.Count; i++)
                        {
                            ComboItem item = comboBoxSugu.Items[i] as ComboItem;

                            if (item.Key == Convert.ToInt32(tb.Rows[0]["Sugu"]))
                            {
                                comboBoxSugu.SelectedIndex = i;
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

        public string Perekonnanimi
        {
            get
            {
                return textPerekonnanimi.Text.Replace("'", "''");
            }
        }

        public string Eesnimi
        {
            get
            {
                return textEesnimi.Text.Replace("'", "''");
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

        public string Sunnipaev
        {
            get
            {
                return dateSunnipaev.Value.ToString("yyyy-MM-dd");
            }
        }

        public string Palk
        {
            get
            {
                return numPalk.Value.ToString().Replace(",", ".");
            }
        }
    }
}
