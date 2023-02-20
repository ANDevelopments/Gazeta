using System.Windows.Forms;

namespace RepairAPPAPI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.Order_button_Alter = new System.Windows.Forms.Button();
            this.Order_button_Delete = new System.Windows.Forms.Button();
            this.Order_button_New = new System.Windows.Forms.Button();
            this.Order_button_Refresh = new System.Windows.Forms.Button();
            this.Order_button_Clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Order_textBox_ServiceName = new System.Windows.Forms.ComboBox();
            this.Order_textBox_Progress = new System.Windows.Forms.ComboBox();
            this.Order_textBox_Execution = new System.Windows.Forms.MaskedTextBox();
            this.Order_textBox_OrderDate = new System.Windows.Forms.TextBox();
            this.Order_textBox_Descript = new System.Windows.Forms.TextBox();
            this.Order_textBox_ClientName = new System.Windows.Forms.TextBox();
            this.Order_textBox_ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Order_textBox_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Orders_dataGridView = new System.Windows.Forms.DataGridView();
            this.OrdersIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersClientIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersServiceNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersDescriptCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersOrderDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersExecutionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersProgressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageClient = new System.Windows.Forms.TabPage();
            this.Client_button_Alter = new System.Windows.Forms.Button();
            this.Client_button_Delete = new System.Windows.Forms.Button();
            this.Client_button_New = new System.Windows.Forms.Button();
            this.Client_button_Refresh = new System.Windows.Forms.Button();
            this.Client_button_Clear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Client_textBox_Telephone = new System.Windows.Forms.MaskedTextBox();
            this.Client_textBox_Adress = new System.Windows.Forms.TextBox();
            this.Client_textBox_FullName = new System.Windows.Forms.TextBox();
            this.Client_textBox_ID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Client_textBox_Search = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Client_dataGridView = new System.Windows.Forms.DataGridView();
            this.ClientIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientFullNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientAdressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientTelephoneCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageServ = new System.Windows.Forms.TabPage();
            this.Serv_button_Alter = new System.Windows.Forms.Button();
            this.Serv_button_Delete = new System.Windows.Forms.Button();
            this.Serv_button_New = new System.Windows.Forms.Button();
            this.Serv_button_Refresh = new System.Windows.Forms.Button();
            this.Serv_button_Clear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Serv_textBox_ID = new System.Windows.Forms.TextBox();
            this.Serv_textBox_Price = new System.Windows.Forms.TextBox();
            this.Serv_textBox_ServiceName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Serv_textBox_Search = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Serv_dataGridView = new System.Windows.Forms.DataGridView();
            this.ServNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageDocument = new System.Windows.Forms.TabPage();
            this.Document_button_Alter = new System.Windows.Forms.Button();
            this.Document_button_Delete = new System.Windows.Forms.Button();
            this.Document_button_New = new System.Windows.Forms.Button();
            this.Document_button_Refresh = new System.Windows.Forms.Button();
            this.Document_button_Clear = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Document_textBox_DocumentDate = new System.Windows.Forms.TextBox();
            this.Document_textBox_Total = new System.Windows.Forms.TextBox();
            this.Document_textBox_OrderID = new System.Windows.Forms.TextBox();
            this.Document_textBox_ClientName = new System.Windows.Forms.TextBox();
            this.Document_textBox_ClientID = new System.Windows.Forms.TextBox();
            this.Document_textBox_ID = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.Document_textBox_Search = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.Document_dataGridView = new System.Windows.Forms.DataGridView();
            this.DocIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocOrderIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocTotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocModCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Exit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageOrders.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Orders_dataGridView)).BeginInit();
            this.tabPageClient.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Client_dataGridView)).BeginInit();
            this.tabPageServ.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Serv_dataGridView)).BeginInit();
            this.tabPageDocument.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Document_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOrders);
            this.tabControl1.Controls.Add(this.tabPageClient);
            this.tabControl1.Controls.Add(this.tabPageServ);
            this.tabControl1.Controls.Add(this.tabPageDocument);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 655);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPageOrders.Controls.Add(this.Order_button_Alter);
            this.tabPageOrders.Controls.Add(this.Order_button_Delete);
            this.tabPageOrders.Controls.Add(this.Order_button_New);
            this.tabPageOrders.Controls.Add(this.Order_button_Refresh);
            this.tabPageOrders.Controls.Add(this.Order_button_Clear);
            this.tabPageOrders.Controls.Add(this.panel1);
            this.tabPageOrders.Controls.Add(this.label2);
            this.tabPageOrders.Controls.Add(this.Order_textBox_Search);
            this.tabPageOrders.Controls.Add(this.label1);
            this.tabPageOrders.Controls.Add(this.Orders_dataGridView);
            this.tabPageOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 29);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(1072, 622);
            this.tabPageOrders.TabIndex = 1;
            this.tabPageOrders.Text = "Заказы";
            // 
            // Order_button_Alter
            // 
            this.Order_button_Alter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(250)))), ((int)(((byte)(133)))));
            this.Order_button_Alter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Order_button_Alter.Location = new System.Drawing.Point(669, 553);
            this.Order_button_Alter.Name = "Order_button_Alter";
            this.Order_button_Alter.Size = new System.Drawing.Size(394, 45);
            this.Order_button_Alter.TabIndex = 2;
            this.Order_button_Alter.Text = "Изменить";
            this.Order_button_Alter.UseVisualStyleBackColor = false;
            this.Order_button_Alter.Click += new System.EventHandler(this.Order_button_Alter_Click);
            // 
            // Order_button_Delete
            // 
            this.Order_button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(250)))), ((int)(((byte)(133)))));
            this.Order_button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Order_button_Delete.Location = new System.Drawing.Point(669, 501);
            this.Order_button_Delete.Name = "Order_button_Delete";
            this.Order_button_Delete.Size = new System.Drawing.Size(394, 45);
            this.Order_button_Delete.TabIndex = 1;
            this.Order_button_Delete.Text = "Удалить";
            this.Order_button_Delete.UseVisualStyleBackColor = false;
            this.Order_button_Delete.Click += new System.EventHandler(this.Order_button_Delete_Click);
            // 
            // Order_button_New
            // 
            this.Order_button_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(250)))), ((int)(((byte)(133)))));
            this.Order_button_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Order_button_New.Location = new System.Drawing.Point(669, 449);
            this.Order_button_New.Name = "Order_button_New";
            this.Order_button_New.Size = new System.Drawing.Size(394, 45);
            this.Order_button_New.TabIndex = 0;
            this.Order_button_New.Text = "Новая запись\r\n";
            this.Order_button_New.UseVisualStyleBackColor = false;
            this.Order_button_New.Click += new System.EventHandler(this.Order_button_New_Click);
            // 
            // Order_button_Refresh
            // 
            this.Order_button_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(133)))), ((int)(((byte)(146)))));
            this.Order_button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Order_button_Refresh.Location = new System.Drawing.Point(863, 394);
            this.Order_button_Refresh.Name = "Order_button_Refresh";
            this.Order_button_Refresh.Size = new System.Drawing.Size(200, 45);
            this.Order_button_Refresh.TabIndex = 3;
            this.Order_button_Refresh.Text = "Обновить";
            this.Order_button_Refresh.UseVisualStyleBackColor = false;
            this.Order_button_Refresh.Click += new System.EventHandler(this.Order_button_Refresh_Click);
            // 
            // Order_button_Clear
            // 
            this.Order_button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(133)))), ((int)(((byte)(146)))));
            this.Order_button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Order_button_Clear.Location = new System.Drawing.Point(669, 394);
            this.Order_button_Clear.Name = "Order_button_Clear";
            this.Order_button_Clear.Size = new System.Drawing.Size(188, 45);
            this.Order_button_Clear.TabIndex = 4;
            this.Order_button_Clear.Text = "Очистить";
            this.Order_button_Clear.UseVisualStyleBackColor = false;
            this.Order_button_Clear.Click += new System.EventHandler(this.Order_button_Clear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(133)))));
            this.panel1.Controls.Add(this.Order_textBox_ServiceName);
            this.panel1.Controls.Add(this.Order_textBox_Progress);
            this.panel1.Controls.Add(this.Order_textBox_Execution);
            this.panel1.Controls.Add(this.Order_textBox_OrderDate);
            this.panel1.Controls.Add(this.Order_textBox_Descript);
            this.panel1.Controls.Add(this.Order_textBox_ClientName);
            this.panel1.Controls.Add(this.Order_textBox_ID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(8, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 234);
            this.panel1.TabIndex = 4;
            // 
            // Order_textBox_ServiceName
            // 
            this.Order_textBox_ServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Order_textBox_ServiceName.FormattingEnabled = true;
            this.Order_textBox_ServiceName.Location = new System.Drawing.Point(211, 80);
            this.Order_textBox_ServiceName.Name = "Order_textBox_ServiceName";
            this.Order_textBox_ServiceName.Size = new System.Drawing.Size(413, 26);
            this.Order_textBox_ServiceName.TabIndex = 2;
            // 
            // Order_textBox_Progress
            // 
            this.Order_textBox_Progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Order_textBox_Progress.FormattingEnabled = true;
            this.Order_textBox_Progress.Location = new System.Drawing.Point(211, 194);
            this.Order_textBox_Progress.Name = "Order_textBox_Progress";
            this.Order_textBox_Progress.Size = new System.Drawing.Size(413, 26);
            this.Order_textBox_Progress.TabIndex = 6;
            // 
            // Order_textBox_Execution
            // 
            this.Order_textBox_Execution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Order_textBox_Execution.Location = new System.Drawing.Point(211, 166);
            this.Order_textBox_Execution.Mask = "00/00/0000";
            this.Order_textBox_Execution.Name = "Order_textBox_Execution";
            this.Order_textBox_Execution.Size = new System.Drawing.Size(413, 24);
            this.Order_textBox_Execution.TabIndex = 5;
            this.Order_textBox_Execution.ValidatingType = typeof(System.DateTime);
            // 
            // Order_textBox_OrderDate
            // 
            this.Order_textBox_OrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Order_textBox_OrderDate.Location = new System.Drawing.Point(211, 137);
            this.Order_textBox_OrderDate.Name = "Order_textBox_OrderDate";
            this.Order_textBox_OrderDate.ReadOnly = true;
            this.Order_textBox_OrderDate.Size = new System.Drawing.Size(413, 24);
            this.Order_textBox_OrderDate.TabIndex = 4;
            // 
            // Order_textBox_Descript
            // 
            this.Order_textBox_Descript.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Order_textBox_Descript.Location = new System.Drawing.Point(211, 109);
            this.Order_textBox_Descript.Name = "Order_textBox_Descript";
            this.Order_textBox_Descript.Size = new System.Drawing.Size(413, 24);
            this.Order_textBox_Descript.TabIndex = 3;
            // 
            // Order_textBox_ClientName
            // 
            this.Order_textBox_ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Order_textBox_ClientName.Location = new System.Drawing.Point(211, 53);
            this.Order_textBox_ClientName.Name = "Order_textBox_ClientName";
            this.Order_textBox_ClientName.ReadOnly = true;
            this.Order_textBox_ClientName.Size = new System.Drawing.Size(413, 24);
            this.Order_textBox_ClientName.TabIndex = 1;
            // 
            // Order_textBox_ID
            // 
            this.Order_textBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Order_textBox_ID.Location = new System.Drawing.Point(211, 25);
            this.Order_textBox_ID.Name = "Order_textBox_ID";
            this.Order_textBox_ID.ReadOnly = true;
            this.Order_textBox_ID.Size = new System.Drawing.Size(413, 24);
            this.Order_textBox_ID.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(90, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Прогресс";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(14, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Срок выполнения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(61, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Дата заказа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(87, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Описание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Название услуги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(52, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "ФИО клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(48, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Номер заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(685, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поиск";
            // 
            // Order_textBox_Search
            // 
            this.Order_textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Order_textBox_Search.Location = new System.Drawing.Point(756, 10);
            this.Order_textBox_Search.Name = "Order_textBox_Search";
            this.Order_textBox_Search.Size = new System.Drawing.Size(307, 27);
            this.Order_textBox_Search.TabIndex = 5;
            this.Order_textBox_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_textBox_Search_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица заказов";
            // 
            // Orders_dataGridView
            // 
            this.Orders_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(250)))), ((int)(((byte)(207)))));
            this.Orders_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Orders_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdersIDCol,
            this.OrdersClientIDCol,
            this.OrdersServiceNameCol,
            this.OrdersDescriptCol,
            this.OrdersOrderDateCol,
            this.OrdersExecutionCol,
            this.OrdersProgressCol});
            this.Orders_dataGridView.Location = new System.Drawing.Point(8, 43);
            this.Orders_dataGridView.Name = "Orders_dataGridView";
            this.Orders_dataGridView.ReadOnly = true;
            this.Orders_dataGridView.RowHeadersWidth = 51;
            this.Orders_dataGridView.RowTemplate.Height = 29;
            this.Orders_dataGridView.Size = new System.Drawing.Size(1055, 320);
            this.Orders_dataGridView.TabIndex = 0;
            this.Orders_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Orders_dataGridView_CellClick);
            // 
            // OrdersIDCol
            // 
            this.OrdersIDCol.HeaderText = "Номер заказа";
            this.OrdersIDCol.MinimumWidth = 6;
            this.OrdersIDCol.Name = "OrdersIDCol";
            this.OrdersIDCol.ReadOnly = true;
            this.OrdersIDCol.Width = 80;
            // 
            // OrdersClientIDCol
            // 
            this.OrdersClientIDCol.HeaderText = "ID клиента";
            this.OrdersClientIDCol.MinimumWidth = 6;
            this.OrdersClientIDCol.Name = "OrdersClientIDCol";
            this.OrdersClientIDCol.ReadOnly = true;
            this.OrdersClientIDCol.Width = 80;
            // 
            // OrdersServiceNameCol
            // 
            this.OrdersServiceNameCol.HeaderText = "Название услуги";
            this.OrdersServiceNameCol.MinimumWidth = 6;
            this.OrdersServiceNameCol.Name = "OrdersServiceNameCol";
            this.OrdersServiceNameCol.ReadOnly = true;
            this.OrdersServiceNameCol.Width = 180;
            // 
            // OrdersDescriptCol
            // 
            this.OrdersDescriptCol.HeaderText = "Описание";
            this.OrdersDescriptCol.MinimumWidth = 6;
            this.OrdersDescriptCol.Name = "OrdersDescriptCol";
            this.OrdersDescriptCol.ReadOnly = true;
            this.OrdersDescriptCol.Width = 250;
            // 
            // OrdersOrderDateCol
            // 
            this.OrdersOrderDateCol.HeaderText = "Дата заказа";
            this.OrdersOrderDateCol.MinimumWidth = 6;
            this.OrdersOrderDateCol.Name = "OrdersOrderDateCol";
            this.OrdersOrderDateCol.ReadOnly = true;
            this.OrdersOrderDateCol.Width = 130;
            // 
            // OrdersExecutionCol
            // 
            this.OrdersExecutionCol.HeaderText = "Срок выполнения";
            this.OrdersExecutionCol.MinimumWidth = 6;
            this.OrdersExecutionCol.Name = "OrdersExecutionCol";
            this.OrdersExecutionCol.ReadOnly = true;
            this.OrdersExecutionCol.Width = 130;
            // 
            // OrdersProgressCol
            // 
            this.OrdersProgressCol.HeaderText = "Прогресс";
            this.OrdersProgressCol.MinimumWidth = 6;
            this.OrdersProgressCol.Name = "OrdersProgressCol";
            this.OrdersProgressCol.ReadOnly = true;
            this.OrdersProgressCol.Width = 125;
            // 
            // tabPageClient
            // 
            this.tabPageClient.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPageClient.Controls.Add(this.Client_button_Alter);
            this.tabPageClient.Controls.Add(this.Client_button_Delete);
            this.tabPageClient.Controls.Add(this.Client_button_New);
            this.tabPageClient.Controls.Add(this.Client_button_Refresh);
            this.tabPageClient.Controls.Add(this.Client_button_Clear);
            this.tabPageClient.Controls.Add(this.panel2);
            this.tabPageClient.Controls.Add(this.label10);
            this.tabPageClient.Controls.Add(this.Client_textBox_Search);
            this.tabPageClient.Controls.Add(this.label11);
            this.tabPageClient.Controls.Add(this.Client_dataGridView);
            this.tabPageClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageClient.Location = new System.Drawing.Point(4, 29);
            this.tabPageClient.Name = "tabPageClient";
            this.tabPageClient.Size = new System.Drawing.Size(1072, 622);
            this.tabPageClient.TabIndex = 2;
            this.tabPageClient.Text = "Клиенты";
            // 
            // Client_button_Alter
            // 
            this.Client_button_Alter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(250)))), ((int)(((byte)(133)))));
            this.Client_button_Alter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Client_button_Alter.Location = new System.Drawing.Point(669, 553);
            this.Client_button_Alter.Name = "Client_button_Alter";
            this.Client_button_Alter.Size = new System.Drawing.Size(394, 45);
            this.Client_button_Alter.TabIndex = 2;
            this.Client_button_Alter.Text = "Изменить";
            this.Client_button_Alter.UseVisualStyleBackColor = false;
            this.Client_button_Alter.Click += new System.EventHandler(this.Client_button_Alter_Click);
            // 
            // Client_button_Delete
            // 
            this.Client_button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(250)))), ((int)(((byte)(133)))));
            this.Client_button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Client_button_Delete.Location = new System.Drawing.Point(669, 501);
            this.Client_button_Delete.Name = "Client_button_Delete";
            this.Client_button_Delete.Size = new System.Drawing.Size(394, 45);
            this.Client_button_Delete.TabIndex = 1;
            this.Client_button_Delete.Text = "Удалить";
            this.Client_button_Delete.UseVisualStyleBackColor = false;
            this.Client_button_Delete.Click += new System.EventHandler(this.Client_button_Delete_Click);
            // 
            // Client_button_New
            // 
            this.Client_button_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(250)))), ((int)(((byte)(133)))));
            this.Client_button_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Client_button_New.Location = new System.Drawing.Point(669, 449);
            this.Client_button_New.Name = "Client_button_New";
            this.Client_button_New.Size = new System.Drawing.Size(394, 45);
            this.Client_button_New.TabIndex = 0;
            this.Client_button_New.Text = "Новая запись\r\n";
            this.Client_button_New.UseVisualStyleBackColor = false;
            this.Client_button_New.Click += new System.EventHandler(this.Client_button_New_Click);
            // 
            // Client_button_Refresh
            // 
            this.Client_button_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(133)))), ((int)(((byte)(146)))));
            this.Client_button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Client_button_Refresh.Location = new System.Drawing.Point(863, 394);
            this.Client_button_Refresh.Name = "Client_button_Refresh";
            this.Client_button_Refresh.Size = new System.Drawing.Size(200, 45);
            this.Client_button_Refresh.TabIndex = 3;
            this.Client_button_Refresh.Text = "Обновить";
            this.Client_button_Refresh.UseVisualStyleBackColor = false;
            this.Client_button_Refresh.Click += new System.EventHandler(this.Client_button_Refresh_Click);
            // 
            // Client_button_Clear
            // 
            this.Client_button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(133)))), ((int)(((byte)(146)))));
            this.Client_button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Client_button_Clear.Location = new System.Drawing.Point(669, 394);
            this.Client_button_Clear.Name = "Client_button_Clear";
            this.Client_button_Clear.Size = new System.Drawing.Size(188, 45);
            this.Client_button_Clear.TabIndex = 4;
            this.Client_button_Clear.Text = "Очистить";
            this.Client_button_Clear.UseVisualStyleBackColor = false;
            this.Client_button_Clear.Click += new System.EventHandler(this.Client_button_Clear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(133)))));
            this.panel2.Controls.Add(this.Client_textBox_Telephone);
            this.panel2.Controls.Add(this.Client_textBox_Adress);
            this.panel2.Controls.Add(this.Client_textBox_FullName);
            this.panel2.Controls.Add(this.Client_textBox_ID);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Location = new System.Drawing.Point(8, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 234);
            this.panel2.TabIndex = 11;
            // 
            // Client_textBox_Telephone
            // 
            this.Client_textBox_Telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Client_textBox_Telephone.Location = new System.Drawing.Point(211, 138);
            this.Client_textBox_Telephone.Mask = "+7(999) 000-0000";
            this.Client_textBox_Telephone.Name = "Client_textBox_Telephone";
            this.Client_textBox_Telephone.Size = new System.Drawing.Size(413, 24);
            this.Client_textBox_Telephone.TabIndex = 3;
            // 
            // Client_textBox_Adress
            // 
            this.Client_textBox_Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Client_textBox_Adress.Location = new System.Drawing.Point(211, 109);
            this.Client_textBox_Adress.Name = "Client_textBox_Adress";
            this.Client_textBox_Adress.Size = new System.Drawing.Size(413, 24);
            this.Client_textBox_Adress.TabIndex = 2;
            // 
            // Client_textBox_FullName
            // 
            this.Client_textBox_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Client_textBox_FullName.Location = new System.Drawing.Point(211, 81);
            this.Client_textBox_FullName.Name = "Client_textBox_FullName";
            this.Client_textBox_FullName.Size = new System.Drawing.Size(413, 24);
            this.Client_textBox_FullName.TabIndex = 1;
            // 
            // Client_textBox_ID
            // 
            this.Client_textBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Client_textBox_ID.Location = new System.Drawing.Point(211, 53);
            this.Client_textBox_ID.Name = "Client_textBox_ID";
            this.Client_textBox_ID.ReadOnly = true;
            this.Client_textBox_ID.Size = new System.Drawing.Size(413, 24);
            this.Client_textBox_ID.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(17, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Номер телефона";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(119, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Адрес";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(134, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "ФИО";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(76, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "ID клиента";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(685, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Поиск";
            // 
            // Client_textBox_Search
            // 
            this.Client_textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Client_textBox_Search.Location = new System.Drawing.Point(756, 10);
            this.Client_textBox_Search.Name = "Client_textBox_Search";
            this.Client_textBox_Search.Size = new System.Drawing.Size(307, 27);
            this.Client_textBox_Search.TabIndex = 5;
            this.Client_textBox_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Client_textBox_Search_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(8, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "Таблица клиентов";
            // 
            // Client_dataGridView
            // 
            this.Client_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(250)))), ((int)(((byte)(207)))));
            this.Client_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Client_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientIDCol,
            this.ClientFullNameCol,
            this.ClientAdressCol,
            this.ClientTelephoneCol});
            this.Client_dataGridView.Location = new System.Drawing.Point(8, 43);
            this.Client_dataGridView.Name = "Client_dataGridView";
            this.Client_dataGridView.ReadOnly = true;
            this.Client_dataGridView.RowHeadersWidth = 51;
            this.Client_dataGridView.RowTemplate.Height = 29;
            this.Client_dataGridView.Size = new System.Drawing.Size(1055, 320);
            this.Client_dataGridView.TabIndex = 4;
            this.Client_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Client_dataGridView_CellClick);
            // 
            // ClientIDCol
            // 
            this.ClientIDCol.HeaderText = "ID Клиента";
            this.ClientIDCol.MinimumWidth = 6;
            this.ClientIDCol.Name = "ClientIDCol";
            this.ClientIDCol.ReadOnly = true;
            this.ClientIDCol.Width = 125;
            // 
            // ClientFullNameCol
            // 
            this.ClientFullNameCol.HeaderText = "ФИО";
            this.ClientFullNameCol.MinimumWidth = 6;
            this.ClientFullNameCol.Name = "ClientFullNameCol";
            this.ClientFullNameCol.ReadOnly = true;
            this.ClientFullNameCol.Width = 250;
            // 
            // ClientAdressCol
            // 
            this.ClientAdressCol.HeaderText = "Адрес";
            this.ClientAdressCol.MinimumWidth = 6;
            this.ClientAdressCol.Name = "ClientAdressCol";
            this.ClientAdressCol.ReadOnly = true;
            this.ClientAdressCol.Width = 250;
            // 
            // ClientTelephoneCol
            // 
            this.ClientTelephoneCol.HeaderText = "Номер телефона";
            this.ClientTelephoneCol.MinimumWidth = 6;
            this.ClientTelephoneCol.Name = "ClientTelephoneCol";
            this.ClientTelephoneCol.ReadOnly = true;
            this.ClientTelephoneCol.Width = 150;
            // 
            // tabPageServ
            // 
            this.tabPageServ.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPageServ.Controls.Add(this.Serv_button_Alter);
            this.tabPageServ.Controls.Add(this.Serv_button_Delete);
            this.tabPageServ.Controls.Add(this.Serv_button_New);
            this.tabPageServ.Controls.Add(this.Serv_button_Refresh);
            this.tabPageServ.Controls.Add(this.Serv_button_Clear);
            this.tabPageServ.Controls.Add(this.panel3);
            this.tabPageServ.Controls.Add(this.label20);
            this.tabPageServ.Controls.Add(this.Serv_textBox_Search);
            this.tabPageServ.Controls.Add(this.label21);
            this.tabPageServ.Controls.Add(this.Serv_dataGridView);
            this.tabPageServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageServ.Location = new System.Drawing.Point(4, 29);
            this.tabPageServ.Name = "tabPageServ";
            this.tabPageServ.Size = new System.Drawing.Size(1072, 622);
            this.tabPageServ.TabIndex = 3;
            this.tabPageServ.Text = "Услуги";
            // 
            // Serv_button_Alter
            // 
            this.Serv_button_Alter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(250)))), ((int)(((byte)(133)))));
            this.Serv_button_Alter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Serv_button_Alter.Location = new System.Drawing.Point(669, 553);
            this.Serv_button_Alter.Name = "Serv_button_Alter";
            this.Serv_button_Alter.Size = new System.Drawing.Size(394, 45);
            this.Serv_button_Alter.TabIndex = 2;
            this.Serv_button_Alter.Text = "Изменить";
            this.Serv_button_Alter.UseVisualStyleBackColor = false;
            this.Serv_button_Alter.Click += new System.EventHandler(this.Serv_button_Alter_Click);
            // 
            // Serv_button_Delete
            // 
            this.Serv_button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(250)))), ((int)(((byte)(133)))));
            this.Serv_button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Serv_button_Delete.Location = new System.Drawing.Point(669, 501);
            this.Serv_button_Delete.Name = "Serv_button_Delete";
            this.Serv_button_Delete.Size = new System.Drawing.Size(394, 45);
            this.Serv_button_Delete.TabIndex = 1;
            this.Serv_button_Delete.Text = "Удалить";
            this.Serv_button_Delete.UseVisualStyleBackColor = false;
            this.Serv_button_Delete.Click += new System.EventHandler(this.Serv_button_Delete_Click);
            // 
            // Serv_button_New
            // 
            this.Serv_button_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(250)))), ((int)(((byte)(133)))));
            this.Serv_button_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Serv_button_New.Location = new System.Drawing.Point(669, 449);
            this.Serv_button_New.Name = "Serv_button_New";
            this.Serv_button_New.Size = new System.Drawing.Size(394, 45);
            this.Serv_button_New.TabIndex = 0;
            this.Serv_button_New.Text = "Новая запись\r\n";
            this.Serv_button_New.UseVisualStyleBackColor = false;
            this.Serv_button_New.Click += new System.EventHandler(this.Serv_button_New_Click);
            // 
            // Serv_button_Refresh
            // 
            this.Serv_button_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(133)))), ((int)(((byte)(146)))));
            this.Serv_button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Serv_button_Refresh.Location = new System.Drawing.Point(863, 394);
            this.Serv_button_Refresh.Name = "Serv_button_Refresh";
            this.Serv_button_Refresh.Size = new System.Drawing.Size(200, 45);
            this.Serv_button_Refresh.TabIndex = 3;
            this.Serv_button_Refresh.Text = "Обновить";
            this.Serv_button_Refresh.UseVisualStyleBackColor = false;
            this.Serv_button_Refresh.Click += new System.EventHandler(this.Serv_button_Refresh_Click);
            // 
            // Serv_button_Clear
            // 
            this.Serv_button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(133)))), ((int)(((byte)(146)))));
            this.Serv_button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Serv_button_Clear.Location = new System.Drawing.Point(669, 394);
            this.Serv_button_Clear.Name = "Serv_button_Clear";
            this.Serv_button_Clear.Size = new System.Drawing.Size(188, 45);
            this.Serv_button_Clear.TabIndex = 4;
            this.Serv_button_Clear.Text = "Очистить";
            this.Serv_button_Clear.UseVisualStyleBackColor = false;
            this.Serv_button_Clear.Click += new System.EventHandler(this.Serv_button_Clear_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(133)))));
            this.panel3.Controls.Add(this.Serv_textBox_ID);
            this.panel3.Controls.Add(this.Serv_textBox_Price);
            this.panel3.Controls.Add(this.Serv_textBox_ServiceName);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Location = new System.Drawing.Point(8, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 234);
            this.panel3.TabIndex = 22;
            // 
            // Serv_textBox_ID
            // 
            this.Serv_textBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Serv_textBox_ID.Location = new System.Drawing.Point(211, 109);
            this.Serv_textBox_ID.Name = "Serv_textBox_ID";
            this.Serv_textBox_ID.ReadOnly = true;
            this.Serv_textBox_ID.Size = new System.Drawing.Size(413, 24);
            this.Serv_textBox_ID.TabIndex = 2;
            // 
            // Serv_textBox_Price
            // 
            this.Serv_textBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Serv_textBox_Price.Location = new System.Drawing.Point(211, 81);
            this.Serv_textBox_Price.Name = "Serv_textBox_Price";
            this.Serv_textBox_Price.Size = new System.Drawing.Size(413, 24);
            this.Serv_textBox_Price.TabIndex = 1;
            this.Serv_textBox_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Serv_textBox_Price_KeyPress);
            // 
            // Serv_textBox_ServiceName
            // 
            this.Serv_textBox_ServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Serv_textBox_ServiceName.Location = new System.Drawing.Point(211, 53);
            this.Serv_textBox_ServiceName.Name = "Serv_textBox_ServiceName";
            this.Serv_textBox_ServiceName.ReadOnly = true;
            this.Serv_textBox_ServiceName.Size = new System.Drawing.Size(413, 24);
            this.Serv_textBox_ServiceName.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(93, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "ID услуги";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(130, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "Цена";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(22, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(164, 20);
            this.label19.TabIndex = 1;
            this.label19.Text = "Название услуги";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(685, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 20);
            this.label20.TabIndex = 21;
            this.label20.Text = "Поиск";
            // 
            // Serv_textBox_Search
            // 
            this.Serv_textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Serv_textBox_Search.Location = new System.Drawing.Point(756, 10);
            this.Serv_textBox_Search.Name = "Serv_textBox_Search";
            this.Serv_textBox_Search.Size = new System.Drawing.Size(307, 27);
            this.Serv_textBox_Search.TabIndex = 5;
            this.Serv_textBox_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Serv_textBox_Search_KeyDown);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(8, 15);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(156, 25);
            this.label21.TabIndex = 19;
            this.label21.Text = "Таблица услуг";
            // 
            // Serv_dataGridView
            // 
            this.Serv_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(250)))), ((int)(((byte)(207)))));
            this.Serv_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Serv_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServNameCol,
            this.ServPriceCol,
            this.ServIDCol});
            this.Serv_dataGridView.Location = new System.Drawing.Point(8, 43);
            this.Serv_dataGridView.Name = "Serv_dataGridView";
            this.Serv_dataGridView.ReadOnly = true;
            this.Serv_dataGridView.RowHeadersWidth = 51;
            this.Serv_dataGridView.RowTemplate.Height = 29;
            this.Serv_dataGridView.Size = new System.Drawing.Size(1055, 320);
            this.Serv_dataGridView.TabIndex = 18;
            this.Serv_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Serv_dataGridView_CellClick);
            // 
            // ServNameCol
            // 
            this.ServNameCol.HeaderText = "Название услуги";
            this.ServNameCol.MinimumWidth = 6;
            this.ServNameCol.Name = "ServNameCol";
            this.ServNameCol.ReadOnly = true;
            this.ServNameCol.Width = 300;
            // 
            // ServPriceCol
            // 
            this.ServPriceCol.HeaderText = "Цена";
            this.ServPriceCol.MinimumWidth = 6;
            this.ServPriceCol.Name = "ServPriceCol";
            this.ServPriceCol.ReadOnly = true;
            this.ServPriceCol.Width = 160;
            // 
            // ServIDCol
            // 
            this.ServIDCol.HeaderText = "ID услуги";
            this.ServIDCol.MinimumWidth = 6;
            this.ServIDCol.Name = "ServIDCol";
            this.ServIDCol.ReadOnly = true;
            this.ServIDCol.Width = 125;
            // 
            // tabPageDocument
            // 
            this.tabPageDocument.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPageDocument.Controls.Add(this.Document_button_Alter);
            this.tabPageDocument.Controls.Add(this.Document_button_Delete);
            this.tabPageDocument.Controls.Add(this.Document_button_New);
            this.tabPageDocument.Controls.Add(this.Document_button_Refresh);
            this.tabPageDocument.Controls.Add(this.Document_button_Clear);
            this.tabPageDocument.Controls.Add(this.panel4);
            this.tabPageDocument.Controls.Add(this.label28);
            this.tabPageDocument.Controls.Add(this.Document_textBox_Search);
            this.tabPageDocument.Controls.Add(this.label29);
            this.tabPageDocument.Controls.Add(this.Document_dataGridView);
            this.tabPageDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageDocument.Location = new System.Drawing.Point(4, 29);
            this.tabPageDocument.Name = "tabPageDocument";
            this.tabPageDocument.Size = new System.Drawing.Size(1072, 622);
            this.tabPageDocument.TabIndex = 4;
            this.tabPageDocument.Text = "Договоры";
            // 
            // Document_button_Alter
            // 
            this.Document_button_Alter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(250)))), ((int)(((byte)(133)))));
            this.Document_button_Alter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Document_button_Alter.Location = new System.Drawing.Point(669, 553);
            this.Document_button_Alter.Name = "Document_button_Alter";
            this.Document_button_Alter.Size = new System.Drawing.Size(394, 45);
            this.Document_button_Alter.TabIndex = 3;
            this.Document_button_Alter.Text = "Изменить";
            this.Document_button_Alter.UseVisualStyleBackColor = false;
            this.Document_button_Alter.Click += new System.EventHandler(this.Document_button_Alter_Click);
            // 
            // Document_button_Delete
            // 
            this.Document_button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(250)))), ((int)(((byte)(133)))));
            this.Document_button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Document_button_Delete.Location = new System.Drawing.Point(669, 501);
            this.Document_button_Delete.Name = "Document_button_Delete";
            this.Document_button_Delete.Size = new System.Drawing.Size(394, 45);
            this.Document_button_Delete.TabIndex = 2;
            this.Document_button_Delete.Text = "Удалить";
            this.Document_button_Delete.UseVisualStyleBackColor = false;
            this.Document_button_Delete.Click += new System.EventHandler(this.Document_button_Delete_Click);
            // 
            // Document_button_New
            // 
            this.Document_button_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(250)))), ((int)(((byte)(133)))));
            this.Document_button_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Document_button_New.Location = new System.Drawing.Point(669, 449);
            this.Document_button_New.Name = "Document_button_New";
            this.Document_button_New.Size = new System.Drawing.Size(394, 45);
            this.Document_button_New.TabIndex = 1;
            this.Document_button_New.Text = "Новая запись\r\n";
            this.Document_button_New.UseVisualStyleBackColor = false;
            this.Document_button_New.Click += new System.EventHandler(this.Document_button_New_Click);
            // 
            // Document_button_Refresh
            // 
            this.Document_button_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(133)))), ((int)(((byte)(146)))));
            this.Document_button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Document_button_Refresh.Location = new System.Drawing.Point(863, 394);
            this.Document_button_Refresh.Name = "Document_button_Refresh";
            this.Document_button_Refresh.Size = new System.Drawing.Size(200, 45);
            this.Document_button_Refresh.TabIndex = 4;
            this.Document_button_Refresh.Text = "Обновить";
            this.Document_button_Refresh.UseVisualStyleBackColor = false;
            this.Document_button_Refresh.Click += new System.EventHandler(this.Document_button_Refresh_Click);
            // 
            // Document_button_Clear
            // 
            this.Document_button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(133)))), ((int)(((byte)(146)))));
            this.Document_button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Document_button_Clear.Location = new System.Drawing.Point(669, 394);
            this.Document_button_Clear.Name = "Document_button_Clear";
            this.Document_button_Clear.Size = new System.Drawing.Size(188, 45);
            this.Document_button_Clear.TabIndex = 5;
            this.Document_button_Clear.Text = "Очистить";
            this.Document_button_Clear.UseVisualStyleBackColor = false;
            this.Document_button_Clear.Click += new System.EventHandler(this.Document_button_Clear_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(133)))));
            this.panel4.Controls.Add(this.Document_textBox_DocumentDate);
            this.panel4.Controls.Add(this.Document_textBox_Total);
            this.panel4.Controls.Add(this.Document_textBox_OrderID);
            this.panel4.Controls.Add(this.Document_textBox_ClientName);
            this.panel4.Controls.Add(this.Document_textBox_ClientID);
            this.panel4.Controls.Add(this.Document_textBox_ID);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Controls.Add(this.label27);
            this.panel4.Location = new System.Drawing.Point(8, 380);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(638, 234);
            this.panel4.TabIndex = 0;
            // 
            // Document_textBox_DocumentDate
            // 
            this.Document_textBox_DocumentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Document_textBox_DocumentDate.Location = new System.Drawing.Point(211, 165);
            this.Document_textBox_DocumentDate.Name = "Document_textBox_DocumentDate";
            this.Document_textBox_DocumentDate.ReadOnly = true;
            this.Document_textBox_DocumentDate.Size = new System.Drawing.Size(413, 24);
            this.Document_textBox_DocumentDate.TabIndex = 5;
            // 
            // Document_textBox_Total
            // 
            this.Document_textBox_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Document_textBox_Total.Location = new System.Drawing.Point(211, 137);
            this.Document_textBox_Total.Name = "Document_textBox_Total";
            this.Document_textBox_Total.Size = new System.Drawing.Size(413, 24);
            this.Document_textBox_Total.TabIndex = 4;
            this.Document_textBox_Total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Document_textBox_Total_KeyPress);
            // 
            // Document_textBox_OrderID
            // 
            this.Document_textBox_OrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Document_textBox_OrderID.Location = new System.Drawing.Point(211, 109);
            this.Document_textBox_OrderID.Name = "Document_textBox_OrderID";
            this.Document_textBox_OrderID.ReadOnly = true;
            this.Document_textBox_OrderID.Size = new System.Drawing.Size(413, 24);
            this.Document_textBox_OrderID.TabIndex = 3;
            // 
            // Document_textBox_ClientName
            // 
            this.Document_textBox_ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Document_textBox_ClientName.Location = new System.Drawing.Point(211, 81);
            this.Document_textBox_ClientName.Name = "Document_textBox_ClientName";
            this.Document_textBox_ClientName.ReadOnly = true;
            this.Document_textBox_ClientName.Size = new System.Drawing.Size(413, 24);
            this.Document_textBox_ClientName.TabIndex = 2;
            // 
            // Document_textBox_ClientID
            // 
            this.Document_textBox_ClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Document_textBox_ClientID.Location = new System.Drawing.Point(211, 53);
            this.Document_textBox_ClientID.Name = "Document_textBox_ClientID";
            this.Document_textBox_ClientID.ReadOnly = true;
            this.Document_textBox_ClientID.Size = new System.Drawing.Size(413, 24);
            this.Document_textBox_ClientID.TabIndex = 1;
            // 
            // Document_textBox_ID
            // 
            this.Document_textBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Document_textBox_ID.Location = new System.Drawing.Point(211, 25);
            this.Document_textBox_ID.Name = "Document_textBox_ID";
            this.Document_textBox_ID.ReadOnly = true;
            this.Document_textBox_ID.Size = new System.Drawing.Size(413, 24);
            this.Document_textBox_ID.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(130, 165);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 20);
            this.label22.TabIndex = 5;
            this.label22.Text = "Дата";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(59, 137);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(127, 20);
            this.label23.TabIndex = 4;
            this.label23.Text = "Сумма итого";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(48, 109);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(138, 20);
            this.label24.TabIndex = 3;
            this.label24.Text = "Номер заказа";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(52, 81);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(134, 20);
            this.label25.TabIndex = 2;
            this.label25.Text = "ФИО клиента";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(76, 53);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(110, 20);
            this.label26.TabIndex = 1;
            this.label26.Text = "ID клиента";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(23, 25);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(163, 20);
            this.label27.TabIndex = 0;
            this.label27.Text = "Номер договора";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(685, 13);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(65, 20);
            this.label28.TabIndex = 14;
            this.label28.Text = "Поиск";
            // 
            // Document_textBox_Search
            // 
            this.Document_textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Document_textBox_Search.Location = new System.Drawing.Point(756, 10);
            this.Document_textBox_Search.Name = "Document_textBox_Search";
            this.Document_textBox_Search.Size = new System.Drawing.Size(307, 27);
            this.Document_textBox_Search.TabIndex = 6;
            this.Document_textBox_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Document_textBox_Search_KeyDown);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(8, 15);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(207, 25);
            this.label29.TabIndex = 12;
            this.label29.Text = "Таблица договоров";
            // 
            // Document_dataGridView
            // 
            this.Document_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(250)))), ((int)(((byte)(207)))));
            this.Document_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Document_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocIDCol,
            this.DocClientID,
            this.DocClientName,
            this.DocOrderIDCol,
            this.DocTotalCol,
            this.DocDateCol,
            this.DocModCol});
            this.Document_dataGridView.Location = new System.Drawing.Point(8, 43);
            this.Document_dataGridView.Name = "Document_dataGridView";
            this.Document_dataGridView.ReadOnly = true;
            this.Document_dataGridView.RowHeadersWidth = 51;
            this.Document_dataGridView.RowTemplate.Height = 29;
            this.Document_dataGridView.Size = new System.Drawing.Size(1055, 320);
            this.Document_dataGridView.TabIndex = 11;
            this.Document_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Document_dataGridView_CellClick);
            // 
            // DocIDCol
            // 
            this.DocIDCol.HeaderText = "Номер договора";
            this.DocIDCol.MinimumWidth = 6;
            this.DocIDCol.Name = "DocIDCol";
            this.DocIDCol.ReadOnly = true;
            this.DocIDCol.Width = 80;
            // 
            // DocClientID
            // 
            this.DocClientID.HeaderText = "ID клиента";
            this.DocClientID.MinimumWidth = 6;
            this.DocClientID.Name = "DocClientID";
            this.DocClientID.ReadOnly = true;
            this.DocClientID.Width = 80;
            // 
            // DocClientName
            // 
            this.DocClientName.HeaderText = "ФИО клиента";
            this.DocClientName.MinimumWidth = 6;
            this.DocClientName.Name = "DocClientName";
            this.DocClientName.ReadOnly = true;
            this.DocClientName.Width = 270;
            // 
            // DocOrderIDCol
            // 
            this.DocOrderIDCol.HeaderText = "Номер заказа";
            this.DocOrderIDCol.MinimumWidth = 6;
            this.DocOrderIDCol.Name = "DocOrderIDCol";
            this.DocOrderIDCol.ReadOnly = true;
            this.DocOrderIDCol.Width = 80;
            // 
            // DocTotalCol
            // 
            this.DocTotalCol.HeaderText = "Сумма итого";
            this.DocTotalCol.MinimumWidth = 6;
            this.DocTotalCol.Name = "DocTotalCol";
            this.DocTotalCol.ReadOnly = true;
            this.DocTotalCol.Width = 200;
            // 
            // DocDateCol
            // 
            this.DocDateCol.HeaderText = "Дата";
            this.DocDateCol.MinimumWidth = 6;
            this.DocDateCol.Name = "DocDateCol";
            this.DocDateCol.ReadOnly = true;
            this.DocDateCol.Width = 200;
            // 
            // DocModCol
            // 
            this.DocModCol.HeaderText = "";
            this.DocModCol.MinimumWidth = 6;
            this.DocModCol.Name = "DocModCol";
            this.DocModCol.ReadOnly = true;
            this.DocModCol.Visible = false;
            this.DocModCol.Width = 20;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(133)))), ((int)(((byte)(146)))));
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Exit.Location = new System.Drawing.Point(945, 1);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(133, 27);
            this.button_Exit.TabIndex = 0;
            this.button_Exit.Text = "Завершить";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 655);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Repair";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOrders.ResumeLayout(false);
            this.tabPageOrders.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Orders_dataGridView)).EndInit();
            this.tabPageClient.ResumeLayout(false);
            this.tabPageClient.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Client_dataGridView)).EndInit();
            this.tabPageServ.ResumeLayout(false);
            this.tabPageServ.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Serv_dataGridView)).EndInit();
            this.tabPageDocument.ResumeLayout(false);
            this.tabPageDocument.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Document_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageOrders;
        private Panel panel1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox Order_textBox_Search;
        private Label label1;
        private DataGridView Orders_dataGridView;
        private TabPage tabPageClient;
        private TabPage tabPageServ;
        private TabPage tabPageDocument;
        private Button button_Exit;
        private TextBox Order_textBox_ID;
        private TextBox Order_textBox_Descript;
        private TextBox Order_textBox_ClientName;
        private TextBox Order_textBox_OrderDate;
        private Button Order_button_Refresh;
        private Button Order_button_Clear;
        private Button Order_button_Alter;
        private Button Order_button_Delete;
        private Button Order_button_New;
        private Button Client_button_Alter;
        private Button Client_button_Delete;
        private Button Client_button_New;
        private Button Client_button_Refresh;
        private Button Client_button_Clear;
        private Panel panel2;
        private TextBox Client_textBox_Adress;
        private TextBox Client_textBox_FullName;
        private TextBox Client_textBox_ID;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label10;
        private TextBox Client_textBox_Search;
        private Label label11;
        private DataGridView Client_dataGridView;
        private Button Serv_button_Alter;
        private Button Serv_button_Delete;
        private Button Serv_button_New;
        private Button Serv_button_Refresh;
        private Button Serv_button_Clear;
        private Panel panel3;
        private TextBox Serv_textBox_ID;
        private TextBox Serv_textBox_Price;
        private TextBox Serv_textBox_ServiceName;
        private Label label13;
        private Label label18;
        private Label label19;
        private Label label20;
        private TextBox Serv_textBox_Search;
        private Label label21;
        private DataGridView Serv_dataGridView;
        private Button Document_button_Alter;
        private Button Document_button_Delete;
        private Button Document_button_New;
        private Button Document_button_Refresh;
        private Button Document_button_Clear;
        private Panel panel4;
        private TextBox Document_textBox_DocumentDate;
        private TextBox Document_textBox_Total;
        private TextBox Document_textBox_OrderID;
        private TextBox Document_textBox_ClientName;
        private TextBox Document_textBox_ClientID;
        private TextBox Document_textBox_ID;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private TextBox Document_textBox_Search;
        private Label label29;
        private DataGridView Document_dataGridView;
        private DataGridViewTextBoxColumn DocIDCol;
        private DataGridViewTextBoxColumn DocClientID;
        private DataGridViewTextBoxColumn DocClientName;
        private DataGridViewTextBoxColumn DocOrderIDCol;
        private DataGridViewTextBoxColumn DocTotalCol;
        private DataGridViewTextBoxColumn DocDateCol;
        private DataGridViewTextBoxColumn DocModCol;
        private DataGridViewTextBoxColumn ClientIDCol;
        private DataGridViewTextBoxColumn ClientFullNameCol;
        private DataGridViewTextBoxColumn ClientAdressCol;
        private DataGridViewTextBoxColumn ClientTelephoneCol;
        private DataGridViewTextBoxColumn ServNameCol;
        private DataGridViewTextBoxColumn ServPriceCol;
        private DataGridViewTextBoxColumn ServIDCol;
        private DataGridViewTextBoxColumn OrdersIDCol;
        private DataGridViewTextBoxColumn OrdersClientIDCol;
        private DataGridViewTextBoxColumn OrdersServiceNameCol;
        private DataGridViewTextBoxColumn OrdersDescriptCol;
        private DataGridViewTextBoxColumn OrdersOrderDateCol;
        private DataGridViewTextBoxColumn OrdersExecutionCol;
        private DataGridViewTextBoxColumn OrdersProgressCol;
        private MaskedTextBox Order_textBox_Execution;
        private MaskedTextBox Client_textBox_Telephone;
        private ComboBox Order_textBox_Progress;
        private ComboBox Order_textBox_ServiceName;
    }
}