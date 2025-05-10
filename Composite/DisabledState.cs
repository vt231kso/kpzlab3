using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
  public class DisabledState : ILightElementState
  {
    public void AddChild(LightElementNode element, LightNode child)
    {
      Console.WriteLine($"[Disabled] Неможливо додати дитину до <{element.TagName}> — елемент заблокований");
    }
  }
}
