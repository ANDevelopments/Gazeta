using RepairAPPAPI.Data.Logic;
using RepairAPPAPI.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            var Telephone = textBox_Telephone;

            using ClientLogic CL = new ClientLogic();
            IEnumerable<ClientModel> list = await CL.GetAll();
            var container = list.FirstOrDefault(c => c.FullName == FullName);
            if (container != null)
            {
                MessageBox.Show("Такой клиент уже существует", "Запись не может быть создана!");
            }
            else
            {
                await CL.Create(new ClientModel()
                {
                    FullName = FullName,
                    Adress = Adress,
                    Telephone = Telephone.Text
                });
                MessageBox.Show("Запись создана успешно", "Сохранение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if(textBox_FullName.Text.Length > 0 &&
               textBox_Adress.Text.Length > 0 &&
               textBox_Telephone.MaskFull)
            {
                CreateClient();
            }
            else
            {
                MessageBox.Show("Запись не может быть сохранена, т.к. отсутствуют значения в некоторых полях",
                   "ОШИБКА!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_FullName.Text = "";
            textBox_Adress.Text = "";
            textBox_Telephone.Text = "";
        }
    }
}
