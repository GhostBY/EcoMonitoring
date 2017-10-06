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
    public partial class FormMain : Form
    {
        public string Id { get; set; }
        public FormMain()
        {
            InitializeComponent();
        }
        public FormMain(string Id)
        {
            this.Id = Id;
            InitializeComponent();
        }

        private void btn_SoilMon_Click(object sender, EventArgs e)
        {
            FormComSoil fcs = new FormComSoil();
            fcs.Show();
            this.Hide();
        }

        private void btn_More_Click(object sender, EventArgs e)
        {
            FormPersonalInf fpi = new FormPersonalInf(Id);
            fpi.Show();
            this.Hide();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
