﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonalDataApp
{
    public partial class Form1 : Form
    {
        object test;

        public Form1()
        {
            InitializeComponent();

            DataTable tb = new DataTable();
            Database db = new Database();
            db.open();

            if (db.Connected)
            {
                try
                {
                    tb = db.table("SELECT * FROM [dbo].[Personal]");
                    dataGridView1.DataSource = tb;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[3].Width = 40;
                dataGridView1.Columns[4].Width = 70;
                dataGridView1.Columns[5].Width = 50;
                db.close();

                db = new Database();
                db.open();

                try
                {
                    tb = db.table("SELECT * FROM [dbo].[Keeled]");
                    dataGridView2.DataSource = tb;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }

                dataGridView2.Columns[0].Width = 50;
                db.close();

                db = new Database();
                db.open();

                try
                {
                    tb = db.table("SELECT PK.Id, P.Perekonnanimi + ' ' + P.Eesnimi Nimi, K.Keel, PK.Tase FROM [dbo].[PersonalKeeled] PK"
                        + " LEFT JOIN [dbo].[Personal] P ON PK.idPersonal = P.Id"
                        + " LEFT JOIN [dbo].[Keeled] K ON PK.idKeeled = K.Id");
                    dataGridView3.DataSource = tb;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }

                dataGridView3.Columns[0].Width = 50;
                dataGridView3.Columns[1].Width = 150;
                db.close();

                db = new Database();
                db.open();

                try
                {
                    tb = db.table("SELECT * FROM [dbo].[KeeleTasud]");
                    dataGridView4.DataSource = tb;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            
                dataGridView4.Columns[0].Width = 50;
                db.close();

                db = new Database();
                db.open();

                try
                {
                    tb = db.table("SELECT T.Id, P.Perekonnanimi + ' ' + P.Eesnimi Nimi, T.Kuupaev, T.Tootunnid FROM [dbo].[Tooaeg] T"
                        + " LEFT JOIN [dbo].[Personal] P ON T.idPersonal = P.Id");
                    dataGridView5.DataSource = tb;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            
                dataGridView5.Columns[0].Width = 50;
                dataGridView5.Columns[1].Width = 150;
                dataGridView5.Columns[2].Width = 70;
                db.close();

                db = new Database();
                db.open();

                try
                {
                    tb = db.table("EXEC proc_palk");
                    dataGridView6.DataSource = tb;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            
                dataGridView6.Columns[0].Width = 50;
                dataGridView6.Columns[1].Width = 145;
                dataGridView6.Columns[2].Width = 30;
                dataGridView6.Columns[3].Width = 40;
                dataGridView6.Columns[4].Width = 50;
                dataGridView6.Columns[5].Width = 60;
                dataGridView6.Columns[6].Width = 80;
                dataGridView6.Columns[7].Width = 70;
                dataGridView6.Columns[8].Width = 70;
                db.close();

                db = new Database();
                db.open();

                try
                {
                    tb = db.table("EXEC proc_personal");
                    dataGridView7.DataSource = tb;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            
                dataGridView7.Columns[0].Width = 50;
                dataGridView7.Columns[1].Width = 150;
                dataGridView7.Columns[2].Width = 40;
                dataGridView7.Columns[3].Width = 70;
                dataGridView7.Columns[4].Width = 40;
                dataGridView7.Columns[6].Width = 40;
                dataGridView7.Columns[7].Width = 70;
                db.close();
            }
        }

        private void buttonRefreshPersonal_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            Database db = new Database();
            db.open();

            if (db.Connected)
            {
                try
                {
                    tb = db.table("SELECT * FROM [dbo].[Personal]");
                    dataGridView1.DataSource = tb;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            
                db.close();
            }
        }

        private void buttonRefreshKeeled_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            Database db = new Database();
            db.open();

            if (db.Connected)
            {
                try
                {
                    tb = db.table("SELECT * FROM [dbo].[Keeled]");
                    dataGridView2.DataSource = tb;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            
                db.close();
            }
        }

        private void buttonRefreshPK_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            Database db = new Database();
            db.open();

            if (db.Connected)
            {
                try
                {
                    tb = db.table("SELECT PK.Id, P.Perekonnanimi + ' ' + P.Eesnimi Nimi, K.Keel, PK.Tase FROM [dbo].[PersonalKeeled] PK"
                        + " LEFT JOIN [dbo].[Personal] P ON PK.idPersonal = P.Id"
                        + " LEFT JOIN [dbo].[Keeled] K ON PK.idKeeled = K.Id");
                    dataGridView3.DataSource = tb;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            
                db.close();
            }
        }

        private void buttonRefreshKT_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            Database db = new Database();
            db.open();

            if (db.Connected)
            {
                try
                {
                    tb = db.table("SELECT * FROM [dbo].[KeeleTasud]");
                    dataGridView4.DataSource = tb;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            
                db.close();
            }
        }

        private void buttonRefreshTooaeg_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            Database db = new Database();
            db.open();

            if (db.Connected)
            {
                try
                {
                    tb = db.table("SELECT T.Id, P.Perekonnanimi + ' ' + P.Eesnimi Nimi, T.Kuupaev, T.Tootunnid FROM [dbo].[Tooaeg] T"
                        + " LEFT JOIN [dbo].[Personal] P ON T.idPersonal = P.Id");
                    dataGridView5.DataSource = tb;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            
                db.close();
            }
        }

        private void buttonRefreshPalgad_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            Database db = new Database();
            db.open();

            if (db.Connected)
            {
                try
                {
                    tb = db.table("EXEC proc_palk");
                    dataGridView6.DataSource = tb;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            
                db.close();
            }
        }

        private void buttonRefreshPKT_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            Database db = new Database();
            db.open();

            if (db.Connected)
            {
                try
                {
                    tb = db.table("EXEC proc_personal");
                    dataGridView7.DataSource = tb;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            
                db.close();
            }
        }

        private void buttonRemovePersonal_Click(object sender, EventArgs e)
        {
            string id = "";

            try
            {
                id = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            }
            catch (NullReferenceException) { }
            

            DialogResult result = MessageBox.Show("Are you sure?", "Remove confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Database db = new Database();
                db.open();

                if (db.Connected)
                {
                    try
                    {
                        db.cmd_exec("DELETE FROM [dbo].[Personal] WHERE Id='" + id + "'");
                    }
                    catch (Exception)
                    {
                        db.close();
                        MessageBox.Show("Entry remove failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                
                    db.close();

                    buttonRefreshPersonal_Click(sender, e);
                }
            }
        }

        private void buttonRemoveKeeled_Click(object sender, EventArgs e)
        {
            string id = "";

            try
            {
                id = dataGridView2[0, dataGridView2.CurrentRow.Index].Value.ToString();
            }
            catch (NullReferenceException) { }

            DialogResult result = MessageBox.Show("Are you sure?", "Remove confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Database db = new Database();
                db.open();

                if (db.Connected)
                {
                    try
                    {
                        db.cmd_exec("DELETE FROM [dbo].[Keeled] WHERE Id='" + id + "'");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Entry remove failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                
                    db.close();

                    buttonRefreshKeeled_Click(sender, e);
                }
            }
        }

        private void buttonRemovePK_Click(object sender, EventArgs e)
        {
            string id = "";

            try
            {
                id = dataGridView3[0, dataGridView3.CurrentRow.Index].Value.ToString();
            }
            catch (NullReferenceException) { }

            DialogResult result = MessageBox.Show("Are you sure?", "Remove confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Database db = new Database();
                db.open();

                if (db.Connected)
                {
                    try
                    {
                        db.cmd_exec("DELETE FROM [dbo].[PersonalKeeled] WHERE Id='" + id + "'");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Entry remove failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                
                    db.close();

                    buttonRefreshPK_Click(sender, e);
                }
            }
        }

        private void buttonRemoveKT_Click(object sender, EventArgs e)
        {
            string id = "";

            try
            {
                id = dataGridView4[0, dataGridView4.CurrentRow.Index].Value.ToString();
            }
            catch (NullReferenceException) { }

            DialogResult result = MessageBox.Show("Are you sure?", "Remove confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Database db = new Database();
                db.open();

                if (db.Connected)
                {
                    try
                    {
                        db.cmd_exec("DELETE FROM [dbo].[KeeleTasud] WHERE Id='" + id + "'");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Entry remove failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                
                    db.close();

                    buttonRefreshKT_Click(sender, e);
                }
            }
        }

        private void buttonRemoveTooaeg_Click(object sender, EventArgs e)
        {
            string id = "";

            try
            {
                id = dataGridView5[0, dataGridView5.CurrentRow.Index].Value.ToString();
            }
            catch (NullReferenceException) { }

            DialogResult result = MessageBox.Show("Are you sure?", "Remove confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Database db = new Database();
                db.open();

                if (db.Connected)
                {
                    try
                    {
                        db.cmd_exec("DELETE FROM [dbo].[Tooaeg] WHERE Id='" + id + "'");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Entry remove failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                
                    db.close();

                    buttonRefreshTooaeg_Click(sender, e);
                }
            }
        }

        private void buttonAddPersonal_Click(object sender, EventArgs e)
        {
            FormPersonal dlg = new FormPersonal("New entry", "Add to personal", "Add", 0);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Database db = new Database();
                db.open();

                if (db.Connected)
                {
                    try
                    {
                        db.cmd_exec("INSERT INTO [dbo].[Personal] (Perekonnanimi, Eesnimi, Sugu, Sunnipaev, Palk)"
                            + " VALUES('" + dlg.Perekonnanimi +"', '" + dlg.Eesnimi + "', '" + dlg.Sugu + "', '" + dlg.Sunnipaev + "', '" + dlg.Palk + "')");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Entry add fail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                    db.close();
                    buttonRefreshPersonal_Click(sender, e);
                }
            }
        }

        private void buttonEditPersonal_Click(object sender, EventArgs e)
        {
            int id = 0;

            try
            {
                id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            }
            catch (NullReferenceException) { }

            FormPersonal dlg = new FormPersonal("Edit entry", "Edit personal", "Save", id);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Database db = new Database();
                db.open();

                if (db.Connected)
                {
                    try
                    {
                        db.cmd_exec("UPDATE [dbo].[Personal] SET"
                            + " Perekonnanimi = '" + dlg.Perekonnanimi + "', Eesnimi = '" + dlg.Eesnimi + "', Sugu = '" + dlg.Sugu + "', Sunnipaev = '" + dlg.Sunnipaev + "', Palk = '" + dlg.Palk + "'"
                            + " WHERE Id = '" + dlg.Id + "'");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Entry edit fail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                    db.close();
                    buttonRefreshPersonal_Click(sender, e);
                }
            }
        }

        private void buttonAddKeeled_Click(object sender, EventArgs e)
        {
            FormKeeled dlg = new FormKeeled("New entry", "Add to keeled", "Add", 0);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Database db = new Database();
                db.open();

                if (db.Connected)
                {
                    try
                    {
                        db.cmd_exec("INSERT INTO [dbo].[Keeled] (Keel) VALUES('" + dlg.Keel + "')");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Entry add fail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                    db.close();
                    buttonRefreshKeeled_Click(sender, e);
                }
            }
        }

        private void buttonEditKeeled_Click(object sender, EventArgs e)
        {
            int id = 0;

            try
            {
                id = Convert.ToInt32(dataGridView2[0, dataGridView2.CurrentRow.Index].Value.ToString());
            }
            catch (NullReferenceException) { }

            FormKeeled dlg = new FormKeeled("Edit entry", "Edit keeled", "Save", id);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Database db = new Database();
                db.open();

                if (db.Connected)
                {
                    try
                    {
                        db.cmd_exec("UPDATE [dbo].[Keeled] SET Keel = '" + dlg.Keel + "' WHERE Id = '" + dlg.Id + "'");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Entry edit fail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                    db.close();
                    buttonRefreshKeeled_Click(sender, e);
                }
            }
        }

        private void buttonAddPK_Click(object sender, EventArgs e)
        {
            FormPersonalKeeled dlg = new FormPersonalKeeled("New entry", "Add to PersonalKeeled", "Add", 0);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Database db = new Database();
                db.open();

                MessageBox.Show("INSERT INTO [dbo].[PersonalKeeled] (idPersonal, idKeeled, Tase)"
                        + " VALUES('" + dlg.IdP + "', '" + dlg.IdK + "', '" + dlg.Tase + "')");

                if (db.Connected)
                {
                    try
                    {
                        
                        db.cmd_exec("INSERT INTO [dbo].[PersonalKeeled] (idPersonal, idKeeled, Tase)"
                        + " VALUES('" + dlg.IdP + "', '" + dlg.IdK + "', '" + dlg.Tase + "')");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Entry add fail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                    db.close();
                    buttonRefreshPK_Click(sender, e);
                }


            }
        }

        private void buttonEditPK_Click(object sender, EventArgs e)
        {
            int id = 0;

            try
            {
                id = Convert.ToInt32(dataGridView3[0, dataGridView3.CurrentRow.Index].Value.ToString());
            }
            catch (NullReferenceException) { }

            FormPersonalKeeled dlg = new FormPersonalKeeled("Edit entry", "Edit PersonalKeeled", "Save", id);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Database db = new Database();
                db.open();

                if (db.Connected)
                {
                    try
                    {
                        db.cmd_exec("UPDATE [dbo].[PersonalKeeled]"
                        + " SET idPersonal = '" + dlg.IdP + "', idKeeled = '" + dlg.IdK + "', Tase = '" + dlg.Tase + "'"
                        + " WHERE Id = '" + dlg.Id + "'");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Entry edit fail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                    db.close();
                    buttonRefreshPK_Click(sender, e);
                }
            }
        }

        private void buttonAddKT_Click(object sender, EventArgs e)
        {
            FormKeeleTasud dlg = new FormKeeleTasud("New entry", "Add to KeeleTasud", "Add", 0);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Database db = new Database();
                db.open();

                if (db.Connected)
                {
                    try
                    {
                        db.cmd_exec("INSERT INTO [dbo].[KeeleTasud] (Tase, Summa) VALUES('" + dlg.Tase + "', '" + dlg.Summa + "')");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Entry add fail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                    buttonRefreshKT_Click(sender, e);
                }
            }
        }

        private void buttonEditKT_Click(object sender, EventArgs e)
        {
            int id = 0;

            try
            {
                id = Convert.ToInt32(dataGridView4[0, dataGridView4.CurrentRow.Index].Value.ToString());
            }
            catch (NullReferenceException) { }

            FormKeeleTasud dlg = new FormKeeleTasud("Edit entry", "Edit KeeleTasud", "Save", id);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Database db = new Database();
                db.open();

                if (db.Connected)
                {
                    try
                    {
                        db.cmd_exec("UPDATE [dbo].[KeeleTasud] SET Tase = '" + dlg.Tase + "', Summa = '" + dlg.Summa + "' WHERE Id = '" + dlg.Id + "'");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Entry edit fail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                    buttonRefreshKT_Click(sender, e);
                }
            }
        }

        private void buttonAddTooaeg_Click(object sender, EventArgs e)
        {
            FormTooaeg dlg = new FormTooaeg("New entry", "Add to tooaeg", "Add", 0);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Database db = new Database();
                db.open();

                if (db.Connected)
                {
                    try
                    {
                        db.cmd_exec("INSERT INTO [dbo].[Tooaeg] (idPersonal, Kuupaev, Tootunnid)"
                        + " VALUES('" + dlg.IdP + "', '" + dlg.Kuupaev + "', '" + dlg.Tootunnid + "')");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Entry add fail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                    buttonRefreshTooaeg_Click(sender, e);
                }
            }
        }

        private void buttonEditTooaeg_Click(object sender, EventArgs e)
        {
            int id = 0;

            try
            {
                id = Convert.ToInt32(dataGridView5[0, dataGridView5.CurrentRow.Index].Value.ToString());
            }
            catch (NullReferenceException) { }

            FormTooaeg dlg = new FormTooaeg("Edit entry", "Edit Tooaeg", "Save", id);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Database db = new Database();
                db.open();

                if (db.Connected)
                {
                    try
                    {
                        db.cmd_exec("UPDATE [dbo].[Tooaeg]"
                        + " SET idPersonal = '" + dlg.IdP + "', Kuupaev = '" + dlg.Kuupaev + "', Tootunnid = '" + dlg.Tootunnid + "'"
                        + " WHERE Id = '" + dlg.Id + "'");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Entry edit fail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                    buttonRefreshTooaeg_Click(sender, e);
                }
            }
        }
    }
}
