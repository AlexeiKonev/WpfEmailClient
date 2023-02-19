using ImapX;
using System.Windows;

namespace WpfEmailClient {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();






        }

        private void Button_Click(object sender, RoutedEventArgs e) {


            ImapClient client = new ImapClient("imap.gmail.com", true);
            if (client.Connect( /* optional, use parameters here */ )) {
                 
                if (client.Login(NameInput.Text, PasswordInput.Text)) {
                  ConnectStatusBox.IsChecked = true;  // login successful
                } // connection successful
            }
            else {
                ConnectStatusBox.IsChecked = false;  // connection not successful
            }

            ;
            //TextS.Content = InputName.Text;
        }

        private void NameInput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) {

        }
    }
}
