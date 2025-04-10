using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLoggerAdapter
{
  public class FileLogger : Logger
  {
    private FileWriter fileWriter;

    public FileLogger(string filePath)
    {
      fileWriter = new FileWriter(filePath);
    }

    public override void Log(string message)
    {
      fileWriter.WriteLine("[INFO]: " + message);
    }

    public override void Error(string message)
    {
      fileWriter.WriteLine("[ERROR]: " + message);
    }

    public override void Warn(string message)
    {
      fileWriter.WriteLine("[WARNING]: " + message);
    }
  }

}
