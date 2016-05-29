using System;

namespace ClientApp
{
    interface IAddClientView
    {
        event Action ClientCreated;

        string ClientName { get; }
        string ClientCreationDate { get; }
        string ClientPayment { get; }

        void CloseView();
        void ShowError(string text);
        void ShowView();
    }
}
