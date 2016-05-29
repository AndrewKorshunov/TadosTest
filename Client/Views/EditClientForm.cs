using System;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class EditClientForm : Form, IEditClientView
    {
        public EditClientForm()
        {
            InitializeComponent();

            buttonEditClient.Click += (sender, args) => InvokeEvent(ClientEdited);
        }

        public string ClientName
        {
            get { return textBoxEditClientName.Text; }
            private set { textBoxEditClientName.Text = value; }
        }
        public string ClientCreationDate
        {
            get { return textBoxEditClientCreationDate.Text; }
            private set { textBoxEditClientCreationDate.Text = value; }
        }
        public string ClientPayment
        {
            get { return textBoxEditClientPayment.Text; }
            private set { textBoxEditClientPayment.Text = value; }
        }

        public event Action ClientEdited;

        public void CloseView()
        {
            this.Close();
        }

        public void FillEditFields(string clientName, string clientCreationDate, string clientPayment)
        {
            this.ClientName = clientName;
            this.ClientCreationDate = clientCreationDate;
            this.ClientPayment = clientPayment;
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
