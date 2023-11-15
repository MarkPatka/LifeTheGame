using Life_The_Game.Infrastructure.Commands;
using Life_The_Game.ViewModels.Base;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Life_The_Game.ViewModels;

internal class MainWindowViewModel : ViewModel
{
    private readonly GameFieldViewModel _gameFieldViewModel;

    private int[] _densityValues = new int[] 
    { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    private int[] _resolutionValues = new int[] 
    { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

    private int _selectedDensity;
    private int _selectedResolution;

    public int[] Density
    {
        get => _densityValues;
        set
        {
            Set(ref _densityValues, value);
            OnPropertyChanged();
        }
    }
    public int[] Resolution
    {
        get => _resolutionValues;
        set
        {
            Set(ref _resolutionValues, value);
            OnPropertyChanged();
        }
    }
    
    public int SelectedDensity
    {
        get => _selectedDensity;
        set
        {
            Set(ref _selectedDensity, value);
            OnPropertyChanged();
        }
    }
    public int SelectedResolution
    {
        get => _selectedResolution;
        set
        {
            Set(ref _selectedResolution, value);
            OnPropertyChanged();
        }
    }

    public GameFieldViewModel GameFieldViewModel => _gameFieldViewModel;


    public MainWindowViewModel()
    {
        _gameFieldViewModel = new();

    }

    private ICommand startGenerationCommand;
    private bool CanStartGenerationExecute(object p) => true;
    private void CanStartGenerationExecuted(object p) => StartGeneration();

    public ICommand StartGenerationCommand => startGenerationCommand 
        ??= new DelegateCommand(CanStartGenerationExecuted!, CanStartGenerationExecute!);

    private void StartGeneration()
    {

    }


    
}
