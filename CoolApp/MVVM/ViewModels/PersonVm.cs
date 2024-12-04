using CommunityToolkit.Mvvm.ComponentModel;

namespace CoolApp.MVVM.ViewModels;

public class PersonVm: ObservableObject
{
  private string? name;
  private int age;
  private bool isCool;
  public string Name
  {
    get => name;
    set => SetProperty(ref name, value);
  }
  public int Age
  {
    get => age;
    set => SetProperty(ref age, value);
  }
  public bool IsCool 
  { 
    get => isCool; 
    set => SetProperty(ref isCool, value); }
  
}
