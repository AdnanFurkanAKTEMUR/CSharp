using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b191210307_odev3
{
    public partial class Alert : Form
    {
        public Alert()
        {
            InitializeComponent();
        }

        private void alertbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void alertLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
