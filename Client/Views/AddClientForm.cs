using System;
using System.Windows.Forms;

namespace ClientApp
{
    partial class AddClientForm : Form, IAddClientView
    {
        public AddClientForm()
        {
            InitializeComponent();

            buttonCreateClient.Click += (sender, args) => InvokeEvent(ClientCreated);
        }

        public string ClientCreationDate
        {
            get { return textBoxAddClientCreationDate.Text; }
        }
        public string ClientName
        {
            get { return textBoxAddClientName.Text; }
        }        
        public string ClientPayment
        {
            get { return textBoxAddClientPayment.Text; }
        }

        public event Action ClientCreated;

        public void CloseView()
        {
            this.Close();
        }

        public void ShowError(string text)
        {
            MessageBox.Show(text, "Ошибка");
        }

        public void ShowView()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowDialog();
        }

        private void InvokeEvent(Action action)
        {
            if (action != null)
                action();
        }
    }
}
