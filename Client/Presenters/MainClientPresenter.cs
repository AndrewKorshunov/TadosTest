using System;
using System.Collections.Generic;
using ClientsLibrary;

namespace ClientApp
{
    class MainPresenter
    {
        private readonly ClientProxy clientProxy;
        private readonly IMainClientView view;

        private readonly EditClientPresenter editClientPresenter;
        private readonly AddClientPresenter addClientPresenter;

        private List<ClientEntity> clients;

        public MainPresenter(IMainClientView view, ClientProxy clientProxy)
        {
            // Move it somewhere?
            addClientPresenter = new AddClientPresenter(new AddClientForm(), clientProxy);
            editClientPresenter = new EditClientPresenter(new EditClientForm(), clientProxy);

            this.view = view;
            this.clientProxy = clientProxy;            
            clients = new List<ClientEntity>();
            view.BuildViewWithFields("Name", "CreationDate", "Payment");
            HookUpViewEvents();
        }

        public void AddClient()
        {
            //Show ClientAddForm
            addClientPresenter.Start();

            /*
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
            */
        }

        public void EditClient()
        {
            // Show ClientEditForm
            if(view.IsClientSelected)
                editClientPresenter.Start(clients[view.SelectedClientIndex]);

            /*
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
            */
        }
        
        public void GetAllClients()
        {
            clients = new List<ClientEntity>(clientProxy.GetAllClients());
            view.ClearView();
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

        public void Start()
        {
            clientProxy.Open();
            view.ShowView();
        }

        private void DisplayClients()
        {
            view.ClearView();
            foreach (var client in clients)
                view.DisplayClient(client.Name, client.CreationDate, client.Payment);
        }

        private void Close()
        {
            clientProxy.Close();
        }       

        private void HookUpViewEvents()
        {
            view.AllClientsRequsted += GetAllClients;
            view.ClientCreating += AddClient;
            view.ClientEditing += EditClient;
            view.ClientRemoving += RemoveClient;
            view.MainViewClosing += Close;            
        }
    }
}
