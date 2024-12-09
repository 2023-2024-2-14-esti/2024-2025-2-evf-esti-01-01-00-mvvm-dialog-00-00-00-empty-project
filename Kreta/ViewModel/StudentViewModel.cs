using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Models;

namespace Kreta.ViewModel
{
    public partial class StudentViewModel : ObservableObject
    {
        [ObservableProperty]
        private Student _student = new Student();
    }
}
