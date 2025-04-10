using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
  public class Paladin : IHero
  {
    private string name;
    public Paladin(string name) { this.name = name; }
    public int GetPower() => 9;
    public string GetDescription() => $"{name} (Paladin)";
  }
}
