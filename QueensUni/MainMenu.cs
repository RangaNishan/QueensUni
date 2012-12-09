using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QueensUni
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void newRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentDetails std = new StudentDetails();
            std.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
