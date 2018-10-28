using System;
using System.Windows.Forms;
using Ninjacrab.PersistentWindows.Common;
using Ninjacrab.PersistentWindows.WpfShell;

namespace Ninjacrab.PersistentWindows.SystrayShell
{
    public partial class SystrayForm : Form
    {
        public MainWindow MainView { get; set; }

        public SystrayForm()
        {
            InitializeComponent();
        }

      public SystrayForm(PersistentWindowProcessor processor)
      :this()
    {
      _processor = processor;
    }

    private readonly PersistentWindowProcessor _processor;

        private void DiagnosticsToolStripMenuItemClickHandler(object sender, EventArgs e)
        {
            bool shouldShow = false;
            if (this.MainView == null ||
                this.MainView.IsClosed)
            {
                this.MainView = new MainWindow();
                shouldShow = true;
            }

            if (shouldShow)
            {
                this.MainView.Show();
            }
        }

        private void ExitToolStripMenuItemClickHandler(object sender, EventArgs e)
        {
            this.notifyIconMain.Visible = false;
            this.notifyIconMain.Icon = null;
            Application.Exit();
        }

    private void enabledToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _processor.Enabled = !_processor.Enabled;
      enabledToolStripMenuItem.Checked = _processor.Enabled;
    }
  }
}
