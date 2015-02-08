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
    public partial class InputBox : Form
    {
        public string Value
        {
            get { return textBox1.Text; }
        }

        public InputBox(string caption="Input box", string text="Enter value", string value="")
        {            
            InitializeComponent();
            Text = caption;
            label1.Text = text;
            textBox1.Text = value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
