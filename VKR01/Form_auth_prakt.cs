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
    public partial class Form_auth_prakt : Form
    {
        public Form_auth_prakt()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5C9E2EP2\MYSERVER;Initial Catalog=VKR01;Integrated Security=True");
        int prakID;

        private void butBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Hello fh = new Form_Hello();
            fh.Show();
        }

        private void butLogPrak_Click(object sender, EventArgs e)
        {
            con.Open();
            string loginCheck = tbLogPrak.Text;//Переменная логина
            string password = tbPassPrak.Text;//Переменная паролья
            string checkCmd = $"Select login_prak, pass_prak from praktikanti where login_prak ='{loginCheck}' and pass_prak ='{password}'";//Сравниваем с базой логин и пароль
            string AutorizId = $"Select ID from praktikanti where login_prak ='{loginCheck}'";//Берем Id пользователя по логину 


            SqlCommand sqlCommand = new SqlCommand(checkCmd, con);//Выполняем запрос на сравнение логина и пароля с базой (првоерка пользователя в базе)
            SqlCommand sqlAutoID = new SqlCommand(AutorizId, con);//Выполняем процесс получения Id пользовател
            try
            {
                sqlCommand.Prepare();//Создаем экземпляр запроса к SQL Server 
                sqlCommand.ExecuteNonQuery();//Получаем результат запроса
                if (loginCheck == (string)sqlCommand.ExecuteScalar())//Сравниваем первую строку результата с переменной
                {
                    sqlAutoID.Prepare();//Создаем экземпляр запроса к SQL Server, получения Id пользователя
                    sqlAutoID.ExecuteNonQuery();//Получаем результат запроса а именно id пользователя
                    prakID = (int)sqlAutoID.ExecuteScalar();//Присвеваем в переменную id пользователя
                    try
                    {
                        /*string SotrudDolj = $"Select dolj_s from sotrudniki where id_sotrud ='{prakID}'";//Создаем запрос на получение id должности у пользователя
                        SqlCommand sqlDoljId = new SqlCommand(SotrudDolj, con);//Создаем команду с подключением и запросом на получение должности
                        sqlDoljId.Prepare();//Создаем экземпляр запроса к SQL Server 
                        sqlDoljId.ExecuteNonQuery();//Получаем результат запроса
                        Program.id_dolj = (int)sqlDoljId.ExecuteScalar();//Сохраняем результат запроса в переменной, ключ должности*/
                       
                        
                        this.Hide();
                        Form_menu_prak fmp = new Form_menu_prak();
                        fmp.Show();
                    }
                    catch
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Логин или пароль ведены не верно", "Ошибка");
                }
            }

            catch
            {

            }
            con.Close();
        }
    }
}
