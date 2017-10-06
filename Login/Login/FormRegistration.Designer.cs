namespace Login
{
    partial class FormRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.gpb_Security = new System.Windows.Forms.GroupBox();
            this.gpb_Password = new System.Windows.Forms.GroupBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.gpb_Username = new System.Windows.Forms.GroupBox();
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.gpb_PersonalInfo = new System.Windows.Forms.GroupBox();
            this.gpb_City = new System.Windows.Forms.GroupBox();
            this.txb_Telephone = new System.Windows.Forms.TextBox();
            this.gpb_Mail = new System.Windows.Forms.GroupBox();
            this.txb_Mail = new System.Windows.Forms.TextBox();
            this.gpb_Family = new System.Windows.Forms.GroupBox();
            this.txb_Family = new System.Windows.Forms.TextBox();
            this.gpb_Name = new System.Windows.Forms.GroupBox();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.btn_Registration = new System.Windows.Forms.Button();
            this.gpb_Security.SuspendLayout();
            this.gpb_Password.SuspendLayout();
            this.gpb_Username.SuspendLayout();
            this.gpb_PersonalInfo.SuspendLayout();
            this.gpb_City.SuspendLayout();
            this.gpb_Mail.SuspendLayout();
            this.gpb_Family.SuspendLayout();
            this.gpb_Name.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_Security
            // 
            this.gpb_Security.Controls.Add(this.gpb_Password);
            this.gpb_Security.Controls.Add(this.gpb_Username);
            this.gpb_Security.Location = new System.Drawing.Point(12, 12);
            this.gpb_Security.Name = "gpb_Security";
            this.gpb_Security.Size = new System.Drawing.Size(260, 147);
            this.gpb_Security.TabIndex = 0;
            this.gpb_Security.TabStop = false;
            this.gpb_Security.Text = "Безопасность";
            // 
            // gpb_Password
            // 
            this.gpb_Password.Controls.Add(this.txb_Password);
            this.gpb_Password.Location = new System.Drawing.Point(6, 82);
            this.gpb_Password.Name = "gpb_Password";
            this.gpb_Password.Size = new System.Drawing.Size(248, 55);
            this.gpb_Password.TabIndex = 1;
            this.gpb_Password.TabStop = false;
            this.gpb_Password.Text = "Пароль";
            // 
            // txb_Password
            // 
            this.txb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_Password.Location = new System.Drawing.Point(6, 19);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(235, 26);
            this.txb_Password.TabIndex = 0;
            // 
            // gpb_Username
            // 
            this.gpb_Username.Controls.Add(this.txb_UserName);
            this.gpb_Username.Location = new System.Drawing.Point(6, 19);
            this.gpb_Username.Name = "gpb_Username";
            this.gpb_Username.Size = new System.Drawing.Size(248, 57);
            this.gpb_Username.TabIndex = 0;
            this.gpb_Username.TabStop = false;
            this.gpb_Username.Text = "Имя пользователя";
            // 
            // txb_UserName
            // 
            this.txb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_UserName.Location = new System.Drawing.Point(6, 19);
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(236, 26);
            this.txb_UserName.TabIndex = 0;
            // 
            // gpb_PersonalInfo
            // 
            this.gpb_PersonalInfo.Controls.Add(this.gpb_City);
            this.gpb_PersonalInfo.Controls.Add(this.gpb_Mail);
            this.gpb_PersonalInfo.Controls.Add(this.gpb_Family);
            this.gpb_PersonalInfo.Controls.Add(this.gpb_Name);
            this.gpb_PersonalInfo.Location = new System.Drawing.Point(12, 165);
            this.gpb_PersonalInfo.Name = "gpb_PersonalInfo";
            this.gpb_PersonalInfo.Size = new System.Drawing.Size(260, 269);
            this.gpb_PersonalInfo.TabIndex = 1;
            this.gpb_PersonalInfo.TabStop = false;
            this.gpb_PersonalInfo.Text = "Персональная информация";
            // 
            // gpb_City
            // 
            this.gpb_City.Controls.Add(this.txb_Telephone);
            this.gpb_City.Location = new System.Drawing.Point(6, 206);
            this.gpb_City.Name = "gpb_City";
            this.gpb_City.Size = new System.Drawing.Size(248, 55);
            this.gpb_City.TabIndex = 5;
            this.gpb_City.TabStop = false;
            this.gpb_City.Text = "Телефон";
            // 
            // txb_Telephone
            // 
            this.txb_Telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_Telephone.Location = new System.Drawing.Point(6, 19);
            this.txb_Telephone.Name = "txb_Telephone";
            this.txb_Telephone.Size = new System.Drawing.Size(235, 26);
            this.txb_Telephone.TabIndex = 0;
            this.txb_Telephone.TextChanged += new System.EventHandler(this.txb_City_TextChanged);
            // 
            // gpb_Mail
            // 
            this.gpb_Mail.Controls.Add(this.txb_Mail);
            this.gpb_Mail.Location = new System.Drawing.Point(6, 143);
            this.gpb_Mail.Name = "gpb_Mail";
            this.gpb_Mail.Size = new System.Drawing.Size(248, 57);
            this.gpb_Mail.TabIndex = 4;
            this.gpb_Mail.TabStop = false;
            this.gpb_Mail.Text = "Электронная почта";
            // 
            // txb_Mail
            // 
            this.txb_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_Mail.Location = new System.Drawing.Point(6, 19);
            this.txb_Mail.Name = "txb_Mail";
            this.txb_Mail.Size = new System.Drawing.Size(236, 26);
            this.txb_Mail.TabIndex = 0;
            // 
            // gpb_Family
            // 
            this.gpb_Family.Controls.Add(this.txb_Family);
            this.gpb_Family.Location = new System.Drawing.Point(6, 82);
            this.gpb_Family.Name = "gpb_Family";
            this.gpb_Family.Size = new System.Drawing.Size(248, 55);
            this.gpb_Family.TabIndex = 3;
            this.gpb_Family.TabStop = false;
            this.gpb_Family.Text = "Фамилия";
            // 
            // txb_Family
            // 
            this.txb_Family.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_Family.Location = new System.Drawing.Point(6, 19);
            this.txb_Family.Name = "txb_Family";
            this.txb_Family.Size = new System.Drawing.Size(235, 26);
            this.txb_Family.TabIndex = 0;
            // 
            // gpb_Name
            // 
            this.gpb_Name.Controls.Add(this.txb_Name);
            this.gpb_Name.Location = new System.Drawing.Point(6, 19);
            this.gpb_Name.Name = "gpb_Name";
            this.gpb_Name.Size = new System.Drawing.Size(248, 57);
            this.gpb_Name.TabIndex = 2;
            this.gpb_Name.TabStop = false;
            this.gpb_Name.Text = "Имя ";
            // 
            // txb_Name
            // 
            this.txb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_Name.Location = new System.Drawing.Point(6, 19);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(236, 26);
            this.txb_Name.TabIndex = 0;
            // 
            // btn_Registration
            // 
            this.btn_Registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registration.Location = new System.Drawing.Point(77, 440);
            this.btn_Registration.Name = "btn_Registration";
            this.btn_Registration.Size = new System.Drawing.Size(125, 40);
            this.btn_Registration.TabIndex = 4;
            this.btn_Registration.Text = "Регистрация";
            this.btn_Registration.UseVisualStyleBackColor = true;
            this.btn_Registration.Click += new System.EventHandler(this.btn_Registration_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 489);
            this.Controls.Add(this.btn_Registration);
            this.Controls.Add(this.gpb_PersonalInfo);
            this.Controls.Add(this.gpb_Security);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistration";
            this.Text = "Регистрация пользователя";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            this.gpb_Security.ResumeLayout(false);
            this.gpb_Password.ResumeLayout(false);
            this.gpb_Password.PerformLayout();
            this.gpb_Username.ResumeLayout(false);
            this.gpb_Username.PerformLayout();
            this.gpb_PersonalInfo.ResumeLayout(false);
            this.gpb_City.ResumeLayout(false);
            this.gpb_City.PerformLayout();
            this.gpb_Mail.ResumeLayout(false);
            this.gpb_Mail.PerformLayout();
            this.gpb_Family.ResumeLayout(false);
            this.gpb_Family.PerformLayout();
            this.gpb_Name.ResumeLayout(false);
            this.gpb_Name.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_Security;
        private System.Windows.Forms.GroupBox gpb_PersonalInfo;
        private System.Windows.Forms.GroupBox gpb_Password;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.GroupBox gpb_Username;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.GroupBox gpb_City;
        private System.Windows.Forms.TextBox txb_Telephone;
        private System.Windows.Forms.GroupBox gpb_Mail;
        private System.Windows.Forms.TextBox txb_Mail;
        private System.Windows.Forms.GroupBox gpb_Family;
        private System.Windows.Forms.TextBox txb_Family;
        private System.Windows.Forms.GroupBox gpb_Name;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Button btn_Registration;
    }
}