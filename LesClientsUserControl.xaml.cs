using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Souhaib_Salaheddine_imad_UA2
{
    public partial class LesClientsUserControl : UserControl
    {
        public ObservableCollection<Client> Clients { get; set; } = new ObservableCollection<Client>();

        public LesClientsUserControl()
        {
            InitializeComponent();
            ClientsDataGrid.ItemsSource = Clients;
            LoadSampleData();  // Charger des données fictives
        }

        private void LoadSampleData()
        {
            Clients.Add(new Client { Code = "C001", Nom = "Dupont", Prenom = "Jean", DateAjout = DateTime.Now });
            Clients.Add(new Client { Code = "C002", Nom = "Martin", Prenom = "Claire", DateAjout = DateTime.Now });
            Clients.Add(new Client { Code = "C003", Nom = "Durand", Prenom = "Lucas", DateAjout = DateTime.Now });
        }

        private void AjouterButton_Click(object sender, RoutedEventArgs e)
        {
            var client = new Client
            {
                Code = CodeTextBox.Text,
                Nom = NomTextBox.Text,
                Prenom = PrenomTextBox.Text,
                DateAjout = DateAjoutPicker.SelectedDate ?? DateTime.Now
            };

            Clients.Add(client);
            ClearForm();
        }

        private void ModifierButton_Click(object sender, RoutedEventArgs e)
        {
            if (ClientsDataGrid.SelectedItem is Client selectedClient)
            {
                selectedClient.Code = CodeTextBox.Text;
                selectedClient.Nom = NomTextBox.Text;
                selectedClient.Prenom = PrenomTextBox.Text;
                selectedClient.DateAjout = DateAjoutPicker.SelectedDate ?? DateTime.Now;
            }
        }

        private void SupprimerButton_Click(object sender, RoutedEventArgs e)
        {
            if (ClientsDataGrid.SelectedItem is Client selectedClient)
            {
                Clients.Remove(selectedClient);
            }
        }

        private void ClearForm()
        {
            CodeTextBox.Clear();
            NomTextBox.Clear();
            PrenomTextBox.Clear();
            DateAjoutPicker.SelectedDate = null;
        }
    }

    public class Client
    {
        public string Code { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateAjout { get; set; }
    }
}
