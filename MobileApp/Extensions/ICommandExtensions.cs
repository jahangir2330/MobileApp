﻿using System.Windows.Input;

namespace MobileApp;

public static class ICommandExtensions
{
    public static void AttemptNotifyCanExecuteChanged<TCommand>(this TCommand command)
        where TCommand : ICommand
    {
        if (command is IRelayCommand rc)
        {
            rc?.NotifyCanExecuteChanged();
        }
    }
}

