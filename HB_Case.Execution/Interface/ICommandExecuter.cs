using System.Text.RegularExpressions;

namespace HB_Case.Execution
{
    public interface ICommandExecuter
    {
        Regex RegexCommandPattern { get; }
        void ExecuteCommand(string command);
        bool MatchCommand(string command);
    }
}