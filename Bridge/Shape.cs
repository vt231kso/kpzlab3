using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
  public abstract class Shape
  {
    protected IShapeRenderer renderer;

    protected Shape(IShapeRenderer renderer)
    {
      this.renderer = renderer;
    }

    public abstract void Draw();
  }
}
