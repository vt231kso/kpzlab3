using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLoggerAdapter
{
  public class Logger
  {
    public virtual void Log(string message)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("[INFO]: " + message);
      Console.ResetColor();
    }

    public virtual void Error(string message)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("[ERROR]: " + message);
      Console.ResetColor();
    }

    public virtual void Warn(string message)
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("[WARNING]: " + message);
      Console.ResetColor();
    }
  }
}
