using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;



namespace AutoEmailGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void sendEmail(SmtpClient smtp)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(username.Text);
            mail.To.Add(receiver.Text);
            mail.Subject = subject.Text;
            mail.Body = body.Text;
            smtp.Send(mail);

           
            receiver.Text = "";
            MessageBox.Show("E-mail sent successfully ");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(username.Text) && string.IsNullOrEmpty(pwd.Text))
                {
                    MessageBox.Show("Please Input Correct Username and Password");
                }
                else
                {
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;
                    NetworkCredential nc = new NetworkCredential(username.Text, pwd.Text);
                    smtp.Credentials = nc;


                    sendEmail(smtp);
                }
            }
            catch { MessageBox.Show("Incorrect Credentials"); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
