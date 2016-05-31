using System;
using ClientsLibrary;

namespace ClientApp
{
    class EditClientPresenter
    {
        private readonly IEditClientView view;
        private readonly IClientRepository clientRepository;
        private int clientToEditId;

        public EditClientPresenter(IEditClientView view, IClientRepository clientRepo)
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
            clientRepository.ReplaceAt(clientToEditId, newClient);
            view.CloseView();
        }

        public void Start(int clientId)            
        {            
            this.clientToEditId = clientId;
            var client = clientRepository[clientId];
            view.FillEditFields(client.Name, client.CreationDate.ToString(), client.Payment.ToString());
            view.ShowView();
        }
    }
}
