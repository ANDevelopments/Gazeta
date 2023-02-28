using RepairAPPAPI.Data.Logic;
using RepairAPPAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RepairAPPAPI
{
    public partial class Orders : Form
    {
        int _ClientID;
        public Orders()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textBox_ClientName.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_ServiceName.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_Progress.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void CreateOrders()
        {
            var ClientID = _ClientID;
            var ServiceName = textBox_ServiceName;
            var Descript = textBox_Description.Text;
            var OrderDate = DateTime.Now;
            var Execution = textBox_Execution;
            var Progress = textBox_Progress;

            if (ClientID > 0 &&
                ServiceName.SelectedIndex > -1 &&
                !Descript.Equals("") &&
                Execution.MaskFull &&
                Progress.SelectedIndex > -1)
            {
                using OrdersLogic OL = new OrdersLogic();
                await OL.Create(new OrdersModel()
                {
                    ClientID = ClientID,
                    ServiceName = ServiceName.Text,
                    Descript = Descript,
                    OrderDate = OrderDate,
                    Execution = Convert.ToDateTime(Execution.Text),
                    Progress = Progress.Text
                });
                MessageBox.Show("Запись создана успешно", "Сохранение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Запись не может быть сохранена, т.к. отсутствуют значения в некоторых полях",
                    "ОШИБКА!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private async void GetClients()
        {
            ClientLogic CL = new ClientLogic();
            IEnumerable<ClientModel> list = await CL.GetAll();
            foreach (var obj in list)
            {
                textBox_ClientName.Items.Add(obj.FullName);
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
            textBox_ClientName.Text = "";
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

        private async void textBox_ClientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ClientName = textBox_ClientName.Text;
            ClientLogic CL = new ClientLogic();
            IEnumerable<ClientModel> list = await CL.GetAll();
            var container = list.FirstOrDefault(c => c.FullName == ClientName);
            _ClientID = container.ID;
        }
    }
}
