using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Login
{
    public partial class FormAutorization : Form
    {
        public string Address { get; set; }
        public string Port { get; set; }
        public FormAutorization()
        {
            InitializeComponent();
        }
        public FormAutorization(string Address, string Port)
        {
            this.Address = Address;
            this.Port = Port;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            
            try
            {
                //TcpClient client = new TcpClient("127.0.0.1", 8888);
                //NetworkStream stream = client.GetStream();
                //string message = string.Format(@"LogIn|{0}|{1}|", txb_Name.Text, txb_Password.Text);
                //byte[] data = Encoding.Unicode.GetBytes(message);
                //stream.Write(data, 0, data.Length);

                //byte[] answer = new byte[256];
                //StringBuilder response = new StringBuilder();
                //int bytes = stream.Read(answer, 0, answer.Length);
                //response.Append(Encoding.Unicode.GetString(answer, 0, bytes));
                //string res = response.ToString();
                //if (res == "" || res == null)
                //{
                //    MessageBox.Show("Неверное имя пользователя или пароль!!");
                //}
                //else
                //{
                    FormMain fm = new FormMain("1");
                    fm.Show();
                    this.Hide();
                //}
                //client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Registration_Click(object sender, EventArgs e)
        {
            FormRegistration fr = new FormRegistration();
            this.Hide();
            fr.Show();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSettings fs = new FormSettings();
            fs.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
