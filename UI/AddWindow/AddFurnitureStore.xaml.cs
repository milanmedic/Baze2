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
using System.Windows.Shapes;

namespace UI.AddWindow
{
    /// <summary>
    /// Interaction logic for AddFurnitureStore.xaml
    /// </summary>
    public partial class AddFurnitureStore : Window
    {
        private CreateAccess create;
        public AddFurnitureStore()
        {
            InitializeComponent();
            create = new CreateAccess();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            create.CreateFurnitureStore(1, name.Text, street.Text, city.Text, Int32.Parse(street_num.Text), street_num_suffix.Text, DateTime.Now);
        }
    }
}
