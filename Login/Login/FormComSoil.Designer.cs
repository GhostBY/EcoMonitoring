namespace Login
{
    partial class FormComSoil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_ComType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_SecondYear = new System.Windows.Forms.ComboBox();
            this.btn_Pie = new System.Windows.Forms.Button();
            this.btn_ComInf = new System.Windows.Forms.Button();
            this.cmb_FirstYear = new System.Windows.Forms.ComboBox();
            this.btn_RegInf = new System.Windows.Forms.Button();
            this.cmb_RegType = new System.Windows.Forms.ComboBox();
            this.rB_Percent = new System.Windows.Forms.RadioButton();
            this.rB_Square = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.gb_Pie = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_PieYear = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_Legend = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SoilView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_Reg = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_ComYear = new System.Windows.Forms.ComboBox();
            this.gb_Com = new System.Windows.Forms.GroupBox();
            this.gb_Pie.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_Reg.SuspendLayout();
            this.gb_Com.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тип почвы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Год:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "по";
            // 
            // cmb_ComType
            // 
            this.cmb_ComType.FormattingEnabled = true;
            this.cmb_ComType.Items.AddRange(new object[] {
            "Орашенная",
            "Осушенная",
            "Пахотная"});
            this.cmb_ComType.Location = new System.Drawing.Point(133, 52);
            this.cmb_ComType.Name = "cmb_ComType";
            this.cmb_ComType.Size = new System.Drawing.Size(100, 21);
            this.cmb_ComType.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Период с:";
            // 
            // cmb_SecondYear
            // 
            this.cmb_SecondYear.FormattingEnabled = true;
            this.cmb_SecondYear.Items.AddRange(new object[] {
            "2013",
            "2014",
            "2015"});
            this.cmb_SecondYear.Location = new System.Drawing.Point(165, 93);
            this.cmb_SecondYear.Name = "cmb_SecondYear";
            this.cmb_SecondYear.Size = new System.Drawing.Size(57, 21);
            this.cmb_SecondYear.TabIndex = 5;
            // 
            // btn_Pie
            // 
            this.btn_Pie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pie.Location = new System.Drawing.Point(6, 100);
            this.btn_Pie.Name = "btn_Pie";
            this.btn_Pie.Size = new System.Drawing.Size(107, 33);
            this.btn_Pie.TabIndex = 0;
            this.btn_Pie.Text = "Построить";
            this.btn_Pie.UseVisualStyleBackColor = true;
            this.btn_Pie.Click += new System.EventHandler(this.btn_Pie_Click);
            // 
            // btn_ComInf
            // 
            this.btn_ComInf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ComInf.Location = new System.Drawing.Point(6, 100);
            this.btn_ComInf.Name = "btn_ComInf";
            this.btn_ComInf.Size = new System.Drawing.Size(121, 33);
            this.btn_ComInf.TabIndex = 4;
            this.btn_ComInf.Text = "Показать";
            this.btn_ComInf.UseVisualStyleBackColor = true;
            this.btn_ComInf.Click += new System.EventHandler(this.btn_ComInf_Click);
            // 
            // cmb_FirstYear
            // 
            this.cmb_FirstYear.FormattingEnabled = true;
            this.cmb_FirstYear.Items.AddRange(new object[] {
            "2013",
            "2014",
            "2015"});
            this.cmb_FirstYear.Location = new System.Drawing.Point(70, 93);
            this.cmb_FirstYear.Name = "cmb_FirstYear";
            this.cmb_FirstYear.Size = new System.Drawing.Size(64, 21);
            this.cmb_FirstYear.TabIndex = 4;
            // 
            // btn_RegInf
            // 
            this.btn_RegInf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegInf.Location = new System.Drawing.Point(15, 100);
            this.btn_RegInf.Name = "btn_RegInf";
            this.btn_RegInf.Size = new System.Drawing.Size(121, 33);
            this.btn_RegInf.TabIndex = 9;
            this.btn_RegInf.Text = "Показать";
            this.btn_RegInf.UseVisualStyleBackColor = true;
            // 
            // cmb_RegType
            // 
            this.cmb_RegType.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_RegType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_RegType.FormattingEnabled = true;
            this.cmb_RegType.Items.AddRange(new object[] {
            "Осушенная",
            "Орашенная",
            "Пахотная"});
            this.cmb_RegType.Location = new System.Drawing.Point(81, 52);
            this.cmb_RegType.Name = "cmb_RegType";
            this.cmb_RegType.Size = new System.Drawing.Size(155, 21);
            this.cmb_RegType.TabIndex = 8;
            // 
            // rB_Percent
            // 
            this.rB_Percent.AutoSize = true;
            this.rB_Percent.Enabled = false;
            this.rB_Percent.Location = new System.Drawing.Point(10, 66);
            this.rB_Percent.Name = "rB_Percent";
            this.rB_Percent.Size = new System.Drawing.Size(186, 17);
            this.rB_Percent.TabIndex = 3;
            this.rB_Percent.TabStop = true;
            this.rB_Percent.Text = "По проценту от общей площади";
            this.rB_Percent.UseVisualStyleBackColor = true;
            // 
            // rB_Square
            // 
            this.rB_Square.AutoSize = true;
            this.rB_Square.Location = new System.Drawing.Point(10, 42);
            this.rB_Square.Name = "rB_Square";
            this.rB_Square.Size = new System.Drawing.Size(87, 17);
            this.rB_Square.TabIndex = 2;
            this.rB_Square.TabStop = true;
            this.rB_Square.Text = "По площаде";
            this.rB_Square.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Критерии для сравнения:";
            // 
            // gb_Pie
            // 
            this.gb_Pie.Controls.Add(this.label1);
            this.gb_Pie.Controls.Add(this.cmb_PieYear);
            this.gb_Pie.Controls.Add(this.btn_Pie);
            this.gb_Pie.Location = new System.Drawing.Point(12, 12);
            this.gb_Pie.Name = "gb_Pie";
            this.gb_Pie.Size = new System.Drawing.Size(126, 139);
            this.gb_Pie.TabIndex = 8;
            this.gb_Pie.TabStop = false;
            this.gb_Pie.Text = "Графичесое представление";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Год:";
            // 
            // cmb_PieYear
            // 
            this.cmb_PieYear.FormattingEnabled = true;
            this.cmb_PieYear.Items.AddRange(new object[] {
            "2013",
            "2014",
            "2015"});
            this.cmb_PieYear.Location = new System.Drawing.Point(6, 52);
            this.cmb_PieYear.Name = "cmb_PieYear";
            this.cmb_PieYear.Size = new System.Drawing.Size(110, 21);
            this.cmb_PieYear.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cmb_SecondYear);
            this.groupBox4.Controls.Add(this.cmb_FirstYear);
            this.groupBox4.Controls.Add(this.rB_Percent);
            this.groupBox4.Controls.Add(this.rB_Square);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(242, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 122);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // lbl_Legend
            // 
            this.lbl_Legend.AutoSize = true;
            this.lbl_Legend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Legend.Location = new System.Drawing.Point(150, 170);
            this.lbl_Legend.Name = "lbl_Legend";
            this.lbl_Legend.Size = new System.Drawing.Size(570, 16);
            this.lbl_Legend.TabIndex = 7;
            this.lbl_Legend.Text = "Характкристика земельного фонда Республики Беларусь по видам земель\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoilView,
            this.Year,
            this.Value});
            this.dataGridView1.Location = new System.Drawing.Point(12, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(867, 247);
            this.dataGridView1.TabIndex = 6;
            // 
            // SoilView
            // 
            this.SoilView.HeaderText = "Тип земельного фонда";
            this.SoilView.Name = "SoilView";
            // 
            // Year
            // 
            this.Year.HeaderText = "Год";
            this.Year.Name = "Year";
            // 
            // Value
            // 
            this.Value.HeaderText = "Занимаемая площадь";
            this.Value.Name = "Value";
            // 
            // gb_Reg
            // 
            this.gb_Reg.Controls.Add(this.groupBox4);
            this.gb_Reg.Controls.Add(this.btn_RegInf);
            this.gb_Reg.Controls.Add(this.cmb_RegType);
            this.gb_Reg.Controls.Add(this.label4);
            this.gb_Reg.Location = new System.Drawing.Point(392, 12);
            this.gb_Reg.Name = "gb_Reg";
            this.gb_Reg.Size = new System.Drawing.Size(487, 139);
            this.gb_Reg.TabIndex = 10;
            this.gb_Reg.TabStop = false;
            this.gb_Reg.Text = "Сравнительная характеристика";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тип почвы:";
            // 
            // cmb_ComYear
            // 
            this.cmb_ComYear.FormattingEnabled = true;
            this.cmb_ComYear.Items.AddRange(new object[] {
            "2013",
            "2014",
            "2015"});
            this.cmb_ComYear.Location = new System.Drawing.Point(6, 52);
            this.cmb_ComYear.Name = "cmb_ComYear";
            this.cmb_ComYear.Size = new System.Drawing.Size(121, 21);
            this.cmb_ComYear.TabIndex = 0;
            // 
            // gb_Com
            // 
            this.gb_Com.Controls.Add(this.btn_ComInf);
            this.gb_Com.Controls.Add(this.cmb_ComType);
            this.gb_Com.Controls.Add(this.label3);
            this.gb_Com.Controls.Add(this.label2);
            this.gb_Com.Controls.Add(this.cmb_ComYear);
            this.gb_Com.Location = new System.Drawing.Point(144, 12);
            this.gb_Com.Name = "gb_Com";
            this.gb_Com.Size = new System.Drawing.Size(242, 139);
            this.gb_Com.TabIndex = 9;
            this.gb_Com.TabStop = false;
            this.gb_Com.Text = "Общая информация";
            // 
            // FormComSoil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 448);
            this.Controls.Add(this.gb_Pie);
            this.Controls.Add(this.lbl_Legend);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_Reg);
            this.Controls.Add(this.gb_Com);
            this.Name = "FormComSoil";
            this.Text = "FormComSoil";
            this.Load += new System.EventHandler(this.FormComSoil_Load);
            this.gb_Pie.ResumeLayout(false);
            this.gb_Pie.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_Reg.ResumeLayout(false);
            this.gb_Reg.PerformLayout();
            this.gb_Com.ResumeLayout(false);
            this.gb_Com.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_ComType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_SecondYear;
        private System.Windows.Forms.Button btn_Pie;
        private System.Windows.Forms.Button btn_ComInf;
        private System.Windows.Forms.ComboBox cmb_FirstYear;
        private System.Windows.Forms.Button btn_RegInf;
        private System.Windows.Forms.ComboBox cmb_RegType;
        private System.Windows.Forms.RadioButton rB_Percent;
        private System.Windows.Forms.RadioButton rB_Square;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gb_Pie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_PieYear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_Legend;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gb_Reg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_ComYear;
        private System.Windows.Forms.GroupBox gb_Com;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoilView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}