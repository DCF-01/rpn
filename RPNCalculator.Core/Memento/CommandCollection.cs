using RPNCalculator.Core.Command;

namespace RPNCalculator.Core.Memento;

public class CommandCollection
{
    private ICollection<ICommand> _state;

    public CommandCollectionMemento Save()
    {
        return new CommandCollectionMemento(_state);
    }

    public void Resture(CommandCollectionMemento memento)
    {
        this._state = memento.GetState();
    }
}