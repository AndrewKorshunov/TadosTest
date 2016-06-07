using System;
using System.Collections.Generic;
using ClientsLibrary;

namespace ClientApp
{
    class MainPresenter
    {
        private readonly IClientRepository clientRepository;
        private readonly IMainClientView view;

        private readonly AddClientPresenter addClientPresenter;
        private readonly EditClientPresenter editClientPresenter;        

        public MainPresenter(IMainClientView view, IClientRepository clientRepo)
        {
            // Move it somewhere?
            addClientPresenter = new AddClientPresenter(new AddClientForm(), clientRepo);
            editClientPresenter = new EditClientPresenter(new EditClientForm(), clientRepo);

            this.view = view;
            this.clientRepository = clientRepo;

            view.BuildViewWithFields("Name", "CreationDate", "Payment");
            HookUpViewEvents();
            clientRepository.RepositoryChanged += () => DisplayClients(clientRepo);
        }

        public void AddClient()
        {
            addClientPresenter.Start();
        }

        public void EditClient()
        {
            if(view.IsClientSelected)
                editClientPresenter.Start(view.SelectedClientIndex);
        }
        
        public void GetAllClients()
        {
            clientRepository.ForceUpdate();
            DisplayClients(clientRepository);
        }       
        
        public void RemoveClient()
        {
            if (view.IsClientSelected)            
                clientRepository.RemoveAt(view.SelectedClientIndex);            
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
            view.AllClientsRequested += GetAllClients;
            view.ClientCreating += AddClient;
            view.ClientEditing += EditClient;
            view.ClientRemoving += RemoveClient;
        }
    }
}
