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
using RepairAPPAPI.Data.Logic;
using RepairAPPAPI.Data.Models;

namespace RepairAPPAPI
{
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void sign_up_Load(object sender, EventArgs e)
        {
            textBox_login2.MaxLength = 50;
            textBox_password2.MaxLength = 50;
        }

        private async void buttonEnter2_Click(object sender, EventArgs e)
        {
            var Login = textBox_login2.Text;
            var Password = textBox_password2.Text;

            if (Login.Equals("") &&
                Password.Equals(""))
            {
                MessageBox.Show("Запись не может быть сохранена, т.к. отсутствуют значения в некоторых полях",
                   "ОШИБКА!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);

                this.Close();
            }
            else
            {
                using RegisterLogic RL = new RegisterLogic();
                await RL.Create(new RegisterModel()
                {
                    UserLogin = Login,
                    UserPassword = Password
                });
                MessageBox.Show("Вы успешно зарегистрировались", "Сохранение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                log_in loginform = new log_in();
                loginform.Show();
                this.Close();
            }
        }
    }
}
