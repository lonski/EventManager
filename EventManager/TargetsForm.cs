using EventManager.DataGateways;
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
    public partial class TargetsForm : Form
    {
        private TargetGateway _targetGateway;
        
        public List<string> Targets
        {
            get
            {
                List<string> targets = new List<string>();
                targets.AddRange(listTargets.Items.OfType<string>());
                return targets;
            }
        }

        public TargetsForm(TargetGateway targetGateway)
        {
            InitializeComponent();
            _targetGateway = targetGateway;

            listTargets.Items.AddRange(targetGateway.fetch_all().ToArray());        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputBox input = new InputBox("Add target", "Enter target name:");
            input.ShowDialog();
            if ( input.DialogResult == DialogResult.OK)
            {
                listTargets.Items.Add(input.Value);
                _targetGateway.write(input.Value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var selected = listTargets.SelectedItem;
            if ( selected != null)
            {
                InputBox input = new InputBox("Add target", "Enter target name:", selected.ToString());
                input.ShowDialog();
                if (input.DialogResult == DialogResult.OK)
                {
                    listTargets.Items.Remove(selected);
                    _targetGateway.erase(selected.ToString());

                    listTargets.Items.Add(input.Value);
                    _targetGateway.write(input.Value);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selected = listTargets.SelectedItem;
            if ( selected != null)
            {
                listTargets.Items.Remove(selected);
                _targetGateway.erase(selected.ToString());
            }
        }
    }
}
