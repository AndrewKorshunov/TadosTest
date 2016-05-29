namespace ClientApp
{
    partial class EditClientForm
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
            this.textBoxEditClientName = new System.Windows.Forms.TextBox();
            this.textBoxEditClientPayment = new System.Windows.Forms.TextBox();
            this.labelEditClientPayment = new System.Windows.Forms.Label();
            this.buttonEditClient = new System.Windows.Forms.Button();
            this.labelEditClientCreationDate = new System.Windows.Forms.Label();
            this.labelEditClientName = new System.Windows.Forms.Label();
            this.textBoxEditClientCreationDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxEditClientName
            // 
            this.textBoxEditClientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEditClientName.Location = new System.Drawing.Point(12, 25);
            this.textBoxEditClientName.Name = "textBoxEditClientName";
            this.textBoxEditClientName.Size = new System.Drawing.Size(153, 20);
            this.textBoxEditClientName.TabIndex = 17;
            // 
            // textBoxEditClientPayment
            // 
            this.textBoxEditClientPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEditClientPayment.Location = new System.Drawing.Point(11, 102);
            this.textBoxEditClientPayment.Name = "textBoxEditClientPayment";
            this.textBoxEditClientPayment.Size = new System.Drawing.Size(154, 20);
            this.textBoxEditClientPayment.TabIndex = 16;
            // 
            // labelEditClientPayment
            // 
            this.labelEditClientPayment.AutoSize = true;
            this.labelEditClientPayment.Location = new System.Drawing.Point(8, 86);
            this.labelEditClientPayment.Name = "labelEditClientPayment";
            this.labelEditClientPayment.Size = new System.Drawing.Size(46, 13);
            this.labelEditClientPayment.TabIndex = 13;
            this.labelEditClientPayment.Text = "Платёж";
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditClient.Location = new System.Drawing.Point(12, 128);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(153, 23);
            this.buttonEditClient.TabIndex = 0;
            this.buttonEditClient.Text = "Изменить";
            this.buttonEditClient.UseVisualStyleBackColor = true;
            // 
            // labelEditClientCreationDate
            // 
            this.labelEditClientCreationDate.AutoSize = true;
            this.labelEditClientCreationDate.Location = new System.Drawing.Point(8, 48);
            this.labelEditClientCreationDate.Name = "labelEditClientCreationDate";
            this.labelEditClientCreationDate.Size = new System.Drawing.Size(84, 13);
            this.labelEditClientCreationDate.TabIndex = 15;
            this.labelEditClientCreationDate.Text = "Дата создания";
            // 
            // labelEditClientName
            // 
            this.labelEditClientName.AutoSize = true;
            this.labelEditClientName.Location = new System.Drawing.Point(9, 9);
            this.labelEditClientName.Name = "labelEditClientName";
            this.labelEditClientName.Size = new System.Drawing.Size(29, 13);
            this.labelEditClientName.TabIndex = 14;
            this.labelEditClientName.Text = "Имя";
            // 
            // textBoxEditClientCreationDate
            // 
            this.textBoxEditClientCreationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEditClientCreationDate.Location = new System.Drawing.Point(11, 64);
            this.textBoxEditClientCreationDate.Name = "textBoxEditClientCreationDate";
            this.textBoxEditClientCreationDate.Size = new System.Drawing.Size(154, 20);
            this.textBoxEditClientCreationDate.TabIndex = 18;
            // 
            // EditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 161);
            this.Controls.Add(this.textBoxEditClientName);
            this.Controls.Add(this.textBoxEditClientPayment);
            this.Controls.Add(this.labelEditClientPayment);
            this.Controls.Add(this.buttonEditClient);
            this.Controls.Add(this.labelEditClientCreationDate);
            this.Controls.Add(this.labelEditClientName);
            this.Controls.Add(this.textBoxEditClientCreationDate);
            this.Name = "EditClientForm";
            this.Text = "Edit Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEditClientName;
        private System.Windows.Forms.TextBox textBoxEditClientPayment;
        private System.Windows.Forms.Label labelEditClientPayment;
        private System.Windows.Forms.Button buttonEditClient;
        private System.Windows.Forms.Label labelEditClientCreationDate;
        private System.Windows.Forms.Label labelEditClientName;
        private System.Windows.Forms.TextBox textBoxEditClientCreationDate;
    }
}