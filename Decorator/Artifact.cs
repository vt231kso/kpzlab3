using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
  public class Artifact : InventoryDecorator
  {
    public Artifact(IHero hero) : base(hero) { }
    public override int GetPower() => hero.GetPower() + 7;
    public override string GetDescription() => hero.GetDescription() + " + Artifact";
  }
}
