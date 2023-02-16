using RepairAPPAPI.Data.Logic;
using RepairAPPAPI.Data.Models;
using System;
using System.Windows.Forms;

namespace RepairAPPAPI
{
    public partial class Serv : Form
    {
        public Serv()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private async void CreateServs()
        {
            var ServiceName = textBox_ServiceName.Text;
            var Price = Convert.ToDecimal(textBox_Price.Text);

            if (ServiceName.Equals("") && Price.Equals(""))
            {
                MessageBox.Show("Запись не может быть сохранена, т.к. отсутствуют значения в некоторых полях",
                   "ОШИБКА!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                using ServLogic SL = new ServLogic();
                await SL.Create(new ServModel()
                {
                    ServiceName = ServiceName,
                    Price = Price
                });
                MessageBox.Show("Запись создана успешно", "Сохранение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            CreateServs();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_ServiceName.Text = "";
            textBox_Price.Text = "";
        }
    }
}
