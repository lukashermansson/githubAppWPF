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
    /// Interaction logic for repositorys.xaml
    /// </summary>
    public partial class repositorys : UserControl
    {
        public ObservableCollection<Repository> Repos { get; set; } = new ObservableCollection<Repository>();
        public repositorys(ObservableCollection<Repository> repos)
        {
            Repos = repos;
            InitializeComponent();
        }
    }
}
