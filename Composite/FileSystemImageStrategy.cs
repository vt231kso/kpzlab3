using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
  public class FileSystemImageStrategy : IImageLoadingStrategy
  {
    public string LoadImage(string href)
    {
      return $"<img src=\"file://{href}\" />";
    }
  }
}
