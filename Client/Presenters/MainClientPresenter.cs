using System;
using System.Collections.Generic;
using ClientsLibrary;

namespace ClientApp
{
    class MainPresenter
    {
        private readonly ClientRepository clientRepository;
        private readonly IMainClientView view;

        private readonly EditClientPresenter editClientPresenter;
        private readonly AddClientPresenter addClientPresenter;


        public MainPresenter(IMainClientView view, ClientRepository clientRepo)
        {
            // Move it somewhere?
            addClientPresenter = new AddClientPresenter(new AddClientForm(), clientRepo);
            editClientPresenter = new EditClientPresenter(new EditClientForm(), clientRepo);

            this.view = view;
            this.clientRepository = clientRepo;

            view.BuildViewWithFields("Name", "CreationDate", "Payment");
            HookUpViewEvents();
        }

        public void AddClient()
        {
            addClientPresenter.Start();
        }

        public void EditClient()
        {
            if(view.IsClientSelected)
                editClientPresenter.Start(clientRepository[view.SelectedClientIndex]);
        }
        
        public void GetAllClients()
        {
            DisplayClients(clientRepository.GetAllClients());
        }       
        
        public void RemoveClient()
        {
            if (view.IsClientSelected)
            {
                clientRepository.RemoveClient(view.SelectedClientIndex);
                DisplayClients(clientRepository.AllClients());
            }
        }

        public void Start()
        {
            view.ShowView();
        }

        private void DisplayClients(IEnumerable<ClientEntity> clients)
        {
            view.ClearView();
            foreach (var client in clients)
                view.DisplayClient(client.Name, client.CreationDate, client.Payment);
        }

        private void HookUpViewEvents()
        {
            view.AllClientsRequsted += GetAllClients;
            view.ClientCreating += AddClient;
            view.ClientEditing += EditClient;
            view.ClientRemoving += RemoveClient;
        }
    }
}
