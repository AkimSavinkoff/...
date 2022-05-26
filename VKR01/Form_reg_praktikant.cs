using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VKR01
{
    public partial class Form_reg_praktikant : Form
    {
        DBConnection connect_DB = new DBConnection();


        public Form_reg_praktikant()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5C9E2EP2\MYSERVER;Initial Catalog=VKR01;Integrated Security=True");

        private void tbLogPrak_TextChanged(object sender, EventArgs e)
        {

        }

        private void butReg_prak_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbLogPrak.Text.Equals(""))
                    MessageBox.Show("Вы не ввели все необходимые данные!!", "Внимание");
                else
                {

                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("add1_praktikanta", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCommand.Parameters.AddWithValue("@login_prak", tbLogPrak.Text);
                    sqlCommand.Parameters.AddWithValue("@pass_prak", tbPassPrak.Text);
                    sqlCommand.Parameters.AddWithValue("@name_prak", tbNamePrak.Text);
                    sqlCommand.Parameters.AddWithValue("@surename_prak", tbSurnamePrak.Text);
                    sqlCommand.Parameters.AddWithValue("@pat_prak", tbPatPrak.Text);
                    sqlCommand.Parameters.AddWithValue("@phone_prak", maskedTBPhonePrak.Text);          
                    sqlCommand.Parameters.AddWithValue("@facultet_prak", tbNazvSpecial.Text);
                    sqlCommand.Parameters.AddWithValue("@group_prak", tbGroupPrak.Text);                 
                    sqlCommand.Parameters.AddWithValue("@rukovod_prak", cbRukovodPrak.SelectedValue);
                    sqlCommand.Parameters.AddWithValue("@sex_prak", cbSexPrak.SelectedValue);
                    sqlCommand.Parameters.AddWithValue("@begin_prak", maskedTBbeginPrak.Text);
                    sqlCommand.Parameters.AddWithValue("@end_prak", maskedTBendPrak.Text);



                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Практикант зарегестрирован", "Уведомление");


                }


              
            }
            catch 
            {
                MessageBox.Show("Какие либо данные введены не корректно." /*+ ex, "Ошибка"*/);

            }
        }

        private void Form_reg_praktikant_Load(object sender, EventArgs e)
        {
            cbRukovodPrak.DataSource = connect_DB.TableFill("SELECT f_s, id_sotrud FROM sotrudniki", con).Tables[0];
            cbRukovodPrak.DisplayMember = "f_s";
            cbRukovodPrak.ValueMember = "id_sotrud";


            cbSexPrak.DataSource = connect_DB.TableFill("SELECT sex, ID FROM sex", con).Tables[0];
            cbSexPrak.DisplayMember = "sex";
            cbSexPrak.ValueMember = "ID";


        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_list_prak flp = new Form_list_prak();
            flp.Show();
        }
    }
}
