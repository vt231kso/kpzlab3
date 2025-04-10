using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
  public class SmartTextReader : ITextReader
  {
    public string[][] ReadFile(string filePath)
    {
      var lines = File.ReadAllLines(filePath);
      string[][] result = new string[lines.Length][];

      for (int i = 0; i < lines.Length; i++)
      {
        result[i] = new string[lines[i].Length];
        for (int j = 0; j < lines[i].Length; j++)
        {
          result[i][j] = lines[i][j].ToString();
        }
      }

      return result;
    }
  }
}
