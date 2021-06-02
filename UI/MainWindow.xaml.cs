using DatabaseAccess;
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
using UI.AddWindow;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ReadAccess read;

        public MainWindow()
        {
            InitializeComponent();
            read = new ReadAccess();
            furnitureStoreGR.ItemsSource = read.ReadFurnitureStores();
            furnitureFactoryGR.ItemsSource = read.ReadFurnitureFactories();
            productGR.ItemsSource = read.ReadProducts();
            productTypesGR.ItemsSource = read.ReadProductTypes();
            sectorGR.ItemsSource = read.ReadSectors();
            employeeGR.ItemsSource = read.ReadEmployees();
            salesGR.ItemsSource = read.ReadSectors();
            reclamationServiceGR.ItemsSource = read.ReadSectors();
            callCenterGR.ItemsSource = read.ReadSectors();
            reclamationGR.ItemsSource = read.ReadReclamations();
            furnitureGR.ItemsSource = read.ReadFurnitures();
            clientGR.ItemsSource = read.ReadClients();
            complaintGR.ItemsSource = read.ReadComplaints();
        }

        private void bibliotekeBTN_Click(object sender, RoutedEventArgs e)
        {
            furnitureStoreGR.Visibility = Visibility.Visible;
            furnitureFactoryGR.Visibility = Visibility.Hidden;
            productGR.Visibility = Visibility.Hidden;
            productTypesGR.Visibility = Visibility.Hidden;
            sectorGR.Visibility = Visibility.Hidden;
            employeeGR.Visibility = Visibility.Hidden;
            salesGR.Visibility = Visibility.Hidden;
            reclamationServiceGR.Visibility = Visibility.Hidden;
            callCenterGR.Visibility = Visibility.Hidden;
            reclamationGR.Visibility = Visibility.Hidden;
            furnitureGR.Visibility = Visibility.Hidden;
            clientGR.Visibility = Visibility.Hidden;
            complaintGR.Visibility = Visibility.Hidden;

        }

        private void bibliotekariBTN_Click(object sender, RoutedEventArgs e)
        {
            furnitureStoreGR.Visibility = Visibility.Hidden;
            furnitureFactoryGR.Visibility = Visibility.Visible;
            productGR.Visibility = Visibility.Hidden;
            productTypesGR.Visibility = Visibility.Hidden;
            sectorGR.Visibility = Visibility.Hidden;
            employeeGR.Visibility = Visibility.Hidden;
            salesGR.Visibility = Visibility.Hidden;
            reclamationServiceGR.Visibility = Visibility.Hidden;
            callCenterGR.Visibility = Visibility.Hidden;
            reclamationGR.Visibility = Visibility.Hidden;
            furnitureGR.Visibility = Visibility.Hidden;
            clientGR.Visibility = Visibility.Hidden;
            complaintGR.Visibility = Visibility.Hidden;
        }

        private void clanBTN_Click(object sender, RoutedEventArgs e)
        {
            furnitureStoreGR.Visibility = Visibility.Hidden;
            furnitureFactoryGR.Visibility = Visibility.Hidden;
            productGR.Visibility = Visibility.Visible;
            productTypesGR.Visibility = Visibility.Hidden;
            sectorGR.Visibility = Visibility.Hidden;
            employeeGR.Visibility = Visibility.Hidden;
            salesGR.Visibility = Visibility.Hidden;
            reclamationServiceGR.Visibility = Visibility.Hidden;
            callCenterGR.Visibility = Visibility.Hidden;
            reclamationGR.Visibility = Visibility.Hidden;
            furnitureGR.Visibility = Visibility.Hidden;
            clientGR.Visibility = Visibility.Hidden;
            complaintGR.Visibility = Visibility.Hidden;
        }

        private void clanarinaBTN_Click(object sender, RoutedEventArgs e)
        {
            furnitureStoreGR.Visibility = Visibility.Hidden;
            furnitureFactoryGR.Visibility = Visibility.Hidden;
            productGR.Visibility = Visibility.Hidden;
            productTypesGR.Visibility = Visibility.Visible;
            sectorGR.Visibility = Visibility.Hidden;
            employeeGR.Visibility = Visibility.Hidden;
            salesGR.Visibility = Visibility.Hidden;
            reclamationServiceGR.Visibility = Visibility.Hidden;
            callCenterGR.Visibility = Visibility.Hidden;
            reclamationGR.Visibility = Visibility.Hidden;
            furnitureGR.Visibility = Visibility.Hidden;
            clientGR.Visibility = Visibility.Hidden;
            complaintGR.Visibility = Visibility.Hidden;
        }

        private void izdanjeBTN_Click(object sender, RoutedEventArgs e)
        {
            furnitureStoreGR.Visibility = Visibility.Hidden;
            furnitureFactoryGR.Visibility = Visibility.Hidden;
            productGR.Visibility = Visibility.Hidden;
            productTypesGR.Visibility = Visibility.Hidden;
            sectorGR.Visibility = Visibility.Visible;
            employeeGR.Visibility = Visibility.Hidden;
            salesGR.Visibility = Visibility.Hidden;
            reclamationServiceGR.Visibility = Visibility.Hidden;
            callCenterGR.Visibility = Visibility.Hidden;
            reclamationGR.Visibility = Visibility.Hidden;
            furnitureGR.Visibility = Visibility.Hidden;
            clientGR.Visibility = Visibility.Hidden;
            complaintGR.Visibility = Visibility.Hidden;
        }

        private void izdavacBTN_Click(object sender, RoutedEventArgs e)
        {
            furnitureStoreGR.Visibility = Visibility.Hidden;
            furnitureFactoryGR.Visibility = Visibility.Hidden;
            productGR.Visibility = Visibility.Hidden;
            productTypesGR.Visibility = Visibility.Hidden;
            sectorGR.Visibility = Visibility.Hidden;
            employeeGR.Visibility = Visibility.Visible;
            salesGR.Visibility = Visibility.Hidden;
            reclamationServiceGR.Visibility = Visibility.Hidden;
            callCenterGR.Visibility = Visibility.Hidden;
            reclamationGR.Visibility = Visibility.Hidden;
            furnitureGR.Visibility = Visibility.Hidden;
            clientGR.Visibility = Visibility.Hidden;
            complaintGR.Visibility = Visibility.Hidden;
        }

        private void knjigaBTN_Click(object sender, RoutedEventArgs e)
        {
            furnitureStoreGR.Visibility = Visibility.Hidden;
            furnitureFactoryGR.Visibility = Visibility.Hidden;
            productGR.Visibility = Visibility.Hidden;
            productTypesGR.Visibility = Visibility.Hidden;
            sectorGR.Visibility = Visibility.Hidden;
            employeeGR.Visibility = Visibility.Hidden;
            salesGR.Visibility = Visibility.Visible;
            reclamationServiceGR.Visibility = Visibility.Hidden;
            callCenterGR.Visibility = Visibility.Hidden;
            reclamationGR.Visibility = Visibility.Hidden;
            furnitureGR.Visibility = Visibility.Hidden;
            clientGR.Visibility = Visibility.Hidden;
            complaintGR.Visibility = Visibility.Hidden;
        }

        private void osobaBTN_Click(object sender, RoutedEventArgs e)
        {
            furnitureStoreGR.Visibility = Visibility.Hidden;
            furnitureFactoryGR.Visibility = Visibility.Hidden;
            productGR.Visibility = Visibility.Hidden;
            productTypesGR.Visibility = Visibility.Hidden;
            sectorGR.Visibility = Visibility.Hidden;
            employeeGR.Visibility = Visibility.Hidden;
            salesGR.Visibility = Visibility.Hidden;
            reclamationServiceGR.Visibility = Visibility.Visible;
            callCenterGR.Visibility = Visibility.Hidden;
            reclamationGR.Visibility = Visibility.Hidden;
            furnitureGR.Visibility = Visibility.Hidden;
            clientGR.Visibility = Visibility.Hidden;
            complaintGR.Visibility = Visibility.Hidden;
        }

        private void primerakBTN_Click(object sender, RoutedEventArgs e)
        {
            furnitureStoreGR.Visibility = Visibility.Hidden;
            furnitureFactoryGR.Visibility = Visibility.Hidden;
            productGR.Visibility = Visibility.Hidden;
            productTypesGR.Visibility = Visibility.Hidden;
            sectorGR.Visibility = Visibility.Hidden;
            employeeGR.Visibility = Visibility.Hidden;
            salesGR.Visibility = Visibility.Hidden;
            reclamationServiceGR.Visibility = Visibility.Hidden;
            callCenterGR.Visibility = Visibility.Visible;
            reclamationGR.Visibility = Visibility.Hidden;
            furnitureGR.Visibility = Visibility.Hidden;
            clientGR.Visibility = Visibility.Hidden;
            complaintGR.Visibility = Visibility.Hidden;
        }

        private void za_iznajmljivanjeBTN_Click(object sender, RoutedEventArgs e)
        {
            furnitureStoreGR.Visibility = Visibility.Hidden;
            furnitureFactoryGR.Visibility = Visibility.Hidden;
            productGR.Visibility = Visibility.Hidden;
            productTypesGR.Visibility = Visibility.Hidden;
            sectorGR.Visibility = Visibility.Hidden;
            employeeGR.Visibility = Visibility.Hidden;
            salesGR.Visibility = Visibility.Hidden;
            reclamationServiceGR.Visibility = Visibility.Hidden;
            callCenterGR.Visibility = Visibility.Hidden;
            reclamationGR.Visibility = Visibility.Visible;
            furnitureGR.Visibility = Visibility.Hidden;
            clientGR.Visibility = Visibility.Hidden;
            complaintGR.Visibility = Visibility.Hidden;
        }

        private void za_prodaju_Click(object sender, RoutedEventArgs e)
        {
            furnitureStoreGR.Visibility = Visibility.Hidden;
            furnitureFactoryGR.Visibility = Visibility.Hidden;
            productGR.Visibility = Visibility.Hidden;
            productTypesGR.Visibility = Visibility.Hidden;
            sectorGR.Visibility = Visibility.Hidden;
            employeeGR.Visibility = Visibility.Hidden;
            salesGR.Visibility = Visibility.Hidden;
            reclamationServiceGR.Visibility = Visibility.Hidden;
            callCenterGR.Visibility = Visibility.Hidden;
            reclamationGR.Visibility = Visibility.Hidden;
            furnitureGR.Visibility = Visibility.Visible;
            clientGR.Visibility = Visibility.Hidden;
            complaintGR.Visibility = Visibility.Hidden;
        }

        private void aaClick(object sender, RoutedEventArgs e)
        {
            furnitureStoreGR.Visibility = Visibility.Hidden;
            furnitureFactoryGR.Visibility = Visibility.Hidden;
            productGR.Visibility = Visibility.Hidden;
            productTypesGR.Visibility = Visibility.Hidden;
            sectorGR.Visibility = Visibility.Hidden;
            employeeGR.Visibility = Visibility.Hidden;
            salesGR.Visibility = Visibility.Hidden;
            reclamationServiceGR.Visibility = Visibility.Hidden;
            callCenterGR.Visibility = Visibility.Hidden;
            reclamationGR.Visibility = Visibility.Hidden;
            furnitureGR.Visibility = Visibility.Hidden;
            clientGR.Visibility = Visibility.Visible;
            complaintGR.Visibility = Visibility.Hidden;
        }

        private void bbClick(object sender, RoutedEventArgs e)
        {
            furnitureStoreGR.Visibility = Visibility.Hidden;
            furnitureFactoryGR.Visibility = Visibility.Hidden;
            productGR.Visibility = Visibility.Hidden;
            productTypesGR.Visibility = Visibility.Hidden;
            sectorGR.Visibility = Visibility.Hidden;
            employeeGR.Visibility = Visibility.Hidden;
            salesGR.Visibility = Visibility.Hidden;
            reclamationServiceGR.Visibility = Visibility.Hidden;
            callCenterGR.Visibility = Visibility.Hidden;
            reclamationGR.Visibility = Visibility.Hidden;
            furnitureGR.Visibility = Visibility.Hidden;
            clientGR.Visibility = Visibility.Hidden;
            complaintGR.Visibility = Visibility.Visible;
        }

        private void dodajBTN_Click(object sender, RoutedEventArgs e)
        {
            if (furnitureStoreGR.Visibility == Visibility.Visible)
            {
                var ab = new AddFurnitureStore();
                ab.Show();
            }
            
        }
    }
}
