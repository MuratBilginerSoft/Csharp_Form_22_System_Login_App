using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Login_App
{
    public partial class Form1 : Form
    {
        #region Parameters

        string SUserName = "Industryolog";
        string SPassword = "12345";

        string UUserName, UPassword;

        #endregion

        #region Definitions

        Business BL = new Business();

        AdminPage ADF = new AdminPage();

        #endregion

        #region Methods

        // Sınıfa Taşındı O yüzden Kapatıldı. MB ...

        //public void StatusControl(Panel Pnl, Label Lbl)
        //{
        //    Pnl.BackColor = Color.Transparent;
        //    Lbl.ForeColor = Color.Black;
        //    Lbl.Text = "Status";
        //}

        #endregion

        #region Main

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Picturebox

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            PicClose.BackColor = Color.Red;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            PicClose.BackColor = Color.Transparent;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            PicMinus.BackColor = Color.Fuchsia;
        }

        private void pictureBox1_MouseHover_1(object sender, EventArgs e)
        {
            TextPassword.PasswordChar = '\0';
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            TextPassword.PasswordChar = '*';
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            PicMinus.BackColor = Color.Transparent;
        }

        #endregion

        #region Button

        private void button1_Click(object sender, EventArgs e)
        {
            UUserName = TextUserName.Text;
            UPassword = TextPassword.Text;

            if (SUserName==UUserName && SPassword==UPassword)
            {
                //this.Close();

                this.Hide();
                ADF.ShowDialog();
                this.Show();
            }

            else
            {
                PnlStatus.BackColor = Color.Red;
                LblStatus.ForeColor = Color.White;
                LblStatus.Text = "Hatalı Giriş Yaptınız";
            }
        }

        #endregion

        #region Textbox

        private void TextUserName_TextChanged(object sender, EventArgs e)
        {
            
            BL.StatusControl(PnlStatus, LblStatus);

            // Bu Kodlama Sınıf Olarak Yapılmış OLup Kapatılmıştır MB 28.05.2018

            //StatusControl(PnlStatus, LblStatus);

            // Aşağıdaki Kodlar Metod Haliyle Yazıldığı İçin Kapatılmıştır. Murat Bilginer 28.05.2018

            //PnlStatus.BackColor = Color.Transparent;
            //LblStatus.ForeColor = Color.Black;
            //LblStatus.Text = "Status";
        }

        private void TextPassword_TextChanged(object sender, EventArgs e)
        {
            BL.StatusControl(PnlStatus, LblStatus);

            // Bu Kodlama Sınıf Olarak Yapılmış OLup Kapatılmıştır MB 28.05.2018

            //StatusControl(PnlStatus, LblStatus);

            // Aşağıdaki Kodlar Metod Haliyle Yazıldığı İçin Kapatılmıştır. Murat Bilginer 28.05.2018

            //PnlStatus.BackColor = Color.Transparent;
            //LblStatus.ForeColor = Color.Black;
            //LblStatus.Text = "Status";
        }

        #endregion

        #region CHeckBox

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                TextPassword.PasswordChar = '\0';
                checkBox1.Text = "Şifreyi Kapat";
            }

            else
            {
                TextPassword.PasswordChar = '*';
                checkBox1.Text = "Şifreyi Göster";
            }
        }

        #endregion

    }
}
