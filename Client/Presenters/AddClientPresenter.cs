using System;
using ClientsLibrary;

namespace ClientApp
{
    class AddClientPresenter
    {
        private readonly IClientRepository clientRepository;
        private readonly IAddClientView view;

        public AddClientPresenter(IAddClientView view, IClientRepository clientRepo)
        {
            this.clientRepository = clientRepo;
            this.view = view;

            view.ClientCreated += CreateClient;
        }

        void CreateClient()
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
            clientRepository.Add(newClient);
            view.CloseView();
        }

        public void Start()
        {
            view.ShowView();
        }
    }
}
