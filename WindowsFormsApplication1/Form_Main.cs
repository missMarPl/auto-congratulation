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
    public partial class Form_Main : Form
    {
        public string minf1, minf2, minf3, minf4;

        string  currentDate;
        public void format_date()
        {
            currentDate = DateTime.Now.Date.ToString();
            currentDate = currentDate.Substring(0, 5);
        }

        public Form_Main()
        {
            InitializeComponent();
           // checkedListBox1.SetItemChecked(1, true);
           // checkedListBox1.GetItemChecked(1);
            format_date();
		    main_comboBox.Items.Clear();

		    OleDbConnection conn = new OleDbConnection();
            //устанавливаем строку подключения для данного объекта-подключения
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=H:/db_congrat.accdb";
            //создаем команду
            //передаем sql-запрос команде
            OleDbCommand cmd = new OleDbCommand("SELECT HolName FROM Holiday WHERE HolDate='"+currentDate+"'",conn);
            //открываем подключение
            conn.Open();
            //выполняем команду и создаем объект чтения данных
            OleDbDataReader dr = cmd.ExecuteReader();
            //метод Read() считывает данные строка за строкой
            while (dr.Read())
            {
                //в данной строке мы выбираем данные хранящиеся в столбце мое_поле
                string str = dr.GetString(dr.GetOrdinal("HolName"));
                //записываем данные в коллекцию хранящую пункты в комбобокс
                main_comboBox.Items.Add(str);
            }
            //закрываем объект чтения данных и объект подключения
            dr.Close();
            conn.Close();
            main_comboBox.Items.Add("День рождения");
        }
		

	private void main_comboBox_SelectionChanged(object sender, EventArgs e)
    {
        main_checkedListBox.Items.Clear();
        string comboItem = main_comboBox.SelectedItem.ToString();
        

		   OleDbConnection conn = new OleDbConnection();
            //устанавливаем строку подключения для данного объекта-подключения
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=H:/db_congrat.accdb";
            //создаем команду
            OleDbCommand cmd = conn.CreateCommand();
			//передаем sql-запрос команде

            switch (comboItem)
            {
                case "День рождения":
                    cmd.CommandText = "SELECT FrName FROM Friend WHERE Birthday LIKE '" + currentDate + "%'";
                    break;
                case "8 марта":
                    cmd.CommandText = "SELECT FrName FROM Friend WHERE Sex='ж'";
                    break;
                default:
                    cmd.CommandText = "SELECT FrName FROM Friend";
                    break;
            }
            //открываем подключение
            conn.Open();
            //выполняем команду и создаем объект чтения данных
            OleDbDataReader dr = cmd.ExecuteReader();
            //метод Read() считывает данные строка за строкой
            while (dr.Read())
            {
                //в данной строке мы выбираем данные хранящиеся в столбце мое_поле
                string str = dr.GetString(dr.GetOrdinal("FrName"));
                //записываем данные в коллекцию хранящую пункты в листбокс
               main_checkedListBox.Items.Add(str);
            }
            //закрываем объект чтения данных и объект подключения
            dr.Close();
            conn.Close();        
    }

//поисковые дела    
        private void main_search_button_Click(object sender, EventArgs e)
        {
            Form_Search form = new Form_Search();
            form.Owner = this;
            form.Location = new Point(200, 300);
            form.Show();

        }

//поисковые дела
        private void main_refresh_button_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            //устанавливаем строку подключения для данного объекта-подключения
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=H:/db_congrat.accdb";
            conn.Open();

            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT FrName FROM Friend WHERE (FrName ='" + minf1 + "') OR (Birthday='" + minf2 + "') OR (Job='" + minf3 + "') OR (Sex='" + minf4 + "')";

            //cmd.CommandText = "SELECT FrName FROM Friend WHERE (FrName='Бродский')";

            OleDbDataReader dr = cmd.ExecuteReader();
            //метод Read() считывает данные строка за строкой
            while (dr.Read())
            {
                //в данной строке мы выбираем данные хранящиеся в столбце мое_поле
                string str = dr.GetString(dr.GetOrdinal("FrName"));
                //записываем данные в коллекцию хранящую пункты в листбокс
                main_checkedListBox.Items.Add(str);
            }
            //main_checkedListBox.Items.Add(minf1);
            conn.Close(); 
        }
		
        private void dropData_button_Click(object sender, EventArgs e) //сбросить
        {
            main_checkAll_button.Visible = true;
            main_dropData_button.Visible = false;
            for (int i = 0; i < main_checkedListBox.Items.Count; i++)
                main_checkedListBox.SetItemChecked(i, false);
        }

        private void checkAll_button_Click(object sender, EventArgs e) //выбрать всех
        {
            main_dropData_button.Visible = true;
            for (int i = 0; i < main_checkedListBox.Items.Count; i++)
                main_checkedListBox.SetItemChecked(i, true);

        }

        
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Add form= new Form_Add();
           // form.Location = new Point(200, 300);
            form.Show();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_List form = new Form_List();
            form.Location = new Point(200, 300);
            form.Show();
        }

        private void рекомендованныеПодравленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PopUp form = new Form_PopUp();
            //form.Location = new Point(200, 300);
            form.Show();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailSettings form = new MailSettings();
            form.Location = new Point(200, 300);
            form.Show();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form_PopUp frm = new Form_PopUp();
            //frm.clozeApp();
            Application.Exit();

        }

        private void main_exit_menuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void main_send_button_Click(object sender, EventArgs e)
        {
            int y = main_checkedListBox.CheckedItems.Count;
            string[] selected_names = new string[y];
            main_checkedListBox.CheckedItems.CopyTo(selected_names, 0);

            Generator gen = new Generator(selected_names, main_comboBox.SelectedItem.ToString());
            
        }

        private void Form_Main_Activated(object sender, EventArgs e)
        {

        }

        

    

        
    }
}
