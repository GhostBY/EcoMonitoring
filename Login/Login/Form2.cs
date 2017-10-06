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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient("127.0.0.1", 8888);
            NetworkStream stream = client.GetStream();
            string message = string.Format(@"Test|");
            byte[] data = Encoding.Unicode.GetBytes(message);
            stream.Write(data, 0, data.Length);

            byte[] answer = new byte[5000];
            StringBuilder response = new StringBuilder();
            int bytes = stream.Read(answer, 0, answer.Length);
            response.Append(Encoding.Unicode.GetString(answer, 0, bytes));
            string res = response.ToString();
            string[] arr = res.Split('|');
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    string[] split = arr[i].ToString().Split(',');
                    string a1 = split[0].ToString();
                    string a2 = split[1].ToString();
                    this.dataGridView1[0, i].Value = a1;
                    this.dataGridView1[1, i].Value = a2;
                }
                else
                {
                    dataGridView1.Rows.Add();
                    string[] split = arr[i].ToString().Split(',');
                    string a1 = split[0].ToString();
                    string a2 = split[1].ToString();
                    this.dataGridView1[0, i].Value = a1;
                    this.dataGridView1[1, i].Value = a2;
                }
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
