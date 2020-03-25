namespace System_Login_App
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextUserName = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.PnlStatus = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicMinus = new System.Windows.Forms.PictureBox();
            this.PicClose = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.PnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(27, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(31, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "LOGIN PAGE";
            // 
            // TextUserName
            // 
            this.TextUserName.Location = new System.Drawing.Point(107, 82);
            this.TextUserName.Name = "TextUserName";
            this.TextUserName.Size = new System.Drawing.Size(133, 23);
            this.TextUserName.TabIndex = 3;
            this.TextUserName.TextChanged += new System.EventHandler(this.TextUserName_TextChanged);
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(107, 135);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '*';
            this.TextPassword.Size = new System.Drawing.Size(110, 23);
            this.TextPassword.TabIndex = 4;
            this.TextPassword.TextChanged += new System.EventHandler(this.TextPassword_TextChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Location = new System.Drawing.Point(34, 201);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(206, 28);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(8, 7);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(46, 17);
            this.LblStatus.TabIndex = 8;
            this.LblStatus.Text = "Status";
            // 
            // PnlStatus
            // 
            this.PnlStatus.BackColor = System.Drawing.Color.Transparent;
            this.PnlStatus.Controls.Add(this.LblStatus);
            this.PnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlStatus.Location = new System.Drawing.Point(0, 264);
            this.PnlStatus.Name = "PnlStatus";
            this.PnlStatus.Size = new System.Drawing.Size(267, 30);
            this.PnlStatus.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::System_Login_App.Properties.Resources._03_Eye;
            this.pictureBox1.Location = new System.Drawing.Point(217, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave_1);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover_1);
            // 
            // PicMinus
            // 
            this.PicMinus.BackColor = System.Drawing.Color.Transparent;
            this.PicMinus.Image = global::System_Login_App.Properties.Resources._02_Minus;
            this.PicMinus.Location = new System.Drawing.Point(205, 5);
            this.PicMinus.Name = "PicMinus";
            this.PicMinus.Size = new System.Drawing.Size(25, 25);
            this.PicMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMinus.TabIndex = 7;
            this.PicMinus.TabStop = false;
            this.PicMinus.Click += new System.EventHandler(this.pictureBox2_Click);
            this.PicMinus.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.PicMinus.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // PicClose
            // 
            this.PicClose.BackColor = System.Drawing.Color.Transparent;
            this.PicClose.Image = global::System_Login_App.Properties.Resources.close_black_2048x2048;
            this.PicClose.Location = new System.Drawing.Point(236, 5);
            this.PicClose.Name = "PicClose";
            this.PicClose.Size = new System.Drawing.Size(25, 25);
            this.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicClose.TabIndex = 6;
            this.PicClose.TabStop = false;
            this.PicClose.Click += new System.EventHandler(this.pictureBox1_Click);
            this.PicClose.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.PicClose.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(107, 164);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::System_Login_App.Properties.Resources._04_LoginBCK;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(267, 294);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PnlStatus);
            this.Controls.Add(this.PicMinus);
            this.Controls.Add(this.PicClose);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
           
            this.PnlStatus.ResumeLayout(false);
            this.PnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextUserName;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.PictureBox PicClose;
        private System.Windows.Forms.PictureBox PicMinus;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Panel PnlStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

