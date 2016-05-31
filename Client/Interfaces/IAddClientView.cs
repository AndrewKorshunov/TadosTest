using System;

namespace ClientApp
{
    interface IAddClientView
    {
        event Action ClientCreated;

        string ClientCreationDate { get; }
        string ClientName { get; }        
        string ClientPayment { get; }

        void CloseView();
        void ShowError(string text);
        void ShowView();
    }
}
