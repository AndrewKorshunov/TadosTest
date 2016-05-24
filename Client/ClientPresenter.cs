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
            foreach (var client in clients)
            {
                view.DisplayClient(client.Name, client.CreationDate, client.Payment);
            }
        }
        
        // All this logic should be on different form (view)
        public void AddClient()
        {            
            var client = new ClientEntity()
            {
                Name = view.AddClientName,
                CreationDate = Convert.ToDateTime(view.AddClientCreationDate),
                Payment = Convert.ToDecimal(view.AddClientPayment)
            };

            clientProxy.AddClient(client);
            clients.Add(client);
        }
        
        // All this logic should be on different form (view)
        public void EditClient()
        {
            int id = clients[view.SelectedClientIndex].Id;
            var client = new ClientEntity()
            {
                Name = view.EditClientName,
                CreationDate = Convert.ToDateTime(view.EditClientCreationDate),
                Payment = Convert.ToDecimal(view.EditClientPayment)
            };

            clientProxy.EditClient(id, client);
        }

        public void RemoveClient()
        {
            if (view.IsClientSelected)
            {
                int realId = clients[view.SelectedClientIndex].Id;
                clientProxy.RemoveClient(realId);
                clients.RemoveAt(view.SelectedClientIndex);
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
