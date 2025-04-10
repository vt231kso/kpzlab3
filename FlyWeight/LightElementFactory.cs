using Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
  public class LightElementFactory
  {
    private Dictionary<string, LightElementNode> elements = new();

    public LightElementNode GetElement(string tag)
    {
      if (!elements.ContainsKey(tag))
      {
        elements[tag] = new LightElementNode(tag);
      }
      return elements[tag];
    }
  }
}
