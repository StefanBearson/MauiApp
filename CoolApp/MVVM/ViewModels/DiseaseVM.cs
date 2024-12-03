using CommunityToolkit.Mvvm.ComponentModel;

namespace CoolApp.MVVM.Models
{

    public class DiseaseVM : ObservableObject
    {
        private int id;
        private string name;
        private string image;
        private string description;

        public int Id { get => id; set => SetProperty(ref id, value); }

        public string Name { get => name; set => SetProperty(ref name, value); }


        public string Image { get => image; set => SetProperty(ref image, value); }

        public string Description { get => description; set => SetProperty(ref description, value); }
    }
}