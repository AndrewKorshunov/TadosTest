using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class EditClientForm : Form, IEditClientView
    {
        public EditClientForm()
        {
            InitializeComponent();
        }

        private void buttonSaveClient_Click(object sender, EventArgs e)
        {
            if (ClientSaving != null)
                ClientSaving();
        }

        public void ShowView()
        {
            ShowDialog();
        }

        public event Action ClosingView;
        public event Action ClientSaving;

        private void EditClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ClosingView != null)
                ClosingView();
        }
    }
}
