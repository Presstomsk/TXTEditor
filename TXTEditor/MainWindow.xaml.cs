
using System.IO;
using System.Windows;


namespace TXTEditor
{

    public partial class MainWindow : Window
    {
        string path = null;
        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            TextB.Text = FileDialogues.OpenFile(out string strPath);
            path = strPath;
        }

        private void SaveAs_Click(object sender, RoutedEventArgs e)
        {
            FileDialogues.SaveAsFile(TextB.Text, out string strPath);
            path = strPath;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (path == null)
            {
                FileDialogues.SaveAsFile(TextB.Text, out string strPath);
                path = strPath;
                return;
            }
            File.WriteAllText(path, TextB.Text);
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
