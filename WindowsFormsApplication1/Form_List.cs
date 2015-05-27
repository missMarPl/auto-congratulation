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
    public partial class Form_List : Form
    {
        public Form_List()
        {
            InitializeComponent();
            fillList();
        }

        private void fillList() {
            list_listBox.Items.Clear();
            OleDbConnection conn = new OleDbConnection();
            //устанавливаем строку подключения для данного объекта-подключения
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_congrat.accdb";
            //создаем команду
            //передаем sql-запрос команде
            OleDbCommand cmd = new OleDbCommand("SELECT FrName FROM Friend", conn);
            //открываем подключение
            conn.Open();
            //выполняем команду и создаем объект чтения данных
            OleDbDataReader dr = cmd.ExecuteReader();
            //метод Read() считывает данные строка за строкой
            while (dr.Read())
            {
                //в данной строке мы выбираем данные хранящиеся в столбце мое_поле
                string str = dr.GetString(dr.GetOrdinal("FrName"));
                //записываем данные в коллекцию хранящую пункты в комбобокс
                list_listBox.Items.Add(str);
            }
            //закрываем объект чтения данных и объект подключения
            dr.Close();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Search form = new Form_Search();
            //form.Location = new Point(200, 300);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Change form = new Form_Change(list_listBox.SelectedItem.ToString());
            //form.Location = new Point(200, 300);
            form.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_congrat.accdb";
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Friend WHERE FrName='"+list_listBox.SelectedItem.ToString()+"'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            fillList();
        }
    }
}
