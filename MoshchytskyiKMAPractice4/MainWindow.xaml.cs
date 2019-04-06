using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MoshchytskyiKMAPractice4.Tools.Navigation;
using MoshchytskyiKMAPractice4.Tools.Managers;
using MoshchytskyiKMAPractice4.Tools.Storage;
using MoshchytskyiKMAPractice4.ViewModels;

namespace MoshchytskyiKMAPractice4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IContentOwner
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            InitializeApplication();
        }

        public ContentControl ContentControl
        {
            get => contentControl;
        }

        private void InitializeApplication()
        {
            StationManager.Initialize(new SerializedDataStorage());
            NavigationManager.Instance.Initialize(new InitializationNavigationModel(this));
            NavigationManager.Instance.Navigate(ViewType.Main);
        }
    }
}
