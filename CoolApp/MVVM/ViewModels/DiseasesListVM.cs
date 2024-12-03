using CommunityToolkit.Mvvm.ComponentModel;
using CoolApp.MVVM.Models;

namespace CoolApp.MVVM.ViewModels
{
    public class DiseasesListVM : ObservableObject
    {
        private List<Disease> diseases;

        public List<Disease> Diseases { get => diseases; set => SetProperty(ref diseases, value); }
    }
}