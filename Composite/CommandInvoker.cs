using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
  public class CommandInvoker
  {
    private readonly List<ICommand> _commands = new();

    public void AddCommand(ICommand command)
    {
      _commands.Add(command);
    }

    public void ExecuteAll()
    {
      foreach (var command in _commands)
      {
        command.Execute();
      }
      _commands.Clear(); // опційно: очищаємо після виконання
    }
  }

}
