using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;

namespace WCOutlookUtilities.About
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            //string buildDate = new FileInfo(Assembly.GetExecutingAssembly().Location).LastWriteTime.ToString();
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            //string version = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            string productName = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

            //labelBuildDate.Text = $"Build Date: {buildDate}";
            labelBuildDate.Visible = false;
            labelVersion.Text = $"Version: {version}";
            labelName.Text = productName;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
