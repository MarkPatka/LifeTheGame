using Life_The_Game.Infrastructure.Commands.Base;
using System;

namespace Life_The_Game.Infrastructure.Commands;

internal class DelegateCommand : Command
{
    private readonly Action<object?> execute;
    private readonly Func<object?, bool>? canExecute;

    public DelegateCommand(Action Execute, Func<bool>? CanExecute = null)
        : this(Execute: p => Execute(),
              CanExecute: CanExecute is null ? null : p => CanExecute())
    {

    }

    public DelegateCommand(Action<object?> Execute, Func<object?, bool>? CanExecute)
    {
        execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
        canExecute = CanExecute;
    }

    public override bool CanExecute(object? parameter) => canExecute?.Invoke(parameter) ?? true;
    public override void Execute(object? parameter) => execute(parameter);

}
