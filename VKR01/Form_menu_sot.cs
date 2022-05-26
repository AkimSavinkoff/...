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
    public partial class Form_menu_sot : Form
    {
        public Form_menu_sot()
        {
            InitializeComponent();
        }

        private void butAddPrak_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_list_prak flp = new Form_list_prak();
            flp.Show();
        }

        private void Form_menu_sot_Load(object sender, EventArgs e)
        {
            butAddSot.Enabled = true;
            butDelSot.Enabled = true;

            switch (Program.id_dolj)
            {
                case 1:
                    butAddSot.Enabled = true;
                    butDelSot.Enabled = true;
                   
                    break;
                case 4:
                    butAddSot.Enabled = false;
                    butDelSot.Enabled = false;
                    
                    break;
               
                   //break;
            }
        }
    }
}
