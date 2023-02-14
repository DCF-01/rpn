using RPNCalculator.Core.Command;

namespace RPNCalculator.Core.Memento;

public class CommandCollectionMemento
{
    private Stack<ICommand> _state;
    public CommandCollectionMemento(ICollection<ICommand> state)
    {
        var newList = new List<ICommand>();
        
        foreach (var cmd in _state)
        {
            newList.Add(cmd);
        }

        _state = newList;
    }

    public ICollection<ICommand> GetState()
    {
        return _state;
    }
}