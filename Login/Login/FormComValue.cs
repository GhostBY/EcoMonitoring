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
using System.Windows.Forms.DataVisualization.Charting;

namespace Login
{
    public partial class FormComValue : Form
    {
        public string Year { get; set; }
        public FormComValue()
        {
            InitializeComponent();
        }
        public FormComValue(string Year)
        {
            this.Year = Year;
            InitializeComponent();
        }

        private void FormComValue_Load(object sender, EventArgs e)
        {
            LoadInf();
        }
        public void LoadInf()
        {
            byte[] answer = new byte[5000];
            int bytes=0;
            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 8888);
                NetworkStream stream = client.GetStream();
                string message = string.Format(@"GetComValue|{0}|", Year);
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
                bytes = stream.Read(answer, 0, answer.Length);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
                StringBuilder response = new StringBuilder();
                response.Append(Encoding.Unicode.GetString(answer, 0, bytes));
                string res = response.ToString();

                string[] arr = res.Split('|');
                //////////////////////////////////////
                this.pieChart.Size = this.Size;
                ChartArea area = new ChartArea("PieChartArea");
                area.BorderWidth = this.Width;
                pieChart.ChartAreas.Add(area);
                pieChart.Series.Clear();
                pieChart.Palette = ChartColorPalette.EarthTones;
                pieChart.BackColor = Color.LightBlue;
                string titles = string.Format(@"Структура земельного фонда Республики Беларусь по видам земель в {0} году :", Year);
                pieChart.Titles.Add(titles);
                pieChart.ChartAreas[0].BackColor = Color.Transparent;
                Legend l = new Legend()
                {
                    BackColor = Color.Transparent,
                    ForeColor = Color.Black,
                    Title = "Обозначения"
                };
                pieChart.Legends.Add(l);
                Series s1 = new Series()
                {
                    Name = "s1",
                    IsVisibleInLegend = true,
                    Color = Color.Transparent,
                    ChartType = SeriesChartType.Pie
                };
                pieChart.Series.Add(s1);
                /////////////////////////////////////////
                for (int i = 0; i < arr.Length; i++)
                {

                    string[] split = arr[i].ToString().Split('$');
                    string a1 = split[0].ToString();
                    string a2 = split[1].ToString();
                    string a3 = split[2].ToString();
                    int val = Convert.ToInt32(a2);
                    DataPoint p = new DataPoint(0, Convert.ToDouble(split[2].ToString()));
                    p.AxisLabel = split[2].ToString();
                    p.LegendText = a1; ;
                    s1.Points.Add(p);
                }
            }
        }
    }

