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

            IniFile ini = new IniFile(MainForm.SettingFile);
            dbPath.Text = ini.IniReadValue("config", "database");            
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
            IniFile ini = new IniFile(MainForm.SettingFile);
            ini.IniWriteValue("config", "database", dbPath.Text);
            
            Close();
        }
    }
}
