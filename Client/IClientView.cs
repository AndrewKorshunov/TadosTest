using System;
using System.Collections.Generic;
using ClientsLibrary;

namespace ClientApp
{
    public interface IClientView
    {        
        // Suffix *ed for events, which already fired,
        // but for events like "Added" you need to get confirmation from server first.
        event Action AllClientsRequsted;
        event Action ClientCreating;
        event Action ClientEditing;
        event Action ClientEdited;
        event Action ClientRemoving;
        event Action ViewClosing;

        bool IsClientSelected { get; }
        int SelectedClientIndex { get; }
        
        void DisplayClient(params object[] clientFields);
        void BuildViewWithFields(params string[] fieldNames);
        void ClearView();
        void ShowView();

        // This should be in AddClientView 
        string AddClientName { get; }
        string AddClientCreationDate { get; }
        string AddClientPayment { get; }

        // This should be in AddClientView 
        string EditClientName { get; set; }
        string EditClientCreationDate { get; set; }
        string EditClientPayment { get; set; }
    }
}
