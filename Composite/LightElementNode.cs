using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
  public class LightElementNode : LightNode
  {
    public string TagName { get; }
    public List<LightNode> Children { get; } = new();
    public string CssClass { get; }
    private ILightElementState _state = new ActiveState();

    public LightElementNode(string tagName, string cssClass = "")
    {
      TagName = tagName;
      CssClass = cssClass;
    }
  
    public void SetState(ILightElementState newState)
    {
      _state = newState;
    }
    public void AddChild(LightNode child)
    {
      _state.AddChild(this, child);
    }

    public override string InnerHTML
    {
      get
      {
        return string.Join("\n", Children.Select(child => child.InnerHTML)); 
      }
    }

    public override string OuterHTML
    {
      get
      {
        string classAttr = string.IsNullOrEmpty(CssClass) ? "" : $" class=\"{CssClass}\"";
        string innerHtml = string.Join("\n", Children.Select(child => child.OuterHTML));
        return $"<{TagName}{classAttr}>\n{innerHtml}\n</{TagName}>";
      }
    }

  }

}
