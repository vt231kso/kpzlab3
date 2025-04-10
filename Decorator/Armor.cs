using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
 public class Armor : InventoryDecorator
  {
    public Armor(IHero hero) : base(hero) { }
    public override int GetPower() => hero.GetPower() + 3;
    public override string GetDescription() => hero.GetDescription() + " + Armor";
  }
}
