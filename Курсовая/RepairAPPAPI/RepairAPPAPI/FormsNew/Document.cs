using RepairAPPAPI.Data.Logic;
using RepairAPPAPI.Data.Models;
using System;
using System.Windows.Forms;

namespace RepairAPPAPI
{
    public partial class Document : Form
    {
        public Document()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private async void CreateDocument()
        {
            var ClientID = Convert.ToInt32(textBox_ClientID.Text);
            var ClientName = textBox_ClientName.Text;
            var OrderID = Convert.ToInt32(textBox_OrderID.Text);
            var Total = Convert.ToDecimal(textBox_Total.Text);
            var DocumentDate = DateTime.Now;

            if (ClientID.Equals("") &&
               ClientName.Equals("") &&
               OrderID.Equals("") &&
               Total.Equals(""))
            {
                MessageBox.Show("Запись не может быть сохранена, т.к. отсутствуют значения в некоторых полях",
                   "ОШИБКА!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);

                this.Close();
            }
            else
            {
                using DocumentLogic DL = new DocumentLogic();
                await DL.Create(new DocumentModel()
                {
                    ClientID = ClientID,
                    ClientName = ClientName,
                    OrderID= OrderID,
                    Total = Total,
                    DocumentDate = DocumentDate
                });
                MessageBox.Show("Запись создана успешно", "Сохранение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            CreateDocument();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_ClientID.Text = "";
            textBox_ClientName.Text = "";
            textBox_OrderID.Text = "";
            textBox_Total.Text = "";
        }
    }
}
