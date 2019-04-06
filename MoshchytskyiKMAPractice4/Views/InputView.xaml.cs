using System.Windows.Controls;
using MoshchytskyiKMAPractice4.Tools.Navigation;
using MoshchytskyiKMAPractice4.ViewModels;

namespace MoshchytskyiKMAPractice4.Views
{
    /// <summary>
    /// Логика взаимодействия для InputView.xaml
    /// </summary>
    public partial class InputView : UserControl, INavigatable
    {
        public InputView()
        {
            InitializeComponent();
            DataContext = new InputViewModel();
        }
    }
}
