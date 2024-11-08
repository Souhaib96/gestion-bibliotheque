using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Souhaib_Salaheddine_imad_UA2
{
    public partial class LesUtilisateurUserControl : UserControl
    {
        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();

        public LesUtilisateurUserControl()
        {
            InitializeComponent();
            DataContext = this;  // Associer le contexte de données à l'utilisateur
            LoadSampleData();  // Charger des données fictives
        }

        private void LoadSampleData()
        {
            Users.Add(new User { Nom = "Dupont", Prenom = "Jean", DateNaissance = new DateTime(1990, 1, 1), Username = "jdupont" });
            Users.Add(new User { Nom = "Martin", Prenom = "Claire", DateNaissance = new DateTime(1985, 5, 23), Username = "cmartin" });
            Users.Add(new User { Nom = "Durand", Prenom = "Sophie", DateNaissance = new DateTime(2000, 8, 15), Username = "sdurand" });
        }

        private void AjouterButton_Click(object sender, RoutedEventArgs e)
        {
            var user = new User
            {
                Nom = NomTextBox.Text,
                Prenom = PrenomTextBox.Text,
                DateNaissance = DateNaissancePicker.SelectedDate,
                Username = UsernameTextBox.Text
            };

            Users.Add(user);
            ClearForm();
        }

        private void ModifierButton_Click(object sender, RoutedEventArgs e)
        {
            if (UsersDataGrid.SelectedItem is User selectedUser)
            {
                selectedUser.Nom = NomTextBox.Text;
                selectedUser.Prenom = PrenomTextBox.Text;
                selectedUser.DateNaissance = DateNaissancePicker.SelectedDate;
                selectedUser.Username = UsernameTextBox.Text;
            }
        }

        private void SupprimerButton_Click(object sender, RoutedEventArgs e)
        {
            if (UsersDataGrid.SelectedItem is User selectedUser)
            {
                Users.Remove(selectedUser);
            }
        }

        private void ClearForm()
        {
            NomTextBox.Clear();
            PrenomTextBox.Clear();
            DateNaissancePicker.SelectedDate = null;
            UsernameTextBox.Clear();
            PasswordBox.Clear();
        }
    }

    public class User
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime? DateNaissance { get; set; }
        public string Username { get; set; }
    }
}
