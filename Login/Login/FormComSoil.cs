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
    public partial class FormComSoil : Form
    {
        public FormComSoil()
        {
            InitializeComponent();
        }

        private void FormComSoil_Load(object sender, EventArgs e)
        {
            GetInfo();
            
        }
        public void GetInfo()
        {
            TcpClient client = new TcpClient("127.0.0.1", 8888);
            NetworkStream stream = client.GetStream();
            string message = string.Format(@"GetComSoil|");
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
                    string[] split = arr[i].ToString().Split('$');
                    string a1 = split[0].ToString();
                    string a2 = split[1].ToString();
                    string a3 = split[2].ToString();
                    this.dataGridView1[0, i].Value = a1;
                    this.dataGridView1[1, i].Value = a2;
                    this.dataGridView1[2, i].Value = a3;
                }
                else
                {
                    dataGridView1.Rows.Add();
                    string[] split = arr[i].ToString().Split('$');
                    string a1 = split[0].ToString();
                    string a2 = split[1].ToString();
                    string a3 = split[2].ToString();
                    this.dataGridView1[0, i].Value = a1;
                    this.dataGridView1[1, i].Value = a2;
                    this.dataGridView1[2, i].Value = a3;
                }
                this.dataGridView1.Columns[0].Width = this.Width / 2;
                this.dataGridView1.Columns[1].Width = 195;
                this.dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[2].Width = 180;
            }
        }

        private void btn_Pie_Click(object sender, EventArgs e)
        {
            FormComValue fcv = new FormComValue(cmb_PieYear.Text.ToString());
            fcv.Show();
        }

        private void btn_ComInf_Click(object sender, EventArgs e)
        {
            FormComInf fci = new FormComInf(cmb_ComType.Text, cmb_ComYear.Text);
            fci.Show();
        }
    }
}
