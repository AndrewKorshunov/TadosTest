using System;
using System.Windows.Forms;

namespace ClientApp
{
    partial class MainForm : Form, IMainClientView
    {
        public MainForm()
        {
            InitializeComponent();

            buttonCreateClient.Click += (sender,args) => InvokeEvent(ClientCreating);
            buttonGetClients.Click += (sender, args) => InvokeEvent(AllClientsRequested);
            buttonDeleteClient.Click += (sender, args) => InvokeEvent(ClientRemoving);
            buttonEditClient.Click += (sender, args) => InvokeEvent(ClientEditing);

            this.FormClosing += (sender, args) => InvokeEvent(MainViewClosing);
        }

        public event Action AllClientsRequested;
        public event Action ClientCreating;
        public event Action ClientEditing;
        public event Action ClientRemoving;
        public event Action MainViewClosing;
        
        public bool IsClientSelected
        {
            get { return dataGridView.SelectedRows != null && dataGridView.SelectedRows.Count != 0; }
        }
        public int SelectedClientIndex
        {
            get { return dataGridView.SelectedRows[0].Index; }
        }

        public void BuildViewWithFields(params string[] fieldNames)
        {
            dataGridView.ColumnCount = fieldNames.Length;
            for (int i = 0; i < fieldNames.Length; i++)
            {
                dataGridView.Columns[i].Name = fieldNames[i];
                dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public void ClearView()
        {
            dataGridView.Rows.Clear();
        }

        public void DisplayClient(params object[] clientParameters)
        {
            dataGridView.Rows.Add(clientParameters);
        }

        public void ShowError(string text)
        {
            MessageBox.Show(text, "Ошибка");
        }

        public void ShowView()
        {
            Application.Run(this);
        }

        private void InvokeEvent(Action action)
        {
            if (action != null)
                action();
        }
    }
}
