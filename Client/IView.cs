using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    public interface IView
    {
        void ShowView();
        event Action ClosingView;
    }
}
