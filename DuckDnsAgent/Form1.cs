using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuckDnsAgent
{
    public partial class Form1 : Form
    {
        ConfigurationFile conf = new(true);
        Agent agent = new Agent();

        public Form1()
        {
            InitializeComponent();
            timerUpdater.Start();
        }


        #region "GUI Method"
        private void showForm()
        {
            this.Opacity = 100;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
            this.Focus();
        }

        private void hideForm()
        {
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            notifyIcon1.Visible = true;
        }

        private void displayConfigurationValues()
        {
            TB_userToken.Text = conf.userToken;
            NUM_updateInterval.Value = conf.updateInterval;
            LB_Domains.Items.Clear();
            foreach (string domain in conf.domainsToUpdate)
            {
                LB_Domains.Items.Add(domain);
            }
        }

        #endregion

        #region "GUI Events"
        private void Form1_Load(object sender, EventArgs e)
        {
            hideForm();
            displayConfigurationValues();
        }
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            showForm();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                hideForm();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var messageResponse = MessageBox.Show("Are you sure you want to close DuckDnsAgent ? Your domain names will not be updated yet.", "Confirm to close DuckDns Agent", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (messageResponse == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }
        #endregion

        #region "Others"



        #endregion

        private void BTN_configSave_Click(object sender, EventArgs e)
        {
            conf.userToken = TB_userToken.Text;
            conf.updateInterval = Convert.ToInt32(NUM_updateInterval.Value);
            conf.domainsToUpdate.Clear();
            foreach (string item in LB_Domains.Items)
            {
                conf.domainsToUpdate.Add(item);
            }

            if (!conf.Save()) {
                displayConfigurationValues();
                MessageBox.Show("Enable to save configuration file !", "Saving change error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            elapsed = 0;
        }

        private void toolStripMenuItem_Remove_Click(object sender, EventArgs e)
        {
            int selectedIndex = LB_Domains.SelectedIndex;
            if (selectedIndex != -1)
            {
                LB_Domains.Items.RemoveAt(selectedIndex);
            }
        }

        private void BTN_addDomain_Click(object sender, EventArgs e)
        {
            LB_Domains.Items.Add(TB_newDomain.Text);
        }

        private void BTN_updateNow_Click(object sender, EventArgs e)
        {
            Update(true);
        }

        int elapsed = 0;
        private void timerUpdater_Tick(object sender, EventArgs e)
        {
            elapsed = elapsed + 1;
            int timeReaming = conf.updateInterval - elapsed;
            LBL_Status.Text = "Next update in " + (conf.updateInterval - elapsed) + " seconds";
            
            if (elapsed == conf.updateInterval)
            {
                LBL_Status.Text = "Next update now";
                Update();
                elapsed = 0;
            }
        }

        private void Update(bool verbose = false)
        {
            var domainsUpdated = new List<string>();
            var domainsNotUpdated = new List<string>();
            foreach (string domain in conf.domainsToUpdate)
            {
                if (agent.UpdateDomain(conf.userToken, domain))
                {
                    domainsUpdated.Add(domain);
                }
                else
                {
                    domainsNotUpdated.Add(domain);
                }
            }

            if (verbose)
            {
                MessageBox.Show(domainsUpdated.Count + " domains of " + conf.domainsToUpdate + " updated successfully");
            }
        }
    }
}
