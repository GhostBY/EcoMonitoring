using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Login
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btn_Registration_Click(object sender, EventArgs e)
        {
            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 8888);
                NetworkStream stream = client.GetStream();
                string message = string.Format(@"Registration|{0}|{1}|{2}|{3}|{4}|{5}|", txb_UserName.Text,txb_Password.Text,txb_Name.Text,txb_Family.Text,txb_Mail.Text,txb_Telephone.Text);
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
                byte[] answer = new byte[256];
                StringBuilder response = new StringBuilder();
                int bytes = stream.Read(answer, 0, answer.Length);
                response.Append(Encoding.Unicode.GetString(answer, 0, bytes));
                string res = response.ToString();
                if (res == "True")
                {
                    MessageBox.Show("Вы успешно зарегестрировались");
                    FormAutorization fa = new FormAutorization();
                    fa.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка регистрации");
                    FormAutorization fa = new FormAutorization();
                    fa.Show();
                    this.Close();
                }
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txb_City_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
