namespace ClientApp
{
    partial class AddClientForm
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
            this.textBoxAddClientName = new System.Windows.Forms.TextBox();
            this.buttonCreateClient = new System.Windows.Forms.Button();
            this.textBoxAddClientPayment = new System.Windows.Forms.TextBox();
            this.labelAddClientPayment = new System.Windows.Forms.Label();
            this.labelAddClientCreationDate = new System.Windows.Forms.Label();
            this.labelAddClientName = new System.Windows.Forms.Label();
            this.textBoxAddClientCreationDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxAddClientName
            // 
            this.textBoxAddClientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddClientName.Location = new System.Drawing.Point(16, 27);
            this.textBoxAddClientName.Name = "textBoxAddClientName";
            this.textBoxAddClientName.Size = new System.Drawing.Size(145, 20);
            this.textBoxAddClientName.TabIndex = 10;
            // 
            // buttonCreateClient
            // 
            this.buttonCreateClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateClient.Location = new System.Drawing.Point(15, 130);
            this.buttonCreateClient.Name = "buttonCreateClient";
            this.buttonCreateClient.Size = new System.Drawing.Size(146, 23);
            this.buttonCreateClient.TabIndex = 0;
            this.buttonCreateClient.Text = "Создать";
            this.buttonCreateClient.UseVisualStyleBackColor = true;
            // 
            // textBoxAddClientPayment
            // 
            this.textBoxAddClientPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddClientPayment.Location = new System.Drawing.Point(15, 104);
            this.textBoxAddClientPayment.Name = "textBoxAddClientPayment";
            this.textBoxAddClientPayment.Size = new System.Drawing.Size(146, 20);
            this.textBoxAddClientPayment.TabIndex = 9;
            // 
            // labelAddClientPayment
            // 
            this.labelAddClientPayment.AutoSize = true;
            this.labelAddClientPayment.Location = new System.Drawing.Point(12, 88);
            this.labelAddClientPayment.Name = "labelAddClientPayment";
            this.labelAddClientPayment.Size = new System.Drawing.Size(46, 13);
            this.labelAddClientPayment.TabIndex = 6;
            this.labelAddClientPayment.Text = "Платёж";
            // 
            // labelAddClientCreationDate
            // 
            this.labelAddClientCreationDate.AutoSize = true;
            this.labelAddClientCreationDate.Location = new System.Drawing.Point(12, 50);
            this.labelAddClientCreationDate.Name = "labelAddClientCreationDate";
            this.labelAddClientCreationDate.Size = new System.Drawing.Size(84, 13);
            this.labelAddClientCreationDate.TabIndex = 8;
            this.labelAddClientCreationDate.Text = "Дата создания";
            // 
            // labelAddClientName
            // 
            this.labelAddClientName.AutoSize = true;
            this.labelAddClientName.Location = new System.Drawing.Point(12, 11);
            this.labelAddClientName.Name = "labelAddClientName";
            this.labelAddClientName.Size = new System.Drawing.Size(29, 13);
            this.labelAddClientName.TabIndex = 7;
            this.labelAddClientName.Text = "Имя";
            // 
            // textBoxAddClientCreationDate
            // 
            this.textBoxAddClientCreationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddClientCreationDate.Location = new System.Drawing.Point(15, 66);
            this.textBoxAddClientCreationDate.Name = "textBoxAddClientCreationDate";
            this.textBoxAddClientCreationDate.Size = new System.Drawing.Size(146, 20);
            this.textBoxAddClientCreationDate.TabIndex = 11;
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 169);
            this.Controls.Add(this.textBoxAddClientName);
            this.Controls.Add(this.buttonCreateClient);
            this.Controls.Add(this.textBoxAddClientPayment);
            this.Controls.Add(this.textBoxAddClientCreationDate);
            this.Controls.Add(this.labelAddClientPayment);
            this.Controls.Add(this.labelAddClientName);
            this.Controls.Add(this.labelAddClientCreationDate);
            this.Name = "AddClientForm";
            this.Text = "Add Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddClientName;
        private System.Windows.Forms.Button buttonCreateClient;
        private System.Windows.Forms.TextBox textBoxAddClientPayment;
        private System.Windows.Forms.Label labelAddClientPayment;
        private System.Windows.Forms.Label labelAddClientCreationDate;
        private System.Windows.Forms.Label labelAddClientName;
        private System.Windows.Forms.TextBox textBoxAddClientCreationDate;
    }
}