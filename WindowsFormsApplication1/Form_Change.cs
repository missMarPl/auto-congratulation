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
            
            OleDbConnection conn = new OleDbConnection();
            //устанавливаем строку подключения для данного объекта-подключения
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_congrat.accdb";
            //создаем команду
            //передаем sql-запрос команде
            OleDbCommand cmd = new OleDbCommand("SELECT FrID,Birthday,Sex,Job,[e-mail] FROM Friend WHERE FrName='" + name + "'", conn);
            OleDbCommand aq_cmd = new OleDbCommand("SELECT Acquaintance.FrID FROM Friend INNER JOIN Acquaintance ON (Friend.FrID = Acquaintance.FrID2) WHERE (((Friend.FrName)='" + name + "')) UNION SELECT Acquaintance.FrID2 FROM Friend INNER JOIN Acquaintance ON (Friend.FrID = Acquaintance.FrID) WHERE (((Friend.FrName)='" + name + "'));", conn);
            int fid=0;
            //OleDbCommand aq2_cmd = new OleDbCommand("SELECT FrName FROM Friend WHERE FrID="+fid,conn);
            //открываем подключение
            conn.Open();
            //выполняем команду и создаем объект чтения данных
            OleDbDataReader dr = cmd.ExecuteReader();
            //метод Read() считывает данные строка за строкой
            while (dr.Read())
            {
                //в данной строке мы выбираем данные хранящиеся в столбце мое_поле
                id = dr.GetOrdinal("FrID");
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
            OleDbDataReader dr2 = aq_cmd.ExecuteReader();
            while (dr2.Read())
            {
                //в данной строке мы выбираем данные хранящиеся в столбце мое_поле
                fid = dr2.GetOrdinal("FrID");
               // OleDbDataReader dr3 = aq2_cmd.ExecuteReader();
                //string str = dr3.GetString(dr.GetOrdinal("FrName"));
                aq_listBox.Items.Add(fid);
               // dr3.Close();
            }
            dr2.Close();
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

            OleDbCommand cmd = new OleDbCommand("UPDATE Friend SET Birthday='" + change_age_textBox.Text + "', Sex='" + change_sex_textBox.Text + "', Job='" + change_job_textBox.Text + "', e-mail='" + change_mail_textBox.Text + "' WHERE FrID='" + id + "'", conn);
            OleDbCommand aq_cmd = new OleDbCommand("INSERT INTO Acquaintance (FrID,FrID2) SELECT '" + id + "', Friend .FrID FROM Friend WHERE ((Friend.FrName)='" + aq_listBox.SelectedItem.ToString() + "') IF NOT EXISTS (SELECT Acquaintance.FrID FROM Friend INNER JOIN Acquaintance ON (Friend.FrID = Acquaintance.FrID2) WHERE (((Friend.FrName)='" + name + "')AND FrID=" + id + ") UNION SELECT Acquaintance.FrID2 FROM Friend INNER JOIN Acquaintance ON (Friend.FrID = Acquaintance.FrID) WHERE (((Friend.FrName)='" + name + "')AND FrID2=" + id + ");)", conn);
            //открываем подключение
            conn.Open();
            //выполняем команду и создаем объект чтения данных
            OleDbDataReader dr = cmd.ExecuteReader();
            //закрываем объект чтения данных и объект подключения
            dr.Close();
            OleDbDataReader dr2 = aq_cmd.ExecuteReader();

            dr2.Close();
            conn.Close();
            Close();
        }

    }
}
