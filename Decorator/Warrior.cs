using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
  public class Warrior : IHero
  {
    private string name;
    public Warrior(string name) { this.name = name; }
    public int GetPower() => 10;
    public string GetDescription() => $"{name} (Warrior)";
  }
}
