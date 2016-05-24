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
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.labelPayment = new System.Windows.Forms.Label();
            this.textBoxCreationDate = new System.Windows.Forms.TextBox();
            this.labelCreationDate = new System.Windows.Forms.Label();
            this.buttonSaveClient = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Location = new System.Drawing.Point(15, 102);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(100, 20);
            this.textBoxPayment.TabIndex = 4;
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Location = new System.Drawing.Point(12, 86);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(46, 13);
            this.labelPayment.TabIndex = 3;
            this.labelPayment.Text = "Платёж";
            // 
            // textBoxCreationDate
            // 
            this.textBoxCreationDate.Location = new System.Drawing.Point(15, 64);
            this.textBoxCreationDate.Name = "textBoxCreationDate";
            this.textBoxCreationDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxCreationDate.TabIndex = 4;
            // 
            // labelCreationDate
            // 
            this.labelCreationDate.AutoSize = true;
            this.labelCreationDate.Location = new System.Drawing.Point(12, 48);
            this.labelCreationDate.Name = "labelCreationDate";
            this.labelCreationDate.Size = new System.Drawing.Size(84, 13);
            this.labelCreationDate.TabIndex = 3;
            this.labelCreationDate.Text = "Дата создания";
            // 
            // buttonSaveClient
            // 
            this.buttonSaveClient.Location = new System.Drawing.Point(15, 128);
            this.buttonSaveClient.Name = "buttonSaveClient";
            this.buttonSaveClient.Size = new System.Drawing.Size(101, 23);
            this.buttonSaveClient.TabIndex = 2;
            this.buttonSaveClient.Text = "Сохранить";
            this.buttonSaveClient.UseVisualStyleBackColor = true;
            this.buttonSaveClient.Click += new System.EventHandler(this.buttonSaveClient_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(16, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Имя";
            // 
            // EditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(131, 168);
            this.Controls.Add(this.textBoxPayment);
            this.Controls.Add(this.labelPayment);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxCreationDate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCreationDate);
            this.Controls.Add(this.buttonSaveClient);
            this.Name = "EditClientForm";
            this.Text = "EditClientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditClientForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.TextBox textBoxCreationDate;
        private System.Windows.Forms.Label labelCreationDate;
        private System.Windows.Forms.Button buttonSaveClient;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;

    }
}