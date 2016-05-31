using System;

namespace ClientApp
{
    interface IEditClientView
    {
        event Action ClientEdited;

        string ClientCreationDate { get; }
        string ClientName { get; }        
        string ClientPayment { get; }

        void CloseView();
        void FillEditFields(string clientName, string clientCreationDate, string clientPayment);
        void ShowError(string text);
        void ShowView();
    }
}
