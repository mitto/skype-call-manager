using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkypeCallManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMainLoad(object sender, EventArgs e)
        {
            RegisterEventHandler();
        }

        private void RegisterEventHandler()
        {
            toolStripMenuItemFileExit.Click += (sender, e) => Application.Exit();
        }
    }
}
