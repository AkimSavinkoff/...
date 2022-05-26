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
    public partial class Form_auth_sot : Form
    {
        public Form_auth_sot()
        {
            InitializeComponent();
        }
        int SotId;
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5C9E2EP2\MYSERVER;Initial Catalog=VKR01;Integrated Security=True");



        private void butBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Hello fh = new Form_Hello();
            fh.Show();
        }

        private void butLogSot_Click(object sender, EventArgs e)
        {
            con.Open();
            string loginCheck = tbLogSot.Text;//Переменная логина
            string password = tbPassSot.Text;//Переменная паролья
            string checkCmd = $"Select login_sotrud, password_sotrud from sotrudniki where login_sotrud ='{loginCheck}' and password_sotrud ='{password}'";//Сравниваем с базой логин и пароль
            string AutorizId = $"Select id_sotrud from sotrudniki where login_sotrud ='{loginCheck}'";//Берем Id пользователя по логину 

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
                    SotId = (int)sqlAutoID.ExecuteScalar();//Присвеваем в переменную id пользователя
                    try
                    {
                        string SotrudDolj = $"Select dolj_s from sotrudniki where id_sotrud ='{SotId}'";//Создаем запрос на получение id должности у пользователя
                        SqlCommand sqlDoljId = new SqlCommand(SotrudDolj, con);//Создаем команду с подключением и запросом на получение должности
                        sqlDoljId.Prepare();//Создаем экземпляр запроса к SQL Server 
                        sqlDoljId.ExecuteNonQuery();//Получаем результат запроса
                        Program.id_dolj = (int)sqlDoljId.ExecuteScalar();//Сохраняем результат запроса в переменной, ключ должности
                        this.Hide();
                        Form_menu_sot fms = new Form_menu_sot();
                        fms.Show();
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
