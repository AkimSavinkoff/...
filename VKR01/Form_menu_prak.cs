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
    public partial class Form_menu_prak : Form
    {
        public Form_menu_prak()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5C9E2EP2\MYSERVER;Initial Catalog=VKR01;Integrated Security=True");


        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Form_menu_prak_Load(object sender, EventArgs e)
        {
            con.Open();
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();

            /*SqlCommand com = new SqlCommand($"select name_prak from dbo.praktikanti where ID =@ID", con);
            com.Parameters.AddWithValue("@ID", label1.Text);
       
            string name = com.ExecuteScalar().ToString();
            if (name != null)
            {
                label1.Text = name;
            }
            else
            {
                MessageBox.Show("pc");
            }

         *//*   string imya = $"Select name_prak from praktikanti";
            SqlCommand sql_Cena = new SqlCommand(imya, con);//Создаем команду с подключением и запросом на получение цены
            sql_Cena.Prepare();//Создаем экземпляр запроса к SQL Server 
            sql_Cena.ExecuteNonQuery();//Получаем результат запроса
            label1.Text = sql_Cena.ToString();//Выводим цену*//*
            con.Close();//Закрываем подключение*/

        }

        











        /*      private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
              {

              }*/

        /*       private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
               {

               }*/
    }
}
