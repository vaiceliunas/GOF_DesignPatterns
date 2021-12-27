namespace GOF_Behavioral_Command.Models.Interfaces
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}
