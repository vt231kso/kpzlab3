using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proxy
{
  public class SmartTextReaderLocker : ITextReader
  {
    private ITextReader _textReader;
    private Regex _allowedFileRegex;

    public SmartTextReaderLocker(ITextReader textReader, string pattern)
    {
      _textReader = textReader;
      _allowedFileRegex = new Regex(pattern);
    }

    public string[][] ReadFile(string filePath)
    {
      if (!_allowedFileRegex.IsMatch(filePath))
      {
        Console.WriteLine("Access denied!");
        return null;
      }

      return _textReader.ReadFile(filePath);
    }
  }
}
