namespace RPNCalculator.Core.Memento;

public class MementoCaretaker
{
    private static ICollection<CommandCollectionMemento> _collectionMementoes;
    private static int _currentPosition = 0;
    private MementoCaretaker()
    {
        _collectionMementoes = new List<CommandCollectionMemento>();
    }

    public static CommandCollectionMemento Undo()
    {
        if (_currentPosition < 0)
        {
            return _collectionMementoes.ElementAt(0);
        }

        _currentPosition -= 1;
        return _collectionMementoes.ElementAt(_currentPosition);
    }
    
    public static CommandCollectionMemento Redo()
    {
        if (_currentPosition > _collectionMementoes.Count - 1)
        {
            return _collectionMementoes.ElementAt(_collectionMementoes.Count - 1);
        }

        _currentPosition += 1;
        return _collectionMementoes.ElementAt(_currentPosition);
    }
}