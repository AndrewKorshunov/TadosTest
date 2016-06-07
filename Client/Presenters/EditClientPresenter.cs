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

        public void Start(int clientId)            
        {
            this.clientToEditId = clientId;
            var client = clientRepository[clientId];
            view.FillEditFields(client.Name, client.CreationDate.ToString(), client.Payment.ToString());
            view.ShowView();
        }

        private void SaveEditedClient()
        {
            var newClient = new ClientEntity();
            try // Filter type conversion exceptions from text in textBox
            {
                newClient.Name = view.ClientName;
                newClient.CreationDate = DateTime.Parse(view.ClientCreationDate);
                newClient.Payment = decimal.Parse(view.ClientPayment, System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (Exception e)
            {
                view.ShowError(e.Message);
                return;
            }
            clientRepository.ReplaceAt(clientToEditId, newClient);
            view.CloseView();
        }
    }
}
