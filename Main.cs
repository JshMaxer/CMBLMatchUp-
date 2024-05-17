using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchUp
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
