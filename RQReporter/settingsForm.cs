using Meziantou.Framework.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RQReporter
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = '*';
        }

        private void userBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            string userString = userBox.Text;
            string passString = passwordBox.Text;
            if (String.IsNullOrEmpty(passString))
            {
                Settings1.Default.Save();
            }
            else
            {
                CredentialManager.WriteCredential("PhishPhinder Outlook", userString, passString, CredentialPersistence.LocalMachine);
                Settings1.Default.Save();
            }
            passwordBox.Clear();
            this.Close();
        }

        private void serverBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
