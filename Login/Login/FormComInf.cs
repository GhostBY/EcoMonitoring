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
    public partial class FormComInf : Form
    {
        public string Type { get; set; }
        public string Year { get; set; }
        public FormComInf()
        {
            InitializeComponent();
        }
        public FormComInf(string Type, string Year)
        {
            this.Type = Type;
            this.Year = Year;
            InitializeComponent();
        }
        private void FormComInf_Load(object sender, EventArgs e)
        {
            LoadInf();
            this.label1.Text = string.Format(@"Доля почвы в общей площади земель администрантивных областей Беларуси в {0}.", Year);
           
            label3.Text = string.Format(@"{0}:", Type);
        }
        public void LoadInf()
        {
            byte[] answer = new byte[5000];
            int bytes = 0;
            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 8888);
                NetworkStream stream = client.GetStream();
                string message = string.Format(@"GetComInf|{0}|{1}|", Type, Year);
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
                bytes = stream.Read(answer, 0, answer.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            StringBuilder response = new StringBuilder();
            response.Append(Encoding.Unicode.GetString(answer, 0, bytes));
            string res = response.ToString();
            string[] arr = res.Split('|');
            this.dataGridView1.Columns[2].Width = 200;
            this.dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[2].Width = 180;
            for (int i = 0; i < arr.Length; i++)
            {
                string[] split = arr[i].ToString().Split('$');
                double val = Convert.ToDouble(split[2].ToString());
                string district = split[0].ToString();
                this.chart1.Series["District"].Points.AddXY(district, val);
                dataGridView1.Rows.Add();
                string a1 = split[0].ToString();
                string a2 = split[1].ToString();
                string a3 = split[2].ToString();
                string a4 = split[3].ToString();
                this.dataGridView1[0, i].Value = a1;
                this.dataGridView1[1, i].Value = a2;
                this.dataGridView1[2, i].Value = a3;
                this.dataGridView1[3, i].Value = a4;
            }
                
            }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }
