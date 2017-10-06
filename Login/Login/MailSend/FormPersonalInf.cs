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
        public FormPersonalInf()
        {
            InitializeComponent();
        }

        private void btn_NewMessage_Click(object sender, EventArgs e)
        {
            FormMailSend fms = new FormMailSend(txb_Mail.Text, txb_Password.Text, cmb_SMTP.Text, Convert.ToInt32(cmb_Port.Text), checkBox_SSL.Checked);
            fms.Show();
        }

        private void btn_Autorization_Click(object sender, EventArgs e)
        {
           
        }
    }
}
