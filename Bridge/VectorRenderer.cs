using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
  public class VectorRenderer : IShapeRenderer
  {
    public void Render(string shape) => Console.WriteLine($"Drawing {shape} as vectors");
  }
}
