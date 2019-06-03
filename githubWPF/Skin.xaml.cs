using githubWPF.DL;
using githubWPF.Models;
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

namespace githubWPF
{
    /// <summary>
    /// Interaction logic for Skin.xaml
    /// </summary>
    public partial class Skin : Window
    {
        public String Username { get; set; }
        public List<Repository> Repos { get; set; } = new List<Repository>();
        public Skin(string user)
        {
            Username = user;
            InitializeComponent();
            Load();
        }

        public async void Load()
        {
            await LoadRepos();
        }
        public async Task LoadRepos()
        {
            var rep = Repositories.get(Username);
            foreach (Repository r in rep)
            {
                Repos.Add(r);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            repositorys reposWindow = new repositorys(Repos);
            Wrapper.Children.Clear();
            Wrapper.Children.Add(reposWindow);
        }
    }
}
