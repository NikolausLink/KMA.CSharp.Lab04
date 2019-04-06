using System.ComponentModel;

namespace MoshchytskyiKMAPractice4.Tools
{
    public interface ILoaderOwner : INotifyPropertyChanged
    {
        bool IsControlEnabled { get; set; }
    }
    
}
    
