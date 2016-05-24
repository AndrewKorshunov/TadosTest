using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientApp
{
    class EditClientPresenter
    {
        IEditClientView view;

        public EditClientPresenter(IEditClientView view)
        {
            this.view = view;
        }
    }
}