using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Souhaib_Salaheddine_imad_UA2
{
    public partial class LesLivresUserControl : UserControl
    {
        public ObservableCollection<Livre> Livres { get; set; } = new ObservableCollection<Livre>();

        public LesLivresUserControl()
        {
            InitializeComponent();
            LivresDataGrid.ItemsSource = Livres;
            LoadSampleData();  // Charger des données fictives
        }

        private void LoadSampleData()
        {
            Livres.Add(new Livre { Titre = "1984", Auteur = "George Orwell", DatePublication = new DateTime(1949, 6, 8), Isbn = "978-0451524935" });
            Livres.Add(new Livre { Titre = "Le Petit Prince", Auteur = "Antoine de Saint-Exupéry", DatePublication = new DateTime(1943, 4, 6), Isbn = "978-0156012195" });
            Livres.Add(new Livre { Titre = "Moby Dick", Auteur = "Herman Melville", DatePublication = new DateTime(1851, 10, 18), Isbn = "978-1503280786" });
        }

        private void AjouterButton_Click(object sender, RoutedEventArgs e)
        {
            var livre = new Livre
            {
                Titre = TitreTextBox.Text,
                Auteur = AuteurTextBox.Text,
                DatePublication = DatePublicationPicker.SelectedDate,
                Isbn = IsbnTextBox.Text
            };

            Livres.Add(livre);
            ClearForm();
        }

        private void ModifierButton_Click(object sender, RoutedEventArgs e)
        {
            if (LivresDataGrid.SelectedItem is Livre selectedLivre)
            {
                selectedLivre.Titre = TitreTextBox.Text;
                selectedLivre.Auteur = AuteurTextBox.Text;
                selectedLivre.DatePublication = DatePublicationPicker.SelectedDate;
                selectedLivre.Isbn = IsbnTextBox.Text;
            }
        }

        private void SupprimerButton_Click(object sender, RoutedEventArgs e)
        {
            if (LivresDataGrid.SelectedItem is Livre selectedLivre)
            {
                Livres.Remove(selectedLivre);
            }
        }

        private void ClearForm()
        {
            TitreTextBox.Clear();
            AuteurTextBox.Clear();
            DatePublicationPicker.SelectedDate = null;
            IsbnTextBox.Clear();
        }
    }

    public class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public DateTime? DatePublication { get; set; }
        public string Isbn { get; set; }
    }
}
