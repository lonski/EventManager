using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventManager
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            dbPath.Text = Properties.Settings.Default.DatabasePath;
        }
        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult res = dlgBrowseDb.ShowDialog();
            if (res == DialogResult.OK)
            {
                dbPath.Text = dlgBrowseDb.FileName;
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DatabasePath = dbPath.Text;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
