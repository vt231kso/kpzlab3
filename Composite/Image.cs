using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
  public class Image : LightNode
  {
    private readonly string _href;
    private readonly IImageLoadingStrategy _strategy;

    public Image(string href)
    {
      _href = href;
      _strategy = DetermineStrategy(href);
    }

    private IImageLoadingStrategy DetermineStrategy(string href)
    {
      if (href.StartsWith("http"))
        return new NetworkImageStrategy();
      else
        return new FileSystemImageStrategy();
    }

    public override string InnerHTML => "";
    public override string OuterHTML => _strategy.LoadImage(_href);
  }
}
