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
            var repo = new ClientRepository(proxy);
            var presenter = new MainPresenter(view, repo);

            presenter.Start();
        }
    }
}
