using ClientsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    class AddClientPresenter
    {
        private readonly ClientRepository clientRepository;
        private readonly IAddClientView view;

        public AddClientPresenter(IAddClientView view, ClientRepository clientRepo)
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

            clientRepository.AddClient(newClient);
            view.CloseView();
        }

        public void Start()
        {
            view.ShowView();
        }
    }
}
