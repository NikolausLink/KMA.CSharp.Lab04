using System.Windows.Controls;
using MoshchytskyiKMAPractice4.Tools.Navigation;
using MoshchytskyiKMAPractice4.ViewModels;

namespace MoshchytskyiKMAPractice4.Views
{
    /// <summary>
    /// Логика взаимодействия для ListView.xaml
    /// </summary>
    public partial class ListView : UserControl, INavigatable
    {
        public ListView()
        {
            InitializeComponent();
            DataContext = new ListViewModel();
            this.Grid.IsReadOnly = true;
        }
    }
}
