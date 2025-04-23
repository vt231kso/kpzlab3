using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
  public class ClickListener : IEventListener
  {
    private string _name;

    public ClickListener(string name)
    {
      _name = name;
    }

    public void HandleEvent(string eventType)
    {
      Console.WriteLine($"{_name} received event: {eventType}");
    }
  }

}
