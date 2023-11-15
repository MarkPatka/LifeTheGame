﻿using System;
using System.Windows.Input;

namespace Life_The_Game.Infrastructure.Commands.Base;

internal abstract class Command : ICommand
{
    public event EventHandler? CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }

    private bool executable = true;
    public bool Executable
    {
        get => executable;
        set
        {
            if (executable == value) return;

            executable = value;
            CommandManager.InvalidateRequerySuggested();
        }
    }

    bool ICommand.CanExecute(object? parameter) => executable && CanExecute(parameter);
    void ICommand.Execute(object? parameter)
    {
        if (CanExecute(parameter))
            Execute(parameter);
    }
    public virtual bool CanExecute(object? parameter) => true;
    public abstract void Execute(object? parameter);
}
