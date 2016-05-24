using System;
using System.Windows.Forms;
using ClientsLibrary;
using System.Collections.Generic;

namespace ClientApp
{
    public class MainPresenter
    {
        private readonly IClientView view;
        private readonly ClientProxy clientProxy;

        private List<ClientEntity> clients;

        public MainPresenter(IClientView view, ClientProxy clientProxy)
        {
            this.view = view;
            this.clientProxy = clientProxy;            
            clients = new List<ClientEntity>();

            view.BuildViewWithFields("Name", "CreationDate", "Payment");
            HookUpViewEvents();
        }

        public void GetAllClients()
        {
            clients = new List<ClientEntity>(clientProxy.GetAllClients());
            view.ClearView();
            DisplayClients();
        }
        
        // All this logic should be on different form (view)
        public void AddClient()
        {
            var client = new ClientEntity();

            // Filter type conversion exceptions from textBox
            try
            {
                client.Name = view.AddClientName;
                client.CreationDate = Convert.ToDateTime(view.AddClientCreationDate);
                client.Payment = Convert.ToDecimal(view.AddClientPayment);
            }
            catch (Exception e)
            {
                view.ShowError(e.Message);
                return;
            }

            clientProxy.AddClient(client);
            clients.Add(client);

            DisplayClients();
        }
        
        // All this logic should be on different form (view)
        public void EditClient()
        {
            int id = clients[view.SelectedClientIndex].Id;
            var newClient = new ClientEntity();

            // Filter type conversion exceptions from textBox
            try
            {
                newClient.Name = view.EditClientName;
                newClient.CreationDate = Convert.ToDateTime(view.EditClientCreationDate);
                newClient.Payment = Convert.ToDecimal(view.EditClientPayment);
            }
            catch (Exception e)
            {
                view.ShowError(e.Message);
                return;
            }
            clientProxy.EditClient(id, newClient);
            clients[view.SelectedClientIndex].Name = newClient.Name;
            clients[view.SelectedClientIndex].CreationDate = newClient.CreationDate;
            clients[view.SelectedClientIndex].Payment = newClient.Payment;

            DisplayClients();
        }

        public void RemoveClient()
        {
            if (view.IsClientSelected)
            {
                int realId = clients[view.SelectedClientIndex].Id;
                clientProxy.RemoveClient(realId);
                clients.RemoveAt(view.SelectedClientIndex);
                DisplayClients();
            }
        }

        // This should be in ClientEditView
        public void FillClientEditFields()
        {
            if (view.IsClientSelected)
            {
                var selectedClient = clients[view.SelectedClientIndex];
                view.EditClientName = selectedClient.Name;
                view.EditClientCreationDate = selectedClient.CreationDate.ToString();
                view.EditClientPayment = selectedClient.Payment.ToString();
            }
        }

        private void DisplayClients()
        {
            view.ClearView();
            foreach(var client in clients)
                view.DisplayClient(client.Name, client.CreationDate, client.Payment);
        }

        public void Start()
        {
            clientProxy.Open();
            view.ShowView();
        }

        private void Close()
        {
            clientProxy.Close();
        }       

        private void HookUpViewEvents()
        {
            view.AllClientsRequsted += GetAllClients;
            view.ClientCreating += AddClient;
            view.ClientEdited += EditClient;
            view.ClientRemoving += RemoveClient;
            view.ViewClosing += Close;
            view.ClientEditing += FillClientEditFields;
        }
    }
}
