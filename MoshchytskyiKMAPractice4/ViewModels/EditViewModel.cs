using System;
using System.Threading.Tasks;
using System.Windows;
using MoshchytskyiKMAPractice4.Exceptions;
using MoshchytskyiKMAPractice4.Models;
using MoshchytskyiKMAPractice4.Tools;
using MoshchytskyiKMAPractice4.Tools.Managers;
using MoshchytskyiKMAPractice4.Tools.Navigation;

namespace MoshchytskyiKMAPractice4.ViewModels
{
    internal class EditViewModel : BaseViewModel
    {
        private RelayCommand<object> _proceedCommand;
        private RelayCommand<object> _cancelCommand;
        private String _email;
        private String _buttonName;

        public string ButtonName
        {
            get => _buttonName;
            set
            {
                _buttonName = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand<object> ProceedCommand
        {
            get
            {
                return _proceedCommand = new RelayCommand<object>(param => ProceedImplementation());
            }
        }

        public RelayCommand<object> CancelCommand
        {
            get => _cancelCommand = new RelayCommand<object>(p =>
            {
                NavigationManager.Instance.Navigate(ViewType.Main);
            });
        }

        public String Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        private async void ProceedImplementation()
        {
            LoaderManager.Instance.ShowLoader();
            try
            {
               if(!StationManager.DataStorage.PersonExists(Email)) throw new NotExistingUserException();
               if (ButtonName == "Remove")
               {
                   await Task.Run(() =>
                   {
                       StationManager.DataStorage.RemovePerson(StationManager.DataStorage.GetPersonByEmail(Email));
                       MessageBox.Show("Deletion was successful");
                   });
                   NavigationManager.Instance.Navigate(ViewType.Main, true);
               }
               else if (ButtonName == "Change")
               {
                   Person person = StationManager.DataStorage.GetPersonByEmail(Email);
                   NavigationManager.Instance.Navigate(ViewType.Input, person);
               }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            LoaderManager.Instance.HideLoader();
        }
    }
}