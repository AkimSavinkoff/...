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
    public partial class Form_list_prak : Form
    {

        DBConnection Dbcon = new DBConnection();



        public Form_list_prak()
        {
            InitializeComponent();
        }

        //string IdS;

        DBConnection connect_DB = new DBConnection();

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5C9E2EP2\MYSERVER;Initial Catalog=VKR01;Integrated Security=True");
        string idS;

        private void Form_list_prak_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(@"SELECT   praktikanti.ID AS Ключ , praktikanti.name_prak AS [имя практиканта], dbo.praktikanti.surename_prak AS [фамилия практиканта],dbo.praktikanti.pat_prak AS [Отчество практиканта] , dbo.praktikanti.begin_prak AS [начало практики]  , dbo.praktikanti.end_prak AS [конец практики ]   ,dbo.praktikanti.phone_prak AS [телефон практиканта], dbo.praktikanti.facultet_prak AS [специальность практиканта], dbo.praktikanti.group_prak AS [группа практиканта], dbo.sotrudniki.f_s AS [фамилия руководителя практики]  FROM dbo.praktikanti INNER JOIN dbo.sotrudniki ON dbo.praktikanti.rukovod_prak = dbo.sotrudniki.id_sotrud                        ", con);
            DataTable table = new DataTable();
            table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idS = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbNamePrak.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbSurnamePrak.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbPatPrak.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTBbeginPrak.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            maskedTBendPrak.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            maskedTBPhonePrak.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbNazvSpecial.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tbGroupPrak.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();



        }

        private void butAddPrak_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_reg_praktikant frp = new Form_reg_praktikant();
            frp.Show();
        }

        private void butDelPrak_Click(object sender, EventArgs e)
        {

            {

                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("praktikant_Delete", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCommand.Parameters.AddWithValue("@Id", Convert.ToInt32(idS));
                    sqlCommand.ExecuteNonQuery();
                    Update();
                    MessageBox.Show("Практикант был удален");


                    SqlDataAdapter dataAdapter = new SqlDataAdapter(@"SELECT   praktikanti.ID AS Ключ , praktikanti.name_prak AS [имя практиканта], dbo.praktikanti.surename_prak AS [фамилия практиканта],dbo.praktikanti.pat_prak AS [Отчество практиканта] , dbo.praktikanti.begin_prak AS [начало практики]  , dbo.praktikanti.end_prak AS [конец практики ]   ,dbo.praktikanti.phone_prak AS [телефон практиканта], dbo.praktikanti.facultet_prak AS [специальность практиканта], dbo.praktikanti.group_prak AS [группа практиканта], dbo.sotrudniki.f_s AS [фамилия руководителя практики]  FROM dbo.praktikanti INNER JOIN dbo.sotrudniki ON dbo.praktikanti.rukovod_prak = dbo.sotrudniki.id_sotrud                        ", con);
                    DataTable table = new DataTable();
                    table = new DataTable();
                    dataAdapter.Fill(table);
                    dataGridView1.DataSource = table;
                    con.Close();
                
            }
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)

                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        break;
                    }

                    if (tbSearch.Text == dataGridView1.Rows[i].Cells[j].Value.ToString())
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[j];
                        dataGridView1.FirstDisplayedScrollingRowIndex = i;
                        break;
                    }

                }
        }

        private void butFilter_Click(object sender, EventArgs e)
        {

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"surename_prak LIKE '% {tbFilter.Text} %'";
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_menu_sot fms = new Form_menu_sot();
            fms.Show();
        }

        private void butChangePrak_Click(object sender, EventArgs e)
        {

        }
    }
}
