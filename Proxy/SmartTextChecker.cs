using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
  public class SmartTextChecker : ITextReader
  {
    private ITextReader _textReader;

    public SmartTextChecker(ITextReader textReader)
    {
      _textReader = textReader;
    }

    public string[][] ReadFile(string filePath)
    {
      Console.WriteLine($"Opening file: {filePath}");

      string[][] content = _textReader.ReadFile(filePath);

      int lineCount = content.Length;
      int charCount = 0;
      foreach (var line in content)
      {
        charCount += line.Length;
      }

      Console.WriteLine($"File read successfully. Lines: {lineCount}, Characters: {charCount}");
      Console.WriteLine($"Closing file: {filePath}");

      return content;
    }

  }
}
