namespace RPNCalculator.Core.Command;

public class CalculateCommand : ICommand
{
    private readonly ICollection<ICommand> _receiver;

    public CalculateCommand(ICollection<ICommand> receiver)
    {
        _receiver = receiver;
    }
    public void Execute()
    {
        throw new NotImplementedException();
    }
}