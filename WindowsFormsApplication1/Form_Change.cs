using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form_Change : Form
    {
        int id;
        public Form_Change(string name)
        {
            InitializeComponent();

            change_FIO_textBox.Text = name;

            OleDbConnection conn = new OleDbConnection();
            //устанавливаем строку подключения для данного объекта-подключения
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_congrat.accdb";
            //создаем команду
            //передаем sql-запрос команде
            OleDbCommand cmd = new OleDbCommand("SELECT FrID,Birthday,Sex,Job,[e-mail] FROM Friend WHERE FrName='" + name + "'", conn);
            
            
            //открываем подключение
            conn.Open();
            //выполняем команду и создаем объект чтения данных
            OleDbDataReader dr = cmd.ExecuteReader();
            //метод Read() считывает данные строка за строкой
            while (dr.Read())
            {
                //в данной строке мы выбираем данные хранящиеся в столбце мое_поле
                id = dr.GetInt32(dr.GetOrdinal("FrID"));
                string str = dr.GetString(dr.GetOrdinal("Birthday"));
                change_age_textBox.Text = str;
                str = dr.GetString(dr.GetOrdinal("Sex"));
                change_sex_textBox.Text = str;
                str = dr.GetString(dr.GetOrdinal("Job"));
                change_job_textBox.Text = str;
                str = dr.GetString(dr.GetOrdinal("e-mail"));
                change_mail_textBox.Text = str;
            }
            //закрываем объект чтения данных и объект подключения
            dr.Close();
           
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = change_FIO_textBox.Text;
            OleDbConnection conn = new OleDbConnection();
            //устанавливаем строку подключения для данного объекта-подключения
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_congrat.accdb";
            //создаем команду
            //передаем sql-запрос команде
            
            OleDbCommand cmd = new OleDbCommand("UPDATE Friend SET FrName='"+name+"', Birthday='" + change_age_textBox.Text + "', Sex='" + change_sex_textBox.Text + "', Job='" + change_job_textBox.Text + "', [e-mail]='" + change_mail_textBox.Text + "' WHERE FrID=" + id, conn);
            //открываем подключение
            conn.Open();
            //выполняем команду и создаем объект чтения данных
            cmd.ExecuteNonQuery();
     
            conn.Close();
            Close();
        }

    }
}
