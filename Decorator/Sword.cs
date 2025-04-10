using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
  public class Sword : InventoryDecorator
  {
    public Sword(IHero hero) : base(hero) { }
    public override int GetPower() => hero.GetPower() + 5;
    public override string GetDescription() => hero.GetDescription() + " + Sword";
  }
}
