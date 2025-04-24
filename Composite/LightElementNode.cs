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

    private Dictionary<string, List<IEventListener>> _eventListeners = new();

    public LightElementNode(string tagName, string cssClass = "")
    {
      TagName = tagName;
      CssClass = cssClass;
    }

    public void AddEventListener(string eventType, IEventListener listener)
    {
      if (!_eventListeners.ContainsKey(eventType))
        _eventListeners[eventType] = new List<IEventListener>();

      _eventListeners[eventType].Add(listener);
    }

    public void TriggerEvent(string eventType)
    {
      if (_eventListeners.TryGetValue(eventType, out var listeners))
      {
        foreach (var listener in listeners)
        {
          listener.HandleEvent(eventType);
        }
      }
      else
      {
        Console.WriteLine($"No listeners for event '{eventType}' on <{TagName}>");
      }
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




    public void AddChild(LightNode child)
    {
      Children.Add(child);
    }
  }

}
