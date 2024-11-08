using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Souhaib_Salaheddine_imad_UA2
{
    public partial class LesCommandesUserControl : UserControl
    {
        public ObservableCollection<Commande> Commandes { get; set; } = new ObservableCollection<Commande>();

        public LesCommandesUserControl()
        {
            InitializeComponent();
            CommandesDataGrid.ItemsSource = Commandes;
            LoadSampleData();  // Charger des données fictives
            LoadClients();     // Charger les clients fictifs
            LoadLivres();      // Charger les livres fictifs
        }

        private void LoadSampleData()
        {
            Commandes.Add(new Commande { Client = "Jean Dupont", Livre = "Livre A", DateCommande = DateTime.Now });
            Commandes.Add(new Commande { Client = "Claire Martin", Livre = "Livre B", DateCommande = DateTime.Now });
        }

        private void LoadClients()
        {
            // Simuler le chargement des clients
            ClientComboBox.Items.Add("Jean Dupont");
            ClientComboBox.Items.Add("Claire Martin");
        }

        private void LoadLivres()
        {
            // Simuler le chargement des livres
            LivreComboBox.Items.Add("Livre A");
            LivreComboBox.Items.Add("Livre B");
            LivreComboBox.Items.Add("Livre C");
        }

        private void AjouterButton_Click(object sender, RoutedEventArgs e)
        {
            var commande = new Commande
            {
                Client = ClientComboBox.Text,
                Livre = LivreComboBox.Text,
                DateCommande = DateCommandePicker.SelectedDate ?? DateTime.Now
            };

            Commandes.Add(commande);
            ClearForm();
        }

        private void ModifierButton_Click(object sender, RoutedEventArgs e)
        {
            if (CommandesDataGrid.SelectedItem is Commande selectedCommande)
            {
                selectedCommande.Client = ClientComboBox.Text;
                selectedCommande.Livre = LivreComboBox.Text;
                selectedCommande.DateCommande = DateCommandePicker.SelectedDate ?? DateTime.Now;
            }
        }

        private void SupprimerButton_Click(object sender, RoutedEventArgs e)
        {
            if (CommandesDataGrid.SelectedItem is Commande selectedCommande)
            {
                Commandes.Remove(selectedCommande);
            }
        }

        private void ClearForm()
        {
            ClientComboBox.SelectedIndex = -1;
            LivreComboBox.SelectedIndex = -1;
            DateCommandePicker.SelectedDate = null;
        }
    }

    public class Commande
    {
        public string Client { get; set; }
        public string Livre { get; set; }
        public DateTime DateCommande { get; set; }
    }
}
