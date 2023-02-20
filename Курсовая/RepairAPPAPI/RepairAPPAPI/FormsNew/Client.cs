using RepairAPPAPI.Data.Logic;
using RepairAPPAPI.Data.Models;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RepairAPPAPI
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private async void CreateClient()
        {
            var FullName = textBox_FullName.Text;
            var Adress = textBox_Adress.Text;
            var Telephone = textBox_Telephone.Text;

            if (FullName.Equals("") &&
               Adress.Equals("") &&
               Telephone.Equals(""))
            {
                MessageBox.Show("Запись не может быть сохранена, т.к. отсутствуют значения в некоторых полях",
                   "ОШИБКА!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);

                this.Close();
            }
            else
            {
                using ClientLogic CL = new ClientLogic();
                await CL.Create(new ClientModel()
                {
                    FullName = FullName, Adress = Adress, Telephone = Telephone
                });
                MessageBox.Show("Запись создана успешно", "Сохранение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            CreateClient();
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_FullName.Text = "";
            textBox_Adress.Text = "";
            textBox_Telephone.Text = "";
        }
    }
}
