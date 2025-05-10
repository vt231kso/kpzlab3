using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
  public class LightTextNode : LightNode
  {
    private string _text;

    public LightTextNode(string text)
    {
      _text = text;
    }

    public override string InnerHTML => _text; 
    public override string OuterHTML => _text;

    public override void OnTextRendered()
    {
      Console.WriteLine($"[Text Rendered] Текст: {_text} відрендерено.");
    }

  }

}
