using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Souhaib_Salaheddine_imad_UA2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.ResizeMode = ResizeMode.NoResize;
            InitializeComponent();
        }

        // valider
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Vérifier si les champs "User" et "Password" sont remplis
            if (string.IsNullOrWhiteSpace(User.Text) || string.IsNullOrWhiteSpace(Password.Password))
            {
                // Afficher un message d'alerte si un champ est vide
                MessageBox.Show("Veuillez remplir tous les champs.", "Alerte", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                // Ouvrir l'écran Accueil si tous les champs sont remplis
                Accueil accueil = new Accueil();
                accueil.Show();
                this.Hide();
            }
        }



        // oublier mot de pass
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OublierMotdePass oublierMotdePass = new OublierMotdePass();
            oublierMotdePass.Show();
        }

        // cree compte
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CreeCompte creeCompte = new CreeCompte();
            creeCompte.Show();
        }


       
    }
}
