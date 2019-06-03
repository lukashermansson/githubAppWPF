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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace githubWPF
{
    /// <summary>
    /// Interaction logic for repositorys.xaml
    /// </summary>
    public partial class repositorys : UserControl
    {
        public List<Repository> Repos { get; set; } = new List<Repository>();
        public repositorys(List<Repository> repos)
        {
            Repos = repos;
            InitializeComponent();
        }
    }
}
