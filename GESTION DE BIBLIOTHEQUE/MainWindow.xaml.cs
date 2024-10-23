using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GESTION_DE_BIBLIOTHEQUE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string UserName = "admin";
        string Password = "admin";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Connecter_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NomUser.Text) || string.IsNullOrEmpty(MotDePasse.Password))
            {
                erreur.Content = "Veuillez remplir tous les champs";
            }
            else if (NomUser.Text == UserName && MotDePasse.Password == Password)
            {
                HomePage homePage = new HomePage();
                this.Close();
                homePage.Show();

            }
            else
            {
                erreur.Content = "Nom d'utilisateur ou mot de passe incorrect";
            }

        }
    }
}