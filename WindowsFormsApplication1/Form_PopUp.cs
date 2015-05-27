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
    public partial class Form_PopUp : Form
    {
        public Form_PopUp()
        {
            InitializeComponent();
            date_label.Text = DateTime.Now.ToString("dd MMMM yyyy");;

            popUp_borntoday_list.Items.Clear();
            popUp_today_list.Items.Clear();

            OleDbConnection conn = new OleDbConnection();
            //устанавливаем строку подключения для данного объекта-подключения
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_congrat.accdb";
            //создаем команду
            //передаем sql-запрос команде
            OleDbCommand cmd = new OleDbCommand("SELECT FrName FROM Friend WHERE Birthday LIKE '" + DateTime.Now.Date.ToString().Substring(0, 5) + "%'", conn);
            OleDbCommand cmd2 = new OleDbCommand("SELECT HolName FROM Holiday WHERE HolDate='" + DateTime.Now.Date.ToString().Substring(0, 5) + "'", conn);
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
                popUp_borntoday_list.Items.Add(str);
            }
            //закрываем объект чтения данных и объект подключения
            dr.Close();

            OleDbDataReader dr2 = cmd2.ExecuteReader();
            //метод Read() считывает данные строка за строкой
            while (dr2.Read())
            {
                //в данной строке мы выбираем данные хранящиеся в столбце мое_поле
                string str = dr2.GetString(dr2.GetOrdinal("HolName"));
                //записываем данные в label списка праздников
                popUp_today_list.Items.Add(str);
            }
            //закрываем объект чтения данных и объект подключения
            dr2.Close();
            conn.Close();
        }

        private void Form_PopUp_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, Screen.PrimaryScreen.WorkingArea.Height - Height);
        }

        private void openMain_button_Click(object sender, EventArgs e)
        {
            Hide();
            Form_Main form = new Form_Main();
            //form.Location = new Point(200, 300);
            form.Show();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }


        public void clozeApp()
        {
            Close();
        }

        private void popUp_sendToEveryone_button_Click(object sender, EventArgs e)
        {
            int y = popUp_borntoday_list.Items.Count;
            string[] selected_names = new string[y];
            popUp_borntoday_list.Items.CopyTo(selected_names, 0);

            Generator gen = new Generator(selected_names, "Поздравляю!");
        }
    }
}
