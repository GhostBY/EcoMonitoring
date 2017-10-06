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
    public partial class FormPersonalInf : Form
    {
        public string Id { get; set; }
        public string Info { get; set; }
        public FormPersonalInf()
        {
           
            InitializeComponent();
        }
        public FormPersonalInf(string Id)
        {
            this.Id = Id;
            InitializeComponent();
        }
        public void LoadInf()
        {
            EcoClient ecolient = new EcoClient("127.0.0.1", 8888);
            Info= ecolient.Send(Id);
        }
        private void btn_NewMessage_Click(object sender, EventArgs e)
        {
            FormMailSend fms = new FormMailSend(txb_Mail.Text, txb_Password.Text, cmb_SMTP.Text, Convert.ToInt32(cmb_Port.Text), checkBox_SSL.Checked);
            fms.Show();
        }

        private void btn_Autorization_Click(object sender, EventArgs e)
        {
            //MailSMTP mailsmtp = new MailSMTP(txb_Mail.Text, txb_Password.Text, checkBox_SSL.Checked, cmb_SMTP.Text, Convert.ToInt32(cmb_Port.Text));
            //string res = mailsmtp.Autorization();
            MailSMTP mailsmtp = new MailSMTP(txb_Mail.Text, txb_Password.Text, checkBox_SSL.Checked, cmb_SMTP.Text, Convert.ToInt32(cmb_Port.Text));
            string res = mailsmtp.Autorization();
            try
            {
                if (res == "True")
                {
                    btn_Autorization.Enabled = true;
                }
                else
                {
                    MessageBox.Show("False");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormPersonalInf_Load(object sender, EventArgs e)
        {
            LoadInf();
            string[] arr = Info.Split('$');
            lbl_Family.Text =  "Фамилия: "+arr[3].ToString();
            lbl_Name.Text = "Имя: " + arr[2].ToString();
            lbl_SecondName.Text = "Имя пользователя: " + arr[0].ToString();
            lbl_Telephone.Text = "Телефон: " + arr[5].ToString(); ;
            lbl_Mail.Text = "Эл. почта: " + arr[4].ToString();
            txb_Mail.Text = arr[4].ToString();
            
        }
    }
}
