namespace ClientApp
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonGetClients = new System.Windows.Forms.Button();
            this.buttonEditClient = new System.Windows.Forms.Button();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.buttonCreateClient = new System.Windows.Forms.Button();
            this.textBoxAddClientPayment = new System.Windows.Forms.TextBox();
            this.labelAddClientPayment = new System.Windows.Forms.Label();
            this.textBoxAddClientName = new System.Windows.Forms.TextBox();
            this.textBoxAddClientCreationDate = new System.Windows.Forms.TextBox();
            this.labelAddClientName = new System.Windows.Forms.Label();
            this.labelAddClientCreationDate = new System.Windows.Forms.Label();
            this.groupBoxCreateClient = new System.Windows.Forms.GroupBox();
            this.groupBoxEditClient = new System.Windows.Forms.GroupBox();
            this.textBoxEditClientName = new System.Windows.Forms.TextBox();
            this.textBoxEditClientPayment = new System.Windows.Forms.TextBox();
            this.labelEditClientPayment = new System.Windows.Forms.Label();
            this.labelEditClientCreationDate = new System.Windows.Forms.Label();
            this.labelEditClientName = new System.Windows.Forms.Label();
            this.textBoxEditClientCreationDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxCreateClient.SuspendLayout();
            this.groupBoxEditClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(537, 239);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonGetClients
            // 
            this.buttonGetClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGetClients.Location = new System.Drawing.Point(22, 268);
            this.buttonGetClients.Name = "buttonGetClients";
            this.buttonGetClients.Size = new System.Drawing.Size(120, 46);
            this.buttonGetClients.TabIndex = 1;
            this.buttonGetClients.Text = "Получить список всех клиентов";
            this.buttonGetClients.UseVisualStyleBackColor = true;
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.Location = new System.Drawing.Point(15, 140);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(153, 23);
            this.buttonEditClient.TabIndex = 3;
            this.buttonEditClient.Text = "Изменить";
            this.buttonEditClient.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteClient.Location = new System.Drawing.Point(22, 345);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(120, 46);
            this.buttonDeleteClient.TabIndex = 4;
            this.buttonDeleteClient.Text = "Удалить выбранного клиента";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            // 
            // buttonCreateClient
            // 
            this.buttonCreateClient.Location = new System.Drawing.Point(14, 140);
            this.buttonCreateClient.Name = "buttonCreateClient";
            this.buttonCreateClient.Size = new System.Drawing.Size(146, 23);
            this.buttonCreateClient.TabIndex = 4;
            this.buttonCreateClient.Text = "Создать";
            this.buttonCreateClient.UseVisualStyleBackColor = true;
            // 
            // textBoxAddClientPayment
            // 
            this.textBoxAddClientPayment.Location = new System.Drawing.Point(14, 114);
            this.textBoxAddClientPayment.Name = "textBoxAddClientPayment";
            this.textBoxAddClientPayment.Size = new System.Drawing.Size(146, 20);
            this.textBoxAddClientPayment.TabIndex = 9;
            // 
            // labelAddClientPayment
            // 
            this.labelAddClientPayment.AutoSize = true;
            this.labelAddClientPayment.Location = new System.Drawing.Point(11, 98);
            this.labelAddClientPayment.Name = "labelAddClientPayment";
            this.labelAddClientPayment.Size = new System.Drawing.Size(46, 13);
            this.labelAddClientPayment.TabIndex = 6;
            this.labelAddClientPayment.Text = "Платёж";
            // 
            // textBoxAddClientName
            // 
            this.textBoxAddClientName.Location = new System.Drawing.Point(15, 37);
            this.textBoxAddClientName.Name = "textBoxAddClientName";
            this.textBoxAddClientName.Size = new System.Drawing.Size(145, 20);
            this.textBoxAddClientName.TabIndex = 10;
            // 
            // textBoxAddClientCreationDate
            // 
            this.textBoxAddClientCreationDate.Location = new System.Drawing.Point(14, 76);
            this.textBoxAddClientCreationDate.Name = "textBoxAddClientCreationDate";
            this.textBoxAddClientCreationDate.Size = new System.Drawing.Size(146, 20);
            this.textBoxAddClientCreationDate.TabIndex = 11;
            // 
            // labelAddClientName
            // 
            this.labelAddClientName.AutoSize = true;
            this.labelAddClientName.Location = new System.Drawing.Point(11, 21);
            this.labelAddClientName.Name = "labelAddClientName";
            this.labelAddClientName.Size = new System.Drawing.Size(29, 13);
            this.labelAddClientName.TabIndex = 7;
            this.labelAddClientName.Text = "Имя";
            // 
            // labelAddClientCreationDate
            // 
            this.labelAddClientCreationDate.AutoSize = true;
            this.labelAddClientCreationDate.Location = new System.Drawing.Point(11, 60);
            this.labelAddClientCreationDate.Name = "labelAddClientCreationDate";
            this.labelAddClientCreationDate.Size = new System.Drawing.Size(84, 13);
            this.labelAddClientCreationDate.TabIndex = 8;
            this.labelAddClientCreationDate.Text = "Дата создания";
            // 
            // groupBoxCreateClient
            // 
            this.groupBoxCreateClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxCreateClient.Controls.Add(this.textBoxAddClientName);
            this.groupBoxCreateClient.Controls.Add(this.buttonCreateClient);
            this.groupBoxCreateClient.Controls.Add(this.textBoxAddClientPayment);
            this.groupBoxCreateClient.Controls.Add(this.labelAddClientPayment);
            this.groupBoxCreateClient.Controls.Add(this.labelAddClientCreationDate);
            this.groupBoxCreateClient.Controls.Add(this.labelAddClientName);
            this.groupBoxCreateClient.Controls.Add(this.textBoxAddClientCreationDate);
            this.groupBoxCreateClient.Location = new System.Drawing.Point(173, 263);
            this.groupBoxCreateClient.Name = "groupBoxCreateClient";
            this.groupBoxCreateClient.Size = new System.Drawing.Size(170, 179);
            this.groupBoxCreateClient.TabIndex = 12;
            this.groupBoxCreateClient.TabStop = false;
            this.groupBoxCreateClient.Text = "Создать клиента";
            // 
            // groupBoxEditClient
            // 
            this.groupBoxEditClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxEditClient.Controls.Add(this.textBoxEditClientName);
            this.groupBoxEditClient.Controls.Add(this.textBoxEditClientPayment);
            this.groupBoxEditClient.Controls.Add(this.labelEditClientPayment);
            this.groupBoxEditClient.Controls.Add(this.buttonEditClient);
            this.groupBoxEditClient.Controls.Add(this.labelEditClientCreationDate);
            this.groupBoxEditClient.Controls.Add(this.labelEditClientName);
            this.groupBoxEditClient.Controls.Add(this.textBoxEditClientCreationDate);
            this.groupBoxEditClient.Location = new System.Drawing.Point(375, 263);
            this.groupBoxEditClient.Name = "groupBoxEditClient";
            this.groupBoxEditClient.Size = new System.Drawing.Size(174, 179);
            this.groupBoxEditClient.TabIndex = 12;
            this.groupBoxEditClient.TabStop = false;
            this.groupBoxEditClient.Text = "Изменить клиента";
            // 
            // textBoxEditClientName
            // 
            this.textBoxEditClientName.Location = new System.Drawing.Point(15, 37);
            this.textBoxEditClientName.Name = "textBoxEditClientName";
            this.textBoxEditClientName.Size = new System.Drawing.Size(153, 20);
            this.textBoxEditClientName.TabIndex = 10;
            // 
            // textBoxEditClientPayment
            // 
            this.textBoxEditClientPayment.Location = new System.Drawing.Point(14, 114);
            this.textBoxEditClientPayment.Name = "textBoxEditClientPayment";
            this.textBoxEditClientPayment.Size = new System.Drawing.Size(154, 20);
            this.textBoxEditClientPayment.TabIndex = 9;
            // 
            // labelEditClientPayment
            // 
            this.labelEditClientPayment.AutoSize = true;
            this.labelEditClientPayment.Location = new System.Drawing.Point(11, 98);
            this.labelEditClientPayment.Name = "labelEditClientPayment";
            this.labelEditClientPayment.Size = new System.Drawing.Size(46, 13);
            this.labelEditClientPayment.TabIndex = 6;
            this.labelEditClientPayment.Text = "Платёж";
            // 
            // labelEditClientCreationDate
            // 
            this.labelEditClientCreationDate.AutoSize = true;
            this.labelEditClientCreationDate.Location = new System.Drawing.Point(11, 60);
            this.labelEditClientCreationDate.Name = "labelEditClientCreationDate";
            this.labelEditClientCreationDate.Size = new System.Drawing.Size(84, 13);
            this.labelEditClientCreationDate.TabIndex = 8;
            this.labelEditClientCreationDate.Text = "Дата создания";
            // 
            // labelEditClientName
            // 
            this.labelEditClientName.AutoSize = true;
            this.labelEditClientName.Location = new System.Drawing.Point(12, 21);
            this.labelEditClientName.Name = "labelEditClientName";
            this.labelEditClientName.Size = new System.Drawing.Size(29, 13);
            this.labelEditClientName.TabIndex = 7;
            this.labelEditClientName.Text = "Имя";
            // 
            // textBoxEditClientCreationDate
            // 
            this.textBoxEditClientCreationDate.Location = new System.Drawing.Point(14, 76);
            this.textBoxEditClientCreationDate.Name = "textBoxEditClientCreationDate";
            this.textBoxEditClientCreationDate.Size = new System.Drawing.Size(154, 20);
            this.textBoxEditClientCreationDate.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 448);
            this.Controls.Add(this.groupBoxEditClient);
            this.Controls.Add(this.groupBoxCreateClient);
            this.Controls.Add(this.buttonDeleteClient);
            this.Controls.Add(this.buttonGetClients);
            this.Controls.Add(this.dataGridView);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxCreateClient.ResumeLayout(false);
            this.groupBoxCreateClient.PerformLayout();
            this.groupBoxEditClient.ResumeLayout(false);
            this.groupBoxEditClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonGetClients;
        private System.Windows.Forms.Button buttonEditClient;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.Button buttonCreateClient;
        private System.Windows.Forms.TextBox textBoxAddClientPayment;
        private System.Windows.Forms.Label labelAddClientPayment;
        private System.Windows.Forms.TextBox textBoxAddClientName;
        private System.Windows.Forms.TextBox textBoxAddClientCreationDate;
        private System.Windows.Forms.Label labelAddClientName;
        private System.Windows.Forms.Label labelAddClientCreationDate;
        private System.Windows.Forms.GroupBox groupBoxCreateClient;
        private System.Windows.Forms.GroupBox groupBoxEditClient;
        private System.Windows.Forms.TextBox textBoxEditClientName;
        private System.Windows.Forms.TextBox textBoxEditClientPayment;
        private System.Windows.Forms.Label labelEditClientPayment;
        private System.Windows.Forms.Label labelEditClientCreationDate;
        private System.Windows.Forms.Label labelEditClientName;
        private System.Windows.Forms.TextBox textBoxEditClientCreationDate;
    }
}

