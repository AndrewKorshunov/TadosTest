using System;

namespace ClientApp
{
    interface IMainClientView
    {
        event Action AllClientsRequsted;
        event Action ClientCreating;
        event Action ClientEditing;
        event Action ClientRemoving;
        event Action MainViewClosing;

        bool IsClientSelected { get; }
        int SelectedClientIndex { get; }

        void BuildViewWithFields(params string[] fieldNames);
        void ClearView();
        void DisplayClient(params object[] clientFields);
        void ShowError(string text);        
        void ShowView();
    }
}
