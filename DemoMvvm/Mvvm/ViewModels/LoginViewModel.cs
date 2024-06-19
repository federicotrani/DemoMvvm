using DemoMvvm.Mvvm.Views;
using System.Windows.Input;

namespace DemoMvvm.Mvvm.ViewModels;

public class LoginViewModel : BaseViewModel
{
    public ICommand LoginCommand { private set; get; }
    public LoginViewModel()
    {
        Title = "Pantalla de Inicio";

        LoginCommand = new Command(execute:async() => await Login());
    }

    private string name;
    public string Name
    {
        get => name;
        set
        {
            SetProperty(ref name, value);            
        }
    }

    private string password;
    public string Password
    {
        get => password;
        set
        {
            SetProperty(ref password, value);
        }
    }    

    private async Task Login()
    {
        
        if (!IsBusy)
        {
            Application.Current.MainPage.DisplayAlert("ITES", $"login correcto de {name}", "ok");
            IsBusy = true;
            await Task.Delay(3000);
            //await
            Application.Current.MainPage.Navigation.PushAsync(new PrincipalPage());
            Name = string.Empty;
            Password = string.Empty;
            //Podemos sobrescribir la MainPage si queremos tener una sola
            //página en la navegación
            Application.Current.MainPage = new NavigationPage(new PrincipalPage());
            IsBusy = false;
        }
    }
}
