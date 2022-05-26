using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace VKR01
{
    class DBConnection
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5C9E2EP2\MYSERVER;Initial Catalog=VKR01;Integrated Security=True");

        public string qw_View_Sotrud_Nazv = @"SELECT praktikanti.ID AS Ключ, praktikanti.name_prak AS [имя практиканта], dbo.praktikanti.surename_prak AS [фамилия практиканта], dbo.praktikanti.pat_prak AS [Отчество практиканта] , dbo.praktikanti.begin_prak AS [начало практики]  , dbo.praktikanti.end_prak AS [конец практики]   , dbo.praktikanti.phone_prak AS [телефон практиканта], dbo.praktikanti.facultet_prak AS [специальность практиканта], dbo.praktikanti.group_prak AS [группа практиканта], dbo.sotrudniki.f_s AS [фамилия руководителя практики] FROM dbo.praktikanti INNER JOIN dbo.sotrudniki ON dbo.praktikanti.rukovod_prak = dbo.sotrudniki.id_sotrud ";


        public DataSet TableFill(string query, SqlConnection sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, sql);
            DataSet dataSet = new DataSet();
            dataSet.Clear();
            adapter.Fill(dataSet);
            return dataSet;
        }




     
    }
}
