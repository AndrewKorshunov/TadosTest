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
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.buttonCreateClient = new System.Windows.Forms.Button();
            this.buttonEditClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(497, 219);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonGetClients
            // 
            this.buttonGetClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGetClients.Location = new System.Drawing.Point(12, 237);
            this.buttonGetClients.Name = "buttonGetClients";
            this.buttonGetClients.Size = new System.Drawing.Size(120, 53);
            this.buttonGetClients.TabIndex = 1;
            this.buttonGetClients.Text = "Получить список всех клиентов";
            this.buttonGetClients.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteClient.Location = new System.Drawing.Point(138, 237);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(120, 53);
            this.buttonDeleteClient.TabIndex = 4;
            this.buttonDeleteClient.Text = "Удалить выбранного клиента";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            // 
            // buttonCreateClient
            // 
            this.buttonCreateClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateClient.Location = new System.Drawing.Point(264, 237);
            this.buttonCreateClient.Name = "buttonCreateClient";
            this.buttonCreateClient.Size = new System.Drawing.Size(120, 53);
            this.buttonCreateClient.TabIndex = 13;
            this.buttonCreateClient.Text = "Создать клиента";
            this.buttonCreateClient.UseVisualStyleBackColor = true;
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditClient.Location = new System.Drawing.Point(390, 237);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(120, 53);
            this.buttonEditClient.TabIndex = 3;
            this.buttonEditClient.Text = "Изменить выбранного клиента";
            this.buttonEditClient.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 302);
            this.Controls.Add(this.buttonCreateClient);
            this.Controls.Add(this.buttonDeleteClient);
            this.Controls.Add(this.buttonEditClient);
            this.Controls.Add(this.buttonGetClients);
            this.Controls.Add(this.dataGridView);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonGetClients;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.Button buttonCreateClient;
        private System.Windows.Forms.Button buttonEditClient;
    }
}

