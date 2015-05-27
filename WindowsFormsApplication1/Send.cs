using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    class Send
    {
       int i;
       string[] letter;
        /// <summary>
        /// Отправка письма на почтовый ящик C# mail send
        /// </summary>
        /// <param name="smtpServer">Имя SMTP-сервера</param>
        /// <param name="from">Адрес отправителя</param>
        /// <param name="password">пароль к почтовому ящику отправителя</param>
        /// <param name="mailto">Адрес получателя</param>
        /// <param name="caption">Тема письма</param>
        /// <param name="message">Сообщение</param>
        ///
        public Send()
        {
           i = 0;
           letter = new string[5];
        }
                

                public void GetSettings()
                {
                    System.IO.StreamReader file = new System.IO.StreamReader(@"mailset.txt");
                    i = 0;
                    while ((letter[i] = file.ReadLine()) != null)
                    {
                        i++;                        
                    }
                    file.Close();
                }

        public void SendMail(string smtpServer, string port, string from, string password,
        string mailto, string caption, string message)
        {
            try
            {
                int numPort = Convert.ToInt32(port);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add(new MailAddress(mailto));
                mail.Subject = caption;
                mail.Body = message;
                SmtpClient client = new SmtpClient();
                client.Host = smtpServer;
                client.Port = numPort;
                client.EnableSsl = false;
                client.Credentials = new NetworkCredential(from.Split('@')[0], password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);
                mail.Dispose();
            }
            catch (Exception e)
            {
                Err_Dial win = new Err_Dial(e);
                win.Show();
            }
        }

        public  void CreateLetter()
        {
            GetSettings();
            string[] message=new string[7];
            //берём из файла mailto, caption, message
            System.IO.StreamReader file = new System.IO.StreamReader(@"message.txt");
            i = 0;
            while ((message[i] = file.ReadLine()) != null)
            {
                i++;
            }
            file.Close();
            message[2] = message[2] + " " + message[3] + " " + message[4] + " " + message[5];
            
            SendMail(letter[0], letter[1], letter[2], letter[3], message[0], message[1], message[2]);
        }
    }
}