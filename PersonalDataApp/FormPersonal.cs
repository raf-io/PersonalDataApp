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
        public FormPersonal(string title, string label, string button)
        {
            InitializeComponent();

            this.Text = title;
            label1.Text = label;
            buttonAddEdit.Text = button;

            comboBoxSugu.Items.Add(new ComboItem(1, "Mees"));
            comboBoxSugu.Items.Add(new ComboItem(2, "Naine"));
        }

        public string Id
        {
            get
            {
                return textId.Text;
            }
            set
            {
                textId.Text = value;
            }
        }

        public string Perekonnanimi
        {
            get
            {
                return textPerekonnanimi.Text;
            }
            set
            {
                textPerekonnanimi.Text = value;
            }
        }

        public string Eesnimi
        {
            get
            {
                return textEesnimi.Text;
            }
            set
            {
                textEesnimi.Text = value;
            }
        }

        public string Sugu
        {
            get
            {
                ComboItem item = comboBoxSugu.SelectedItem as ComboItem;

                return item.Key.ToString();
            }
            set
            {
                comboBoxSugu.SelectedItem = value;
            }
        }

        public string Sunnipaev
        {
            get
            {
                return dateSunnipaev.Value.ToString("yyyy-MM-dd");
            }
            /*set
            {
                dateSunnipaev.Value = value;
            }*/
        }

        public string Palk
        {
            get
            {
                return numPalk.Value.ToString();
            }
            /*set
            {
                numPalk.Value = value;
            }*/
        }
    }
}
