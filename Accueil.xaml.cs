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
using System.Windows.Shapes;


namespace Souhaib_Salaheddine_imad_UA2
{
    public partial class Accueil : Window
    {
        public Accueil()
        {
            this.ResizeMode = ResizeMode.NoResize;
            InitializeComponent();

        }

        private void AccueilButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new AccueilUserControl(); 
        }

        private void LesUtilisateurButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new LesUtilisateurUserControl();
        }

        private void LesLivresButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new LesLivresUserControl();
        }

        private void LesClientsButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new LesClientsUserControl();
        }

        private void LesCommandesButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new LesCommandesUserControl();
        }
    }
}