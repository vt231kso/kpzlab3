using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
  public class Mage : IHero
  {
    private string name;
    public Mage(string name) { this.name = name; }
    public int GetPower() => 8;
    public string GetDescription() => $"{name} (Mage)";
  }
}
