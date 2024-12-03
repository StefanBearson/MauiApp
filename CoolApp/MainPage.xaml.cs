namespace CoolApp;
using CoolApp.MVVM.Models;
using CoolApp.MVVM.ViewModels;
using CoolApp.Data;
using Bogus;

public partial class MainPage : ContentPage
{
	int count = 0;
	PersonVm person;
	private IDiseasesRepository diseasesRepository;

	public MainPage(IDiseasesRepository repo)
	{
		diseasesRepository = repo;
		InitializeComponent();

		person = new PersonVm { Name = "John Doe", Age = 25, IsCool = true };
		BindingContext = person;
	}

	private void OnMe(object sender, EventArgs e){

		Disease dis = new Faker<Disease>()
			.RuleFor(d => d.Name, f => f.Name.FullName())
			.RuleFor(d => d.Image, f => f.Image.PicsumUrl())
			.RuleFor(d => d.Description, f => f.Lorem.Paragraph())
			.Generate();

		diseasesRepository.Add(dis);

		if (person.IsCool){
			person.Name = "Kalle Anka";
			person.IsCool = false;
			border.Stroke = new SolidColorBrush(Colors.Red);

		}
			
		else{
			person.Name = "John Doe";
			person.IsCool = true;
			border.Stroke = new SolidColorBrush(Colors.Blue);

		}
	}

	public void Test(object sender, EventArgs e){
		border.Stroke = new SolidColorBrush(Colors.Blue);
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		var dis = diseasesRepository.GetDisease(1);

		person.Name = dis.Name;

		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void SearchIt(object sender, EventArgs e)

    {

        // Add your search logic here

    }
	private void OnCompleted(object sender, EventArgs e)
	{
		// Add your logic here
	}
}

