using System.Windows;

namespace GimosBrowser
{
    public partial class DebugLog : Window
    {
        public DebugLog()
        {
            InitializeComponent();
            LoadDebugLog();
        }

        // Load debug log content into the TextBox
        private void LoadDebugLog()
        {
            // For demonstration purposes, you can add sample logs here
            LogTextBox.Text = "Debugging started...\n";
            LogTextBox.AppendText("Navigated to: http://example.com\n");
            LogTextBox.AppendText("Error: Failed to load resource xyz.js\n");
            LogTextBox.AppendText("Reloaded the page at 12:34 PM\n");
        }
    }
}
