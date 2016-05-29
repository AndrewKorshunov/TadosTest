using System;

namespace ClientApp
{
    interface IEditClientView
    {
        event Action ClientEdited;

        string ClientName { get; }
        string ClientCreationDate { get; }
        string ClientPayment { get; }

        void CloseView();
        void FillEditFields(string clientName, string clientCreationDate, string clientPayment);
        void ShowError(string text);
        void ShowView();
    }
}
