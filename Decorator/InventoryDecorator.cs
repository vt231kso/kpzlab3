using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
  public abstract class InventoryDecorator : IHero
  {
    protected IHero hero;
    public InventoryDecorator(IHero hero)
    {
      this.hero = hero;
    }
    public abstract int GetPower();
    public abstract string GetDescription();
  }
}
