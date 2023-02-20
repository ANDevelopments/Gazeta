using RepairAPPAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RepairAPPAPI.Data.Logic;

namespace RepairAPPAPI
{
    public partial class FormMain : Form
    {
        int _ClientID;
        int SelectedRow;
        string[] ProgressList = { "В процессе", "Выполнено" };
        public FormMain()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            GetOrders();
            GetClients();
            GetServs();
            GetDocuments();
            Order_textBox_Progress.Items.AddRange(ProgressList);
            GetServsInOrders();
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти? Несохраненные данные будут потеряны.", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        //GET
        private async void GetOrders()
        {
            OrdersLogic OL = new OrdersLogic();
            IEnumerable<OrdersModel> list = await OL.GetAll();
            Orders_dataGridView.DataSource = null;
            if (list != null)
            {
                Orders_dataGridView.AutoGenerateColumns = false;
                Orders_dataGridView.Columns[0].DataPropertyName = "ID";
                Orders_dataGridView.Columns[1].DataPropertyName = "ClientID";
                Orders_dataGridView.Columns[2].DataPropertyName = "ServiceName";
                Orders_dataGridView.Columns[3].DataPropertyName = "Descript";
                Orders_dataGridView.Columns[4].DataPropertyName = "OrderDate";
                Orders_dataGridView.Columns[5].DataPropertyName = "Execution";
                Orders_dataGridView.Columns[6].DataPropertyName = "Progress";
                Orders_dataGridView.DataSource = list;
            }
        }
        private async void GetClients()
        {
            ClientLogic CL = new ClientLogic();
            IEnumerable<ClientModel> list = await CL.GetAll();
            Client_dataGridView.DataSource = null;
            if (list != null)
            {
                Client_dataGridView.AutoGenerateColumns = false;
                Client_dataGridView.Columns[0].DataPropertyName = "ID";
                Client_dataGridView.Columns[1].DataPropertyName = "FullName";
                Client_dataGridView.Columns[2].DataPropertyName = "Adress";
                Client_dataGridView.Columns[3].DataPropertyName = "Telephone";
                Client_dataGridView.DataSource = list;
            }
        }
        private async void GetServs()
        {
            ServLogic SL = new ServLogic();
            IEnumerable<ServModel> list = await SL.GetAll();
            Serv_dataGridView.DataSource = null;
            if(list != null)
            {
                Serv_dataGridView.AutoGenerateColumns = false;
                Serv_dataGridView.Columns[0].DataPropertyName = "ServiceName";
                Serv_dataGridView.Columns[1].DataPropertyName = "Price";
                Serv_dataGridView.Columns[2].DataPropertyName = "ID";
                Serv_dataGridView.DataSource = list;
            }
        }
        private async void GetServsInOrders()
        {
            ServLogic SL = new ServLogic();
            IEnumerable<ServModel> list = await SL.GetAll();
            foreach (var obj in list)
            {
                Order_textBox_ServiceName.Items.Add(obj.ServiceName);
            }
        }
        private async void GetDocuments()
        {
            DocumentLogic DL = new DocumentLogic();
            IEnumerable<DocumentModel> list = await DL.GetAll();
            Document_dataGridView.DataSource = null;
            if(list != null) 
            {
                Document_dataGridView.AutoGenerateColumns = false;
                Document_dataGridView.Columns[0].DataPropertyName = "ID";
                Document_dataGridView.Columns[1].DataPropertyName = "ClientID";
                Document_dataGridView.Columns[2].DataPropertyName = "ClientName";
                Document_dataGridView.Columns[3].DataPropertyName = "OrderID";
                Document_dataGridView.Columns[4].DataPropertyName = "Total";
                Document_dataGridView.Columns[5].DataPropertyName = "DocumentDate";
                Document_dataGridView.DataSource = list;    
            }
        }

        //DELETE
        private async void DeleteOrders()
        {
                if (MessageBox.Show("Удалить запись?", "Сообщение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var row = Orders_dataGridView.Rows[SelectedRow].DataBoundItem as OrdersModel;
                    using OrdersLogic OL = new OrdersLogic();
                    await OL.Delete(row.ID);
                }
        }
        private async void DeleteClients()
        {  
                if (MessageBox.Show("Удалить запись?", "Сообщение",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var row = Client_dataGridView.Rows[SelectedRow].DataBoundItem as ClientModel;
                    using ClientLogic CL = new ClientLogic();
                    await CL.Delete(row.ID);
                }
          
        }
        private async void DeleteServs()
        {
                if (MessageBox.Show("Удалить запись?", "Сообщение",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var row = Serv_dataGridView.Rows[SelectedRow].DataBoundItem as ServModel;
                    using ServLogic SL = new ServLogic();
                    await SL.Delete(row.ID);
                }
            
        }
        private async void DeleteDocuments()
        {   
            if (MessageBox.Show("Удалить запись?", "Сообщение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var row = Document_dataGridView.Rows[SelectedRow].DataBoundItem as DocumentModel;
                using DocumentLogic DL = new DocumentLogic();
                await DL.Delete(row.ID);
            }
        }

        //UPDATE
        private async void UpdateOrders()
        {
            var ID = Convert.ToInt32(Order_textBox_ID.Text);
            var ClientID = _ClientID;
            var ServiceName = Order_textBox_ServiceName.Text;
            var Descript = Order_textBox_Descript.Text;
            var OrderDate = Convert.ToDateTime(Order_textBox_OrderDate.Text);
            var Execution = Convert.ToDateTime(Order_textBox_Execution.Text);
            var Progress = Order_textBox_Progress.Text;

            if (ClientID.Equals("") &&
               ServiceName.Equals("") &&
               Descript.Equals("") &&
               Execution.Equals("") &&
               Progress.Equals(""))
            {
                MessageBox.Show("Запись не может быть сохранена, т.к. отсутствуют значения в некоторых полях",
                "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using OrdersLogic OL = new OrdersLogic();
                await OL.Update(ID, new OrdersModel()
                {
                    ID = ID, ClientID = ClientID,
                    ServiceName = ServiceName, Descript = Descript, OrderDate = OrderDate,
                    Execution = Execution, Progress = Progress
                });
            }
        }
        private async void UpdateClients()
        {
            var ID = Convert.ToInt32(Client_textBox_ID.Text);
            var FullName = Client_textBox_FullName.Text;
            var Adress = Client_textBox_Adress.Text;
            var Telephone = Client_textBox_Telephone.Text;

            if (FullName.Equals("") &&
               Adress.Equals("") &&
               Telephone.Equals(""))
            {
                MessageBox.Show("Запись не может быть сохранена, т.к. отсутствуют значения в некоторых полях",
                "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using ClientLogic CL = new ClientLogic();
                await CL.Update(ID, new ClientModel()
                {
                    ID = ID, FullName = FullName,
                    Adress = Adress, Telephone= Telephone
                });
            }
        }
        private async void UpdateServs()
        {
            var ServiceName = Serv_textBox_ServiceName.Text;
            var Price = Convert.ToDecimal(Serv_textBox_Price.Text);
            var ID = Convert.ToInt32(Serv_textBox_ID.Text);

            if (Price.Equals(""))
            {
                MessageBox.Show("Запись не может быть сохранена, т.к. отсутствуют значения в некоторых полях",
                "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using ServLogic SL = new ServLogic();
                await SL.Update(ID, new ServModel()
                {
                    ServiceName = ServiceName, Price = Price, ID = ID
                });
            }
        }
        private async void UpdateDocuments()
        {
            var ID = Convert.ToInt32(Document_textBox_ID.Text);
            var ClientID = Convert.ToInt32(Document_textBox_ClientID.Text);
            var ClientName = Document_textBox_ClientName.Text;
            var OrderID = Convert.ToInt32(Document_textBox_OrderID.Text);
            var Total = Convert.ToDecimal(Document_textBox_Total.Text);
            var DocumentDate = Convert.ToDateTime(Document_textBox_DocumentDate.Text);

            if (ClientID.Equals("") &&
                    ClientName.Equals("") &&
                    OrderID.Equals("") &&
                    Total.Equals(""))
            {
                MessageBox.Show("Запись не может быть сохранена, т.к. отсутствуют значения в некоторых полях",
                "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using DocumentLogic DL = new DocumentLogic();
                await DL.Update(ID, new DocumentModel()
                {
                    ID = ID, ClientID = ClientID, ClientName = ClientName,
                    OrderID = OrderID, Total = Total, DocumentDate = DocumentDate
                });
            }
        }

        //Поиск в DataGridView
        private void SearchInDataGrid(DataGridView dataGrid, System.Windows.Forms.TextBox textBox)
        {
            string Search = textBox.Text;
            if (Search.Length > 0)
            {
                for (int i = 0; i < dataGrid.RowCount; i++)
                {
                    dataGrid.Rows[i].Selected = false;
                    for (int j = 0; j < dataGrid.ColumnCount; j++)
                    {
                        if (dataGrid.Rows[i].Cells[j].Value != null)
                        {
                            if (dataGrid.Rows[i].Cells[j].Value.ToString().Contains(Search))
                            {
                                dataGrid.Rows[i].Selected = true;
                                break;
                            }
                        }
                    }
                }
            }
        }

        //Кнопки "Обновить"
        private void Order_button_Refresh_Click(object sender, EventArgs e)
        {
            GetOrders();
        }
        private void Client_button_Refresh_Click(object sender, EventArgs e)
        {
            GetClients();
        }
        private void Serv_button_Refresh_Click(object sender, EventArgs e)
        {
            GetServs();
        }
        private void Document_button_Refresh_Click(object sender, EventArgs e)
        {
            GetDocuments();
        }

        //Кнопки "Очистить"
        private void Order_button_Clear_Click(object sender, EventArgs e)
        {
            Order_textBox_ID.Text = "";
            Order_textBox_ClientName.Text = "";
            Order_textBox_ServiceName.Text = "";
            Order_textBox_Descript.Text = "";
            Order_textBox_OrderDate.Text = "";
            Order_textBox_Execution.Text = "";
            Order_textBox_Progress.Text = "";
        }
        private void Client_button_Clear_Click(object sender, EventArgs e)
        {
            Client_textBox_ID.Text = "";
            Client_textBox_FullName.Text = "";
            Client_textBox_Adress.Text = "";
            Client_textBox_Telephone.Text = "";
        }
        private void Serv_button_Clear_Click(object sender, EventArgs e)
        {
            Serv_textBox_ServiceName.Text = "";
            Serv_textBox_Price.Text = "";
            Serv_textBox_ID.Text = "";
        }
        private void Document_button_Clear_Click(object sender, EventArgs e)
        {
            Document_textBox_ID.Text = "";
            Document_textBox_ClientID.Text = "";
            Document_textBox_ClientName.Text = "";
            Document_textBox_OrderID.Text = "";
            Document_textBox_Total.Text = "";
            Document_textBox_DocumentDate.Text = "";
        }

        //Нажатие по ячейке
        private async void Orders_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedRow = e.RowIndex;
                DataGridViewRow row = Orders_dataGridView.Rows[SelectedRow];
                int clientID = Convert.ToInt32(row.Cells[1].Value.ToString());
                ClientLogic CL = new ClientLogic();
                var ClientItem = await CL.Get(clientID);
                if (e.RowIndex >= 0)
                {
                    Order_textBox_ID.Text = row.Cells[0].Value.ToString();
                    Order_textBox_ClientName.Text = ClientItem.FullName;
                    _ClientID = clientID;
                    Order_textBox_ServiceName.Text = row.Cells[2].Value.ToString();
                    Order_textBox_Descript.Text = row.Cells[3].Value.ToString();
                    Order_textBox_OrderDate.Text = row.Cells[4].Value.ToString();
                    Order_textBox_Execution.Text = row.Cells[5].Value.ToString();
                    Order_textBox_Progress.Text = row.Cells[6].Value.ToString();
                }
            }
        }
        private void Client_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedRow = e.RowIndex;
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = Client_dataGridView.Rows[SelectedRow];
                    Client_textBox_ID.Text = row.Cells[0].Value.ToString();
                    Client_textBox_FullName.Text = row.Cells[1].Value.ToString();
                    Client_textBox_Adress.Text = row.Cells[2].Value.ToString();
                    Client_textBox_Telephone.Text = row.Cells[3].Value.ToString();
                }
            }
        }
        private void Serv_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedRow = e.RowIndex;
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = Serv_dataGridView.Rows[SelectedRow];
                    Serv_textBox_ServiceName.Text = row.Cells[0].Value.ToString();
                    Serv_textBox_Price.Text = row.Cells[1].Value.ToString();
                    Serv_textBox_ID.Text = row.Cells[2].Value.ToString();
                }
            }
        }
        private void Document_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedRow = e.RowIndex;
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = Document_dataGridView.Rows[SelectedRow];
                    Document_textBox_ID.Text = row.Cells[0].Value.ToString();
                    Document_textBox_ClientID.Text = row.Cells[1].Value.ToString();
                    Document_textBox_ClientName.Text = row.Cells[2].Value.ToString();
                    Document_textBox_OrderID.Text = row.Cells[3].Value.ToString();
                    Document_textBox_Total.Text = row.Cells[4].Value.ToString();
                    Document_textBox_DocumentDate.Text = row.Cells[5].Value.ToString();
                }
            }
        }

        //Кнопки "Изменить"
        private void Order_button_Alter_Click(object sender, EventArgs e)
        {
            if (Orders_dataGridView.Rows.Count > 0)
            {
                UpdateOrders();
            }
        }
        private void Client_button_Alter_Click(object sender, EventArgs e)
        {
            if (Client_dataGridView.Rows.Count > 0)
            {
                UpdateClients();
            }
        }
        private void Serv_button_Alter_Click(object sender, EventArgs e)
        {
            if (Serv_dataGridView.Rows.Count > 0)
            {
                UpdateServs();
            }
        }
        private void Document_button_Alter_Click(object sender, EventArgs e)
        {
            if (Document_dataGridView.Rows.Count > 0)
            {
                UpdateDocuments();
            }
        }

        //Кнопки "Удалить"
        private void Order_button_Delete_Click(object sender, EventArgs e)
        {
            if (Orders_dataGridView.Rows.Count > 0)
            {
                DeleteOrders();
            }
        }
        private void Client_button_Delete_Click(object sender, EventArgs e)
        {
            if (Client_dataGridView.Rows.Count > 0)
            {
                DeleteClients();
            }
        }
        private void Serv_button_Delete_Click(object sender, EventArgs e)
        {
            if (Serv_dataGridView.Rows.Count > 0)
            {
                DeleteServs();
            }
        }
        private void Document_button_Delete_Click(object sender, EventArgs e)
        {
            if (Document_dataGridView.Rows.Count > 0)
            {
                DeleteDocuments();
            }
        }

        //Кнопки "Новая запись"
        private void Order_button_New_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
        }
        private void Client_button_New_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }
        private void Serv_button_New_Click(object sender, EventArgs e)
        {
            Serv serv = new Serv();
            serv.Show();
        }
        private void Document_button_New_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            document.Show();
        }

        //Texbox Поиск
        private void Order_textBox_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchInDataGrid(Orders_dataGridView, Order_textBox_Search);
            }
        }
        private void Client_textBox_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchInDataGrid(Client_dataGridView, Client_textBox_Search);
            }
        }
        private void Serv_textBox_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchInDataGrid(Serv_dataGridView, Serv_textBox_Search);
            }
        }
        private void Document_textBox_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchInDataGrid(Document_dataGridView, Document_textBox_Search);
            }
        }
    }
}