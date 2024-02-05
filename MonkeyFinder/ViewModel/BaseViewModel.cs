using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MonkeyFinder.ViewModel;

[INotifyPropertyChanged]
public partial class BaseViewModel 
{
    bool isBusy;
    string title;
}