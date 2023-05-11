using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotDumperGUI
{
    partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                return "DotDumperGUI";
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return "1.0-stable";
            }
        }

        public string AssemblyDescription
        {
            get
            {
                return "A graphical user-interface for DotDumper JSON trace logs, allowing the user to easily filter and search through the logs.";
            }
        }

        public string AssemblyProduct
        {
            get
            {
                return "DotDumperGUI";
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                return "Trellix (2022), written by Max 'Libra' Kersten";
            }
        }

        public string AssemblyCompany
        {
            get
            {
                return "Trellix";
            }
        }
        #endregion
    }
}
