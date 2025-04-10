using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
  public class Square : Shape
  {
    public Square(IShapeRenderer renderer) : base(renderer) { }
    public override void Draw() => renderer.Render("Square");
  }
}
