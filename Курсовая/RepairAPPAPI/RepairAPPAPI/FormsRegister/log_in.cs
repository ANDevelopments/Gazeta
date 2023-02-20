using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RepairAPPAPI;
using RepairAPPAPI.Data.Logic;
using RepairAPPAPI.Data.Models;
using System.Threading;

namespace RepairAPPAPI
{
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void log_in_Load(object sender, EventArgs e)
        {
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
            textBox_password.PasswordChar = '*';
        }
        private void signuplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_up formsign = new sign_up();
            formsign.Show();
            this.Hide();
        }
        private async void buttonEnter_Click(object sender, EventArgs e)
        {
            var UserLogin = textBox_login.Text;
            var UserPassword = textBox_password.Text;
            RegisterLogic RL = new RegisterLogic();
            IEnumerable<RegisterModel> list = await RL.GetAll();
            var LoginContainer = list.FirstOrDefault(c => c.UserLogin == UserLogin);
            var PasswordContainer = list.FirstOrDefault(c => c.UserPassword == UserPassword);
            if (LoginContainer != null && PasswordContainer != null)
            {
                MessageBox.Show("Вы вошли успешно");
                FormMain formMain = new FormMain();
                this.Hide();
                formMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Введен неправильный логин или пароль");
            }
        }
    }
}