using RepairAPPAPI.Data.Logic;
using RepairAPPAPI.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            var Price = textBox_Price.Text;

            if (ServiceName.Length > 0 && Price.Length > 0)
            {
                using ServLogic SL = new ServLogic();
                IEnumerable<ServModel> list = await SL.GetAll();
                var container = list.FirstOrDefault(c => c.ServiceName == ServiceName);
                if (container != null)
                {
                    MessageBox.Show("Услуга с таким названием уже существует", "Запись не может быть создана!");
                }
                else
                {
                    await SL.Create(new ServModel()
                    {
                        ServiceName = ServiceName,
                        Price = Convert.ToDecimal(Price)
                    });
                    MessageBox.Show("Запись создана успешно", "Сохранение",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Запись не может быть сохранена, т.к. отсутствуют значения в некоторых полях",
                   "ОШИБКА!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
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

        private void textBox_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
