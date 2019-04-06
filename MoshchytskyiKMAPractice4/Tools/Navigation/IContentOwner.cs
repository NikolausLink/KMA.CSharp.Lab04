using System.Windows.Controls;

namespace MoshchytskyiKMAPractice4.Tools.Navigation
{
    internal interface IContentOwner
    {
        ContentControl ContentControl { get; }
    }
}