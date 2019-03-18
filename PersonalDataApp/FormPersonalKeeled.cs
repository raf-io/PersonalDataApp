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
    public partial class FormPersonalKeeled : Form
    {
        private int id;

        public FormPersonalKeeled(string title, string label, string button, int id)
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
                db = new Database();
                db.open();

                try
                {
                    tb = db.table("SELECT Id, Keel FROM [dbo].[Keeled]");

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
                        comboTase.Items.Add(tb.Rows[i]["Tase"].ToString());
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
                        tb = db.table("SELECT * FROM [dbo].[PersonalKeeled] WHERE Id = '" + id.ToString() + "'");

                        for (int i = 0; i < comboBoxNimi.Items.Count; i++)
                        {
                            ComboItem item = comboBoxNimi.Items[i] as ComboItem;

                            if (item.Key == Convert.ToInt32(tb.Rows[0]["idPersonal"]))
                            {
                                comboBoxNimi.SelectedIndex = i;
                            }
                        }

                        for (int i = 0; i < comboBoxKeel.Items.Count; i++)
                        {
                            ComboItem item = comboBoxKeel.Items[i] as ComboItem;

                            if (item.Key == Convert.ToInt32(tb.Rows[0]["idKeeled"]))
                            {
                                comboBoxKeel.SelectedIndex = i;
                            }
                        }

                        for (int i = 0; i < comboTase.Items.Count; i++)
                        {
                            if (comboTase.Items[i].ToString() == tb.Rows[0]["Tase"].ToString())
                            {
                                comboTase.SelectedIndex = i;
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

        public string IdK
        {
            get
            {
                ComboItem item = comboBoxKeel.SelectedItem as ComboItem;

                return item.Key.ToString();
            }
        }

        public string Tase
        {
            get
            {
                return comboTase.SelectedItem.ToString();
            }
        }
    }
}
