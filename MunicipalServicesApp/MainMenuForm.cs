using System;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();

            btnLocalEvents.Enabled = true;
            btnServiceStatus.Enabled = false;
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            LocalEventsForm eventsWindow = new LocalEventsForm();
            eventsWindow.ShowDialog();
        }
    }
}
