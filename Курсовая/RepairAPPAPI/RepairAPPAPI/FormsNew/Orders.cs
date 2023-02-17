using RepairAPPAPI.Data.Logic;
using RepairAPPAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RepairAPPAPI
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private async void CreateOrders()
        {
            var ClientID = Convert.ToInt32(textBox_ClientID.Text);
            var ServiceName = textBox_ServiceName.Text;
            var Descript = textBox_Description.Text;
            var OrderDate = DateTime.Now;
            var Execution = Convert.ToDateTime(textBox_Execution.Text);
            var Progress = textBox_Progress.Text;

            if (ClientID.Equals("") &&
               ServiceName.Equals("") &&
               Descript.Equals("") &&
               Execution.Equals("") &&
               Progress.Equals(""))
            {
                MessageBox.Show("Запись не может быть сохранена, т.к. отсутствуют значения в некоторых полях",
                    "ОШИБКА!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.Close();
            }
            else
            {
                using OrdersLogic OL = new OrdersLogic();
                await OL.Create(new OrdersModel()
                {
                    ClientID = ClientID,
                    ServiceName = ServiceName,
                    Descript = Descript,
                    OrderDate = OrderDate,
                    Execution = Execution,
                    Progress = Progress
                });
                MessageBox.Show("Запись создана успешно", "Сохранение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
            }
        }

        private async void GetClients()
        {
            ClientLogic CL = new ClientLogic();
            IEnumerable<ClientModel> list = await CL.GetAll();
            foreach (var obj in list)
            {
                textBox_ClientID.Items.Add(obj.ID);
            }
        }

        private async void GetServs()
        {
            ServLogic SL = new ServLogic();
            IEnumerable<ServModel> list = await SL.GetAll();
            foreach (var obj in list)
            {
                textBox_ServiceName.Items.Add(obj.ServiceName);
            }
        }

        string[] Progress = { "В процессе", "Выполнено" };

        private void button_Save_Click(object sender, EventArgs e)
        {
            CreateOrders();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_ClientID.Text = "";
            textBox_ServiceName.Text = "";
            textBox_Description.Text = "";
            textBox_Execution.Text = "";
            textBox_Progress.Text = "";
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            GetClients();
            GetServs();
            textBox_Progress.Items.AddRange(Progress);
        }
    }
}
