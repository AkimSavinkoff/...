using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKR01
{
    public partial class Form_Hello : Form
    {
        public Form_Hello()
        {
            InitializeComponent();
        }

        private void butStud_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_auth_sot fas = new Form_auth_sot();
            fas.Show();
        }

        private void butSot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_auth_prakt fap = new Form_auth_prakt();
            fap.Show();
        }
    }
}
