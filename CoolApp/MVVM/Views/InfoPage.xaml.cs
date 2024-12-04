using System.Collections.ObjectModel;
using CoolApp.Data;
using CoolApp.MVVM.Models;

namespace CoolApp.MVVM.Views;

public partial class InfoPage : ContentPage
{
	private IDiseasesRepository diseasesRepository;
	public List<Disease> diseases = new List<Disease>();
	public ObservableCollection<Disease> diseasesCollection { get; set; } 

	public InfoPage(IDiseasesRepository diseasesRepo)
	{
		InitializeComponent();
		diseasesRepository = diseasesRepo;
		diseasesCollection = new ObservableCollection<Disease>();
		BindingContext = this;

	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		loadDiseases();
	}
	private void Load_List(object sender, EventArgs e)
	{
		loadDiseases();
	}

	private void Empty_List(object sender, EventArgs e)
	{
		diseasesCollection.Clear();
	}

	private void loadDiseases()
	{	
		diseases = diseasesRepository.GetAllDiseases();

		diseasesCollection.Clear();
		foreach (var disease in diseases)
		{
			diseasesCollection.Add(disease);
		}
		// diseasesList.ItemsSource = diseases;
	}
}