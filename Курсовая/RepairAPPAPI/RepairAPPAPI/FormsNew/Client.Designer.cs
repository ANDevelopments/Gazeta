namespace RepairAPPAPI
{
    partial class Client
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
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.textBox_FullName = new System.Windows.Forms.TextBox();
            this.textBox_Telephone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(250)))), ((int)(((byte)(133)))));
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Save.Location = new System.Drawing.Point(299, 315);
            this.button_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(156, 40);
            this.button_Save.TabIndex = 30;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(133)))), ((int)(((byte)(146)))));
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Clear.Location = new System.Drawing.Point(155, 315);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(124, 40);
            this.button_Clear.TabIndex = 29;
            this.button_Clear.Text = "Очистить";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(123, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(150, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Новый клиент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "ФИО клиента";
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Adress.Location = new System.Drawing.Point(219, 120);
            this.textBox_Adress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(236, 27);
            this.textBox_Adress.TabIndex = 23;
            // 
            // textBox_FullName
            // 
            this.textBox_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_FullName.Location = new System.Drawing.Point(219, 79);
            this.textBox_FullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_FullName.Name = "textBox_FullName";
            this.textBox_FullName.Size = new System.Drawing.Size(236, 27);
            this.textBox_FullName.TabIndex = 22;
            // 
            // textBox_Telephone
            // 
            this.textBox_Telephone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Telephone.Location = new System.Drawing.Point(219, 162);
            this.textBox_Telephone.Mask = "+7(999) 000-0000";
            this.textBox_Telephone.Name = "textBox_Telephone";
            this.textBox_Telephone.Size = new System.Drawing.Size(236, 30);
            this.textBox_Telephone.TabIndex = 31;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(482, 379);
            this.Controls.Add(this.textBox_Telephone);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.textBox_FullName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Client";
            this.Text = "Новый клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.TextBox textBox_FullName;
        private System.Windows.Forms.MaskedTextBox textBox_Telephone;
    }
}