using DemoMvvm.Mvvm.Models;
using System.Collections.ObjectModel;

namespace DemoMvvm.Mvvm.ViewModels;

public class PersonasViewModel : BaseViewModel
{
    ObservableCollection<Persona> personas = new ObservableCollection<Persona>();
    public ObservableCollection<Persona> Personas { get { return personas; } }

    public PersonasViewModel()
    {
        personas.Add(new Persona { PlayerId = 1, PlayerName = "Virat Kohi", PlayerImage = "icon.png", Country = "INDIA" });
        personas.Add(new Persona { PlayerId = 2, PlayerName = "Rohit Sharma", PlayerImage = "icon.png", Country = "INDIA" });
        personas.Add(new Persona { PlayerId = 3, PlayerName = "Shubhman Gill", PlayerImage = "icon.png", Country = "INDIA" });
        personas.Add(new Persona { PlayerId = 4, PlayerName = "Shikhar Dhawan", PlayerImage = "icon.png", Country = "INDIA" });
        personas.Add(new Persona { PlayerId = 5, PlayerName = "Suryakumar Yadav", PlayerImage = "icon.png", Country = "INDIA" });
        personas.Add(new Persona { PlayerId = 6, PlayerName = "MahendraSingh Dhoni", PlayerImage = "icon.png", Country = "INDIA" });
        personas.Add(new Persona { PlayerId = 7, PlayerName = "Jasprit Bumrah", PlayerImage = "icon.png", Country = "INDIA" });
        personas.Add(new Persona { PlayerId = 8, PlayerName = "Hardik Pandya", PlayerImage = "icon.png", Country = "INDIA" });
        personas.Add(new Persona { PlayerId = 9, PlayerName = "Shreyes Iyer", PlayerImage = "icon.png", Country = "INDIA" });
        personas.Add(new Persona { PlayerId = 10, PlayerName = "Rishabh Pant", PlayerImage = "icon.png", Country = "INDIA" });
        personas.Add(new Persona { PlayerId = 11, PlayerName = "Rvindra Jadeja", PlayerImage = "icon.png", Country = "INDIA" });
    }    


}
