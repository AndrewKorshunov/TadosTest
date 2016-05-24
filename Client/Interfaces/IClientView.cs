using System;

namespace ClientApp
{
    public interface IClientView
    {
        event Action AllClientsRequsted;
        event Action ClientCreating;
        event Action ClientEditing;
        event Action ClientEdited;
        event Action ClientRemoving;
        event Action ViewClosing;

        bool IsClientSelected { get; }
        int SelectedClientIndex { get; }
        
        // This should be in AddClientView 
        string AddClientName { get; }
        string AddClientCreationDate { get; }
        string AddClientPayment { get; }

        // This should be in AddClientView 
        string EditClientName { get; set; }
        string EditClientCreationDate { get; set; }
        string EditClientPayment { get; set; }

        void BuildViewWithFields(params string[] fieldNames);
        void ClearView();
        void DisplayClient(params object[] clientFields);
        void ShowError(string text);        
        void ShowView();        
    }
}
