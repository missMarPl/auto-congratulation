using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    class Generator
    {
        string[] texts, mails;
        int N;
       public Generator(string[] names, string holiday)
        {
            N = names.Length;
            texts = new string[N];
            mails = new string[N];

            Random random = new Random();

            
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=db_congrat.accdb";
            conn.Open();

            OleDbCommand cmd2 = new OleDbCommand("SELECT Congratulatoin.CongrText FROM Holiday INNER JOIN Congratulatoin ON Holiday.HolID = Congratulatoin.HolID WHERE (((Holiday.HolName)='" + holiday + "'))", conn);
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            int z=0;
            string[] congrs = new string[50];
            while (dr2.Read())
            {
                string str = dr2.GetString(dr2.GetOrdinal("CongrText"));
                congrs[z] = str;
                z++;
            }
            dr2.Close();

            for (int i = 0; i < N; i++)
            {

                OleDbCommand cmd = new OleDbCommand("SELECT [e-mail] FROM Friend WHERE FrName='" + names[i]+"'", conn);


                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string str = dr.GetString(dr.GetOrdinal("e-mail"));
                    mails[i] = str;
                }
                dr.Close();

                texts[i] = congrs[random.Next(0,z)];
            }
            conn.Close();

            for (int i = 0; i < N; i++)
            {
                System.IO.File.Delete(@"message.txt");
                System.IO.File.AppendAllText(@"message.txt", mails[i]+"\n");
                System.IO.File.AppendAllText(@"message.txt", holiday + " - поздравляю!\n");
                System.IO.File.AppendAllText(@"message.txt", texts[i]);

                Send test = new Send();
                test.CreateLetter();
               
            }
            Ok_Dial win = new Ok_Dial();

        }
    }
}
