using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class FormMailSend : Form
    {
        public string Mail { get; set; }
        public string Password { get; set; }
        public string SMTP { get; set; }
        public int Port { get; set; }
        public bool SSL { get; set; }
        public FormMailSend()
        {
            InitializeComponent();
        }
        public FormMailSend(string Mail,string Password, string SMTP, int Port, bool SSl )
        {
            this.Mail = Mail;
            this.Password = Password;
            this.SMTP = SMTP;
            this.Port = Port;
            this.SSL = SSl;
           
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
        }

        private void FormMailSend_Load(object sender, EventArgs e)
        {
            this.txb_From.Text = Mail;
            txb_SMTP.Text = SMTP;
            if (SSL == true)
            {
                lbl_SSL.Text += "Использвать шифрование: Да";
            }
            else
            {
                lbl_SSL.Text += "Использвать шифрование: Нет";
            }
        }
    }
}
