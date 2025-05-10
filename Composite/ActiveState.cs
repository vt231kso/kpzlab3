using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
  public class ActiveState : ILightElementState
  {
    public void AddChild(LightElementNode element, LightNode child)
    {
      element.Children.Add(child);
      Console.WriteLine($"[Active] Дитина додана до <{element.TagName}>");
    }
  }
}
