using githubWPF.DL;
using githubWPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace githubWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Repository> Repos { get; set; } = new ObservableCollection<Repository>();
        public MainWindow(String username)
        {
            
            InitializeComponent();
            dgrid.ItemsSource = Repos;
            var rep = Repositories.get(username);
            foreach (Repository r in rep)
            {
                Repos.Add(r);
            }


        }

        private void Row_clicked(object sender, MouseButtonEventArgs e)
        {
            DataGridRow row = sender as DataGridRow;

            

            Console.WriteLine(row.Item);
        }
    }
}
