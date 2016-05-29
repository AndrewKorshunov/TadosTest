using System;
using System.Collections.Generic;
using ClientsLibrary;

namespace ClientApp
{
    class EditClientPresenter
    {
        private readonly IEditClientView view;
        private readonly ClientRepository clientRepository;
        private int clientId;

        public EditClientPresenter(IEditClientView view, ClientRepository clientRepo)
        {
            this.view = view;
            this.clientRepository = clientRepo;

            view.ClientEdited += SaveEditedClient;
        }

        void SaveEditedClient()
        {
            var newClient = new ClientEntity();
            try // Filter type conversion exceptions from text in textBox
            {
                newClient.Name = view.ClientName;
                newClient.CreationDate = Convert.ToDateTime(view.ClientCreationDate);
                newClient.Payment = Convert.ToDecimal(view.ClientPayment);
            }
            catch (Exception e)
            {
                view.ShowError(e.Message);
                return;
            }

            clientRepository.EditClient(clientId, newClient);
            view.CloseView();
        }

        public void Start(ClientEntity client)
        {
            clientId = client.Id;
            view.FillEditFields(client.Name, client.CreationDate.ToString(), client.Payment.ToString());
            view.ShowView();
        }
    }
}
