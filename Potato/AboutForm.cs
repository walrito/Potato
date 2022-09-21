using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Potato
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void llOriginalTwitterPost_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://twitter.com/deathbybadger/status/1567425842526945280");
        }

        private void llSourceImage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!File.Exists(Path.GetTempPath() + "potato_rules.jpg")) Properties.Resources.Potato.Save(Path.GetTempPath() + "potato_rules.jpg");
            Process.Start(Path.GetTempPath() + "potato_rules.jpg");
        }
    }
}