using Caliburn.Micro;

namespace Aula19.ViewModels;

public class MainViewModel : Screen
{
    private string _nomeCompleto = string.Empty;

    public string NomeCompleto
    {
        get => _nomeCompleto;
        set
        {
            _nomeCompleto = value;
            base.NotifyOfPropertyChange(() => NomeCompleto);
        }
    }
}
