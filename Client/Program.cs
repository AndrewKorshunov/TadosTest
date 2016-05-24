using System;
using System.Windows.Forms;

namespace ClientApp
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var view = new MainForm();
            var proxy = new ClientProxy();
            var presenter = new MainPresenter(view, proxy);

            presenter.Start();
        }
    }
}
