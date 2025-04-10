using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLoggerAdapter
{
  class FileWriter
  {
    private string filePath;

    public FileWriter(string filePath)
    {
      this.filePath = filePath;
    }

    public void Write(string message)
    {
      File.AppendAllText(filePath, message);
    }

    public void WriteLine(string message)
    {
      File.AppendAllText(filePath, message + "\n");
    }
  }
}
