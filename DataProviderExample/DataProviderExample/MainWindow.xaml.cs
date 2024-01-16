using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

namespace DataProviderExample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Detachment detachment;
        public MainWindow()
        {
            InitializeComponent();
            //detachment = new Detachment();
        }

        

        private void hobbitsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbEditedName.Text = ((Hobbit)hobbitsBox.SelectedItem).name;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var collection = hobbitsBox.ItemsSource;
            Hobbit hobbit = new Hobbit();
            hobbit.name = tbEditedName.Text;
            ((ObservableCollection<Hobbit>)collection).Add(hobbit);

        }
    }

}
