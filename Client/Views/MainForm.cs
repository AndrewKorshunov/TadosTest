﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class MainForm : Form, IClientView
    {
        public MainForm()
        {
            InitializeComponent();

            buttonCreateClient.Click += (sender,args) => InvokeEvent(ClientCreating);
            buttonGetClients.Click += (sender, args) => InvokeEvent(AllClientsRequsted);
            buttonDeleteClient.Click += (sender, args) => InvokeEvent(ClientRemoving);
            buttonEditClient.Click += (sender, args) => InvokeEvent(ClientEdited);

            dataGridView.SelectionChanged += (sender, args) => InvokeEvent(ClientEditing);

            this.FormClosing += (sender, args) => InvokeEvent(ViewClosing);
        }

        public event Action AllClientsRequsted;
        public event Action ClientCreating;
        public event Action ClientEditing;
        public event Action ClientEdited;
        public event Action ClientRemoving;
        public event Action ViewClosing;

        // Should be in AddClientView
        public string AddClientName
        {
            get { return textBoxAddClientName.Text; }
        }
        public string AddClientCreationDate
        {
            get { return textBoxAddClientCreationDate.Text; }
        }
        public string AddClientPayment
        {
            get { return textBoxAddClientPayment.Text; }
        }

        // Should be in EditClientView
        public string EditClientName
        {
            get { return textBoxEditClientName.Text; }
            set { textBoxEditClientName.Text = value; }
        }
        public string EditClientCreationDate
        {
            get { return textBoxEditClientCreationDate.Text; }
            set { textBoxEditClientCreationDate.Text = value; }
        }
        public string EditClientPayment
        {
            get { return textBoxEditClientPayment.Text; }
            set { textBoxEditClientPayment.Text = value; }
        }

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
                dataGridView.Columns[i].Name = fieldNames[i];
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
